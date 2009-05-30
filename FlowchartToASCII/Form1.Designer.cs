namespace FlowchartToASCII
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbForVerTB = new System.Windows.Forms.GroupBox();
            this.gbForHorTB = new System.Windows.Forms.GroupBox();
            this.txtDrawingBoard = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tbHor = new System.Windows.Forms.TrackBar();
            this.tbVer = new System.Windows.Forms.TrackBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button14 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbHor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVer)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Box";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.gbForVerTB);
            this.panel1.Controls.Add(this.gbForHorTB);
            this.panel1.Controls.Add(this.txtDrawingBoard);
            this.panel1.Location = new System.Drawing.Point(132, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 648);
            this.panel1.TabIndex = 6;
            // 
            // gbForVerTB
            // 
            this.gbForVerTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbForVerTB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbForVerTB.Location = new System.Drawing.Point(3, 629);
            this.gbForVerTB.Name = "gbForVerTB";
            this.gbForVerTB.Size = new System.Drawing.Size(508, 2);
            this.gbForVerTB.TabIndex = 16;
            this.gbForVerTB.TabStop = false;
            // 
            // gbForHorTB
            // 
            this.gbForHorTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.gbForHorTB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbForHorTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbForHorTB.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbForHorTB.Location = new System.Drawing.Point(0, 0);
            this.gbForHorTB.Margin = new System.Windows.Forms.Padding(0);
            this.gbForHorTB.Name = "gbForHorTB";
            this.gbForHorTB.Padding = new System.Windows.Forms.Padding(0);
            this.gbForHorTB.Size = new System.Drawing.Size(2, 631);
            this.gbForHorTB.TabIndex = 15;
            this.gbForHorTB.TabStop = false;
            // 
            // txtDrawingBoard
            // 
            this.txtDrawingBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDrawingBoard.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrawingBoard.Location = new System.Drawing.Point(0, 0);
            this.txtDrawingBoard.MaxLength = 0;
            this.txtDrawingBoard.Multiline = true;
            this.txtDrawingBoard.Name = "txtDrawingBoard";
            this.txtDrawingBoard.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDrawingBoard.Size = new System.Drawing.Size(531, 648);
            this.txtDrawingBoard.TabIndex = 0;
            this.txtDrawingBoard.WordWrap = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button2.Location = new System.Drawing.Point(12, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 7;
            this.button2.Text = "Add Point";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(12, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 25);
            this.button3.TabIndex = 8;
            this.button3.Text = "Add Link";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 97);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 48);
            this.button4.TabIndex = 9;
            this.button4.Text = "Select 1st Point";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(12, 151);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 53);
            this.button5.TabIndex = 10;
            this.button5.Text = "Select 2nd Point";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 255);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 28);
            this.button6.TabIndex = 11;
            this.button6.Text = "Add Arrow";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // tbHor
            // 
            this.tbHor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHor.LargeChange = 1;
            this.tbHor.Location = new System.Drawing.Point(121, 679);
            this.tbHor.Maximum = 1000;
            this.tbHor.Name = "tbHor";
            this.tbHor.Size = new System.Drawing.Size(530, 45);
            this.tbHor.TabIndex = 13;
            this.tbHor.ValueChanged += new System.EventHandler(this.tbHor_ValueChanged);
            this.tbHor.Scroll += new System.EventHandler(this.tbHor_Scroll);
            // 
            // tbVer
            // 
            this.tbVer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.tbVer.LargeChange = 1;
            this.tbVer.Location = new System.Drawing.Point(108, 12);
            this.tbVer.Maximum = 10000;
            this.tbVer.Name = "tbVer";
            this.tbVer.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbVer.Size = new System.Drawing.Size(45, 660);
            this.tbVer.TabIndex = 14;
            this.tbVer.Scroll += new System.EventHandler(this.tbVer_Scroll);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 678);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(663, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(663, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 527);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 28);
            this.button7.TabIndex = 15;
            this.button7.Text = "Copy Model";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 459);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 40);
            this.button8.TabIndex = 16;
            this.button8.Text = "Reset Trackers";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(11, 308);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 28);
            this.button9.TabIndex = 17;
            this.button9.Text = "Select Item";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Enabled = false;
            this.button10.Location = new System.Drawing.Point(11, 342);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 28);
            this.button10.TabIndex = 18;
            this.button10.Text = "Move Item";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(12, 561);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 37);
            this.button11.TabIndex = 19;
            this.button11.Text = "Open";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Enabled = false;
            this.button12.Location = new System.Drawing.Point(12, 376);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(72, 25);
            this.button12.TabIndex = 20;
            this.button12.Text = "Paste Item";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(16, 616);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(69, 22);
            this.button13.TabIndex = 21;
            this.button13.Text = "Save";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(11, 407);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(73, 28);
            this.button14.TabIndex = 22;
            this.button14.Text = "Delete";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 700);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbVer);
            this.Controls.Add(this.tbHor);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmMain";
            this.Text = "Flowchart To ASCII";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDoubleClick);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbHor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDrawingBoard;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TrackBar tbHor;
        private System.Windows.Forms.TrackBar tbVer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox gbForHorTB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox gbForVerTB;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button14;

    }
}

