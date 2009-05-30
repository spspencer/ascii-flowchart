using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.IO;

namespace FlowchartToASCII
{
    public partial class frmMain : Form
    {
        private Matrix m = new Matrix(new Size(1024, 1024));
        //private Matrix m = new Matrix(new Size(1000, 1000));
        private char pointsymblol = 'o';
        private System.Drawing.Point? Selected1stPoint;
        private System.Drawing.Point? Selected2ndPoint;
        private Model model = new Model();
        private BaseType SelectedBox;
        private string filename = "";


        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string str;
            BoxInput frmInput = new BoxInput();
            frmInput.ShowDialog();
            str = frmInput.Text;
            frmInput.Close();

            //Box b = new Box(str);
            BoxType b = new BoxType(GetLineAndPos(), str);
            //string s1  = b.Draw();
            //m.Add(b, GetLineAndPos());
            m.Add(b);
            txtDrawingBoard.Text = m.ToString();
            model.Add(b);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PointType p = new PointType(GetLineAndPos(), pointsymblol.ToString());
            m.Add(p);
            /*m.Add(pointsymblol, GetLineAndPos());*/
            txtDrawingBoard.Text = m.ToString();
            model.Add(p);
        }


        private Point GetLineAndPos()
        {
            int pos = txtDrawingBoard.SelectionStart;
            int line = pos /m.Width;
            pos = pos - (line *(m.Width + 2));
            return new Point(pos, line);

       }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string str = m.ToString();
            txtDrawingBoard.Text = str;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PenCaps_Paint);
            //gbForHorTB.Location = tbVer.Location;
            //gbForHorTB.Size = new Size(gbForHorTB.Size.Width, tbVer.Size.Height);
        }

        private void AddLink()
        {
           
            if (CheckHorizontal())
            {
                LinkType l = new LinkType(new Point(Selected1stPoint.Value.X, Selected1stPoint.Value.Y), new Point(Selected2ndPoint.Value.X, Selected2ndPoint.Value.Y), '-');
                //m.Add(new Point(Selected1stPoint.Value.X, Selected1stPoint.Value.Y), new Point(Selected2ndPoint.Value.X,Selected2ndPoint.Value.Y), '-');
                m.Add(l);
                txtDrawingBoard.Text = m.ToString();
                model.Add(l);
            }
            else if (CheckVertical())
            {
                LinkType l = new LinkType(new Point(Selected1stPoint.Value.X, Selected1stPoint.Value.Y), new Point(Selected2ndPoint.Value.X, Selected2ndPoint.Value.Y), '|');
                m.Add(l);
                //m.Add(new Point(Selected1stPoint.Value.X, Selected1stPoint.Value.Y), new Point(Selected2ndPoint.Value.X, Selected2ndPoint.Value.Y), '|');
                txtDrawingBoard.Text = m.ToString();
                model.Add(l);
            }
        }

        public bool CheckHorizontal()
        {
            return Selected1stPoint.Value.Y == Selected2ndPoint.Value.Y ? true : false;
        }

        public bool CheckVertical()
        {
            return Selected1stPoint.Value.X == Selected2ndPoint.Value.X ? true : false;
        }


        public void AddArrow()
        {
            char c = '\0';
            Point p = GetLineAndPos();


            if (CheckUp(p))
            {
                //m.SetChar(p, '^');
                c = '^';
            }
            else if (CheckDown(p))
            {
                //m.SetChar(p, 'v');
                c = 'v';
            }
            else if (CheckRight(p))
            {
                //m.SetChar(new Point(p.X - 1, p.Y), '>');
                p.X = p.X - 1;
                c = '>';
            }
            else if (CheckRightAdj(p))
            {
                //m.SetChar(p, '>');
                c = '>';
            }
            else if (CheckLeft(p))
            {
                //m.SetChar(p, '<');
                c = '<';
            }
            if (c != '\0')
            {
                ArrowType A = new ArrowType(p, c.ToString());
                m.Add(A);
                txtDrawingBoard.Text = m.ToString();
                model.Add(A);

            }
        }

        public bool CheckUp(Point p)
        {
            Point pTest = new Point(p.X, p.Y - 1);
            return m.GetChar(pTest) == pointsymblol ? true : false;
        }

        public bool CheckDown(Point p)
        {
            Point pTest = new Point(p.X, p.Y + 1);
            return m.GetChar(pTest) == pointsymblol ? true : false;
        }

        public bool CheckRight(Point p)
        {
            Point pTest = new Point(p.X , p.Y);
            return m.GetChar(pTest) == pointsymblol ? true : false;
        }
        public bool CheckRightAdj(Point p)
        {
            Point pTest = new Point(p.X + 1, p.Y);
            return m.GetChar(pTest) == pointsymblol ? true : false;
        }

        public bool CheckLeft(Point p)
        {
            Point pTest = new Point(p.X - 1, p.Y);
            return m.GetChar(pTest) == pointsymblol ? true : false;
        }

        private void PenCaps_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
