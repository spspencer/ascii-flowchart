using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlowchartToASCII
{
    
    [Serializable]
    public enum CompType{ box, Link, Arrow, point };

    [Serializable]
    public abstract class  BaseType
    {
        public Guid Id;
        public CompType type;
        public string Text;
        public System.Drawing.Point StartPt;
        public abstract string Draw();
        public abstract bool Detect(System.Drawing.Point pTest);
    }

    [Serializable]
    public class BoxType
        :BaseType
    {
        int Cols, Rows, height, width;

        public BoxType()
        {
            type = CompType.box;
            Cols = 0;
            Rows = 0;
            height = 0;
            width = 0;
        }

        public BoxType(System.Drawing.Point p, string str)
        {
            Id = Guid.NewGuid();
            type = CompType.box;
            Text = str;
            StartPt = p;

            if (Text.Length > 0)
            {
                string[] VerticaDivision = Text.Split(new char[] { '\n' });
                if (VerticaDivision.Length > 0)
                {
                    Rows = VerticaDivision.Length;
                    foreach (string s in VerticaDivision)
                    {
                        int tCol = s.Length;
                        Cols = tCol > Cols ? tCol : Cols;
                    }
                }
            }
            Text = Draw();
        }

        public override string Draw()
        {
            System.Text.StringBuilder sb = new StringBuilder("");
            sb.Append("+-");
            for (int i = 0; i < Cols; i++)
            {
                sb.Append("-");
            }
            sb.Append("--+");
            sb.Append(Environment.NewLine);

            string[] VerticaDivision = Text.Split(new char[] { '\n' });
            if (VerticaDivision.Length > 0)
            {
                foreach (string str in VerticaDivision)
                {
                    string tempStr;
                    sb.Append("| ");
                    tempStr = str.Replace("\r", "");
                    tempStr = tempStr.PadRight(Cols);
                    sb.Append(tempStr);
                    sb.Append("  |");
                    sb.Append(Environment.NewLine);
                }
            }
            sb.Append("+-");
            for (int i = 0; i < Cols; i++)
            {
                sb.Append("-");
            }
            sb.Append("--+");
            return sb.ToString();
        }

        private void SetHieghtAndWidth()
        {
            width = 0;
            height = 0;
            string[] VerticaDivision = Text.Split(new char[] { '\n' });
            if (VerticaDivision.Length > 0)
            {
                height = VerticaDivision.Length;
                foreach (string str in VerticaDivision)
                {
                    int tCol = str.Length;
                    width = tCol > width ? tCol : width;
                }
            }
        }

        public override bool Detect(System.Drawing.Point pTest)
        {
            SetHieghtAndWidth();
            System.Drawing.Rectangle r = new System.Drawing.Rectangle(StartPt.X, StartPt.Y, width, height);
            return r.Contains(pTest);
        }
    }

    [Serializable]
    public class LinkType
        :BaseType
    {
        int Length;
        char c;
        System.Drawing.Point EndPt;

        public LinkType()
        {
            type = CompType.Link;
        }

        public LinkType(System.Drawing.Point p1, System.Drawing.Point p2, char c)
        {
            Id = Guid.NewGuid();
            type = CompType.Link;
            int xStart = 0;
            int xEnd = 0;
            if (c == '-')
            {
                StartPt = p1.X < p2.X ? p1 : p2;
                EndPt = p1.X > p2.X ? p1 : p2;
                xStart = p1.X > p2.X ? p2.X : p1.X;
                xEnd = p1.X < p2.X ? p2.X : p1.X;
                Text = "";
                for (int i = xStart + 1; i < xEnd; i++)
                {
                    Text = Text + c.ToString();
                }
            }
            else if (c == '|')
            {
                StartPt = p1.Y < p2.Y ? p1 : p2;
                EndPt = p1.Y > p2.Y ? p1 : p2;
                xStart = p1.Y > p2.Y ? p2.Y : p1.Y;
                xEnd = p1.Y < p2.Y ? p2.Y : p1.Y;

                for (int i = xStart + 1; i < xEnd; i++)
                {
                    Text = Text + c.ToString();
                }
            }
        }

        public override string Draw()
        {
            return Text;
        }

        public override bool Detect(System.Drawing.Point pTest)
        {
            bool status = false;

            if (Text.Contains('-'))
            {
                return StartPt.X < pTest.X ? (StartPt.X + Text.Length) > pTest.X ? StartPt.Y == pTest.Y ? true : false : false : false;
            }
            else
                return StartPt.Y < pTest.Y ? (StartPt.Y + Text.Length) > pTest.Y ? StartPt.X == pTest.X ? true : false : false : false;

            return status;
        }
    }


    [Serializable]
    public class ArrowType
        : BaseType
    {
        public ArrowType()
        {
            type = CompType.Arrow;
        }

        public ArrowType(System.Drawing.Point p, string str)
        {
            Id = Guid.NewGuid();
            type = CompType.Arrow;
            Text = str;
            StartPt = p;
        }
        public override string Draw()
        {
            return Text;
        }

        public override bool Detect(System.Drawing.Point pTest)
        {
            return StartPt == pTest ? true : false;
        }
    }

    [Serializable]
    public class PointType
        : BaseType
    {
        public PointType()
        {
            type = CompType.point;
        }

        public PointType(System.Drawing.Point p, string str)
        {
            Id = Guid.NewGuid();
            type = CompType.point;
            Text = str;
            StartPt = p;
        }
        public override string Draw()
        {
            return Text;
        }

        public override bool Detect(System.Drawing.Point pTest)
        {
            return StartPt == pTest ? true : false;
        }
    }
}
