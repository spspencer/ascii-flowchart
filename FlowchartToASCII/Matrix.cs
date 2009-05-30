using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlowchartToASCII
{
    class Matrix
    {
        private char[,] _m;
        private System.Drawing.Size _size;

        public Matrix(System.Drawing.Size size)
        {
            _m = new char[size.Width, size.Height];
            _size = new System.Drawing.Size(size.Width,size.Height);

            for (int i = 0; i < size.Width; i++ )
            {
                for (int j = 0; j < size.Height; j++ )
                {
                    _m[i, j] = ' ';
                }
            }
        }

        public void Reset()
        {
            for (int i = 0; i < _size.Width; i++)
            {
                for (int j = 0; j < _size.Height; j++)
                {
                    _m[i, j] = ' ';
                }
            }
        }


        public void Add(Box b, System.Drawing.Point p)
        {
            string sText = b.Text;
            int x = 0; int y = 0; int z = 0;

            foreach (char c in sText)
            {
                if (c == '\r')
                {
                    x += 1;
                }
                else if (c == '\n')
                {
                    z = x; 
                    y += 1;
                }
                else
                {
                    _m[y + p.Y, x + p.X - z] = c;
                    x += 1;
                }
            }          
        }

        public void Add(BaseType b)
        {
            if (b.type == CompType.box)
            {            
                string sText = b.Text;
                int x = 0; int y = 0; int z = 0;

                foreach (char c in sText)
                {
                    if (c == '\r')
                    {
                        x += 1;
                    }
                    else if (c == '\n')
                    {
                        z = x;
                        y += 1;
                    }
                    else
                    {
                        _m[y + b.StartPt.Y, x + b.StartPt.X - z] = c;
                        x += 1;
                    }
                }
            }
            else if (b.type == CompType.Link)
            {
                int Length = b.Text.Length;
                int xEnd = 0;
                if (b.Text.Contains("-"))
                {
                    for (int i = 1; i <= Length; i++)
                    {
                        _m[b.StartPt.Y, b.StartPt.X + i] = '-';
                    }
                }
                else if (b.Text.Contains("|"))
                {
                    for (int i = 1; i <= Length; i++)
                    {
                        _m[b.StartPt.Y + i, b.StartPt.X] = '|';
                    }
                }
            }
            else if (b.type == CompType.Arrow || b.type == CompType.point)
            {
                _m[b.StartPt.Y, b.StartPt.X] = b.Text[0];
            }
        }

        public void Add(char c, System.Drawing.Point p)
        {
            _m[ p.Y, p.X] = c;
        }

        public void Add(System.Drawing.Point p1, System.Drawing.Point p2, char c)
        {
            int xStart = 0;
            int xEnd = 0;
            if (c == '-')
            {
                xStart = p1.X > p2.X ? p2.X : p1.X;
                xEnd = p1.X < p2.X ? p2.X : p1.X;

                for (int i = xStart + 1; i < xEnd; i++ )
                {
                    _m[p1.Y, i] = c;
                }
            }
            else if (c == '|')
            {
                xStart = p1.Y > p2.Y ? p2.Y : p1.Y;
                xEnd = p1.Y < p2.Y ? p2.Y : p1.Y;

                for (int i = xStart +1 ; i < xEnd; i++)
                {
                    _m[i, p1.X] = c;
                }
            }
        }

        public void SetChar(System.Drawing.Point p, char c)
        {
            _m[p.Y, p.X] = c;
        }

        public char GetChar(System.Drawing.Point p)
        {
            return _m[p.Y, p.X];
        }

        public override string ToString()
        {
            System.Text.StringBuilder str =  new StringBuilder("");
            for (int i = 0; i < _size.Width; i++ )
            {
                for (int j = 0; j < _size.Height; j++)
                {
                    str.Append(_m[i, j]);// = str + _m[i, j];
                }
                str.Append( Environment.NewLine);
            }
            return str.ToString();
        }

        public string GetRectangle(System.Drawing.Point p1, System.Drawing.Point p2)
        {
            System.Text.StringBuilder str = new StringBuilder("");

            for (int i = p1.X; i < p2.X; i++)
            {
                for (int j = p1.Y; j < p2.Y; j++)
                {
                    str.Append(_m[i, j]);
                }
                str.Append(Environment.NewLine);
            }
            return str.ToString();
        }

        public System.Drawing.Size GetMaxWidthHeight()
        {
            System.Drawing.Size s = new System.Drawing.Size(0,0);

            for (int i = 0; i < _size.Width; i++)
            {
                for (int j = 0; j < _size.Height; j++)
                {
                    char c = _m[i, j];
                    if (c != ' ' && c != '\n' && c != '\r')
                    {
                        s.Width = s.Width > i ? s.Width : i;
                        s.Height = s.Height > j ? s.Height : j;
                    }
                }
            }
            return s;
        }

        public System.Drawing.Size GetMinWidthHeight()
        {
            System.Drawing.Size s = new System.Drawing.Size(this.Width, this.Height);

            for (int i = _size.Width - 1; i >= 0; i--)
            {
                for (int j = _size.Height - 1; j >= 0 ; j--)
                {
                    char c = _m[i, j];
                    if (c != ' ' && c != '\n' && c != '\r')
                    {
                        s.Width = s.Width < i ? s.Width : i;
                        s.Height = s.Height < j ? s.Height : j;
                    }
                }
            }
            return s;
        }

        public int Width
        {
            get { return _size.Width;}
            set
            {
                _size.Width = value;
            }
        }

        public int Height
        {
            get { return _size.Height; }
            set { _size.Height = value; }
        }
    }
    
}