/*
            Pen myPen = new Pen(Color.Gray, 10);
            int y = 20;

            Point p = tbHor.Location;
            int width = tbHor.Size.Width;
            int width2 = tbHor.ClientSize.Width;


            myPen.StartCap = LineCap.Flat;
            myPen.EndCap = LineCap.Flat;
            myPen.Width = 10;
            //e.Graphics.
            e.Graphics.DrawLine(myPen, p, new Point (p.X, tbVer.Location.Y));
 */

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Selected1stPoint.HasValue && Selected2ndPoint.HasValue)
            {
                AddLink();
                Selected1stPoint = null;
                Selected2ndPoint = null;
                button3.Enabled = false;
                button5.Enabled = false;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtDrawingBoard.SelectedText == pointsymblol.ToString())
            {
                Selected1stPoint = GetLineAndPos();
                button5.Enabled = true;
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtDrawingBoard.SelectedText == pointsymblol.ToString())
            {
                Selected2ndPoint = GetLineAndPos();
                button3.Enabled = true;
            }
        }

        public bool CopyToClipboard()
        {
            Size smax = m.GetMaxWidthHeight();
            Size smin = m.GetMinWidthHeight();
            string str = m.GetRectangle(new Point(smin.Width,smin.Height), new Point(smax.Width + 2, smax.Height + 2));
            Clipboard.Clear();
            Clipboard.SetText(str);
            return true;
        }

        public void ResetTrackers()
        {
            tbVer.Value = 0;
            tbHor.Value = 0;
            UpdateHorizontalFooter();
            UpdateVerticalFooter();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddArrow();
            txtDrawingBoard.Text = m.ToString();
        }
        public void UpdateVerticalFooter()
        {
            int h = txtDrawingBoard.Height - System.Windows.Forms.SystemInformation.HorizontalScrollBarHeight;
            int ymax = txtDrawingBoard.Location.Y + h; 
            int y = tbVer.Value;
            double d = h * y / tbVer.Maximum;
            //gbForVerTB.Location = new Point(gbForVerTB.Location.X, 371 - System.Convert.ToInt16(d));
            gbForVerTB.Location = new Point(gbForVerTB.Location.X, ymax - System.Convert.ToInt16(d));
        }

        public void UpdateHorizontalFooter()
        {
            int w = txtDrawingBoard.Width - System.Windows.Forms.SystemInformation.VerticalScrollBarWidth;
            int x = tbHor.Value;
            double d = w * x / tbHor.Maximum;
            gbForHorTB.Location = new Point(System.Convert.ToInt16(d), gbForHorTB.Location.Y);
        }

        private void tbHor_Scroll(object sender, EventArgs e)
        {
            UpdateHorizontalFooter();
        }

        private void tbHor_ValueChanged(object sender, EventArgs e)
        {
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            UpdateHorizontalFooter();
            UpdateVerticalFooter();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bool x =CopyToClipboard();
        }

        private void tbVer_Scroll(object sender, EventArgs e)
        {
            UpdateVerticalFooter();
        }

        private void frmMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            ResetTrackers();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            model.Remove(SelectedBox);
            SelectedBox.StartPt = GetLineAndPos();
            model.Add(SelectedBox);
            m.Reset();
            foreach (BaseType b in model.GetList)
            {
                m.Add(b);
            }
            txtDrawingBoard.Text = m.ToString();
            button12.Enabled = false;
            button10.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)  // detect and select Box
        {
            bool status = false;
            foreach (BaseType b in model.GetList)
            {
                status = b.Detect(GetLineAndPos());
                if (status)
                {
                    SelectedBox = b;
                    button10.Enabled = true;
                    button12.Enabled = true;
                    button14.Enabled = true;
                    break;
                }
            }
        }

        private void Save()
        {
            if (filename == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    filename = saveFileDialog1.FileName;
            }
            if (filename != "")
            {
                //Type t = typeof(Model);
                BinaryFormatter bf = new BinaryFormatter();
                //XmlSerializer xmls = new XmlSerializer(typeof(Model));
                Stream sw = new FileStream(filename, FileMode.Create, FileAccess.Write);
                bf.Serialize(sw, model);
                //xmls.Serialize(sw, model);
                sw.Close();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void Open()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter bf = new BinaryFormatter();
                Stream sr = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                Model m1 = (Model)bf.Deserialize(sr);
                m.Reset();

                foreach (BaseType bo in m1.GetList)
                {
                    m.Add(bo);
                    model.Add(bo);
                }

                txtDrawingBoard.Text = m.ToString();

                sr.Close();
                filename = openFileDialog1.FileName;
                this.Text = "ASCII Flowchart: " + filename;
            }
            button12.Enabled = false;
            button10.Enabled = false;
            button14.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Open();
        }
        

        private void button12_Click(object sender, EventArgs e)
        {
            if (SelectedBox.type == CompType.box)
            {
                //model.Remove(SelectedBox);
                BoxType bt = new BoxType();
                bt.StartPt = GetLineAndPos();
                bt.Text = SelectedBox.Text;
                model.Add(bt);
                m.Reset();
                foreach (BaseType b in model.GetList)
                {
                    m.Add(b);
                }
                /*m.Add(bt);*/
                txtDrawingBoard.Text = m.ToString();
                button12.Enabled = false;
                button10.Enabled = false;
                button14.Enabled = false;
            }
            else
            {
                LinkType l = new LinkType();
                l.Text = SelectedBox.Text;
                l.StartPt = GetLineAndPos();
                model.Add(l);
                m.Add(l);
                txtDrawingBoard.Text = m.ToString();
                button12.Enabled = false;
                button10.Enabled = false;
                button14.Enabled = false;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            model.Remove(SelectedBox);
            m.Reset();
            foreach (BaseType b in model.GetList)
            {
                m.Add(b);
            }
            txtDrawingBoard.Text = m.ToString();
            button12.Enabled = false;
            button10.Enabled = false;
            button14.Enabled = false;
        }

    }
}
