using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlowchartToASCII
{
    
    [Serializable]
    public enum CompType{ box, link, point };

    [Serializable]
    public abstract class  BaseType
    {
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
            Cols = 0;
            Rows = 0;
            height = 0;
            width = 0;
        }

        public BoxType(System.Drawing.Point p, string str)
        {
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

}
