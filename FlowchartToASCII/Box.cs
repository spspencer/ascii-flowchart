using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlowchartToASCII
{
    class Box
    {
        int Cols; int Rows;
        string sText;
        string dText;
        int height = 0;
        int witdh = 0;

        //char c = Environment.NewLine;

        public Box(string Text)
        {
            sText = Text;
            if (Text.Length > 0 )
            {
                string[] VerticaDivision = Text.Split(new char[] { '\n' });
                if (VerticaDivision.Length>0)
                {
                    Rows = VerticaDivision.Length;
                    foreach (string str in VerticaDivision)
                    {
                        int tCol = str.Length;
                        Cols = tCol > Cols ? tCol : Cols;
                    }
                }
            }
            dText = Draw();
        }

        private string Draw ()
        {
            System.Text.StringBuilder sb  = new StringBuilder("");
            sb.Append("+-");
            for (int i = 0; i < Cols; i++ )
            {
                sb.Append("-");
            }
            sb.Append("--+");
            sb.Append(Environment.NewLine);

            string[] VerticaDivision = sText.Split(new char[] { '\n' });
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
//             SetHieghtAndWidth(dText);
//             return dText;
        }
        

        private void SetHieghtAndWidth(string Text)
        {
            string[] VerticaDivision = Text.Split(new char[] { '\n' });
            if (VerticaDivision.Length > 0)
            {
                height = VerticaDivision.Length;
                foreach (string str in VerticaDivision)
                {
                    int tCol = str.Length;
                    witdh = tCol > witdh ? tCol : witdh;
                }
            }
        }
        public int Width
        {
            get { return witdh; }
        }

        public int Height
        {
            get { return height; }
        }

        public string Text
        {
            get { return dText; }
        }
    }
}
