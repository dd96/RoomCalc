namespace RoomCalc
{
    partial class FormMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.CmbSectType = new System.Windows.Forms.ComboBox();
            this.LblSectType = new System.Windows.Forms.Label();
            this.LblInput1 = new System.Windows.Forms.Label();
            this.TxtInput1 = new System.Windows.Forms.TextBox();
            this.LblInput2 = new System.Windows.Forms.Label();
            this.TxtInput2 = new System.Windows.Forms.TextBox();
            this.LblInput3 = new System.Windows.Forms.Label();
            this.TxtInput3 = new System.Windows.Forms.TextBox();
            this.BtnAddSect = new System.Windows.Forms.Button();
            this.LblArea = new System.Windows.Forms.Label();
            this.LblVol = new System.Windows.Forms.Label();
            this.LblPaintReq = new System.Windows.Forms.Label();
            this.LstSect = new System.Windows.Forms.ListBox();
            this.LblHyp = new System.Windows.Forms.Label();
            this.TxtHyp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ChkWall1 = new System.Windows.Forms.CheckBox();
            this.ChkWall2 = new System.Windows.Forms.CheckBox();
            this.ChkWall3 = new System.Windows.Forms.CheckBox();
            this.ChkRec1 = new System.Windows.Forms.CheckBox();
            this.ChkRec2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "New section type:";
            // 
            // CmbSectType
            // 
            this.CmbSectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSectType.FormattingEnabled = true;
            this.CmbSectType.Items.AddRange(new object[] {
            "Rectangle",
            "Triangle",
            "Semi-Circle"});
            this.CmbSectType.Location = new System.Drawing.Point(170, 15);
            this.CmbSectType.Name = "CmbSectType";
            this.CmbSectType.Size = new System.Drawing.Size(121, 21);
            this.CmbSectType.TabIndex = 1;
            this.CmbSectType.SelectedIndexChanged += new System.EventHandler(this.CmbSectType_SelectedIndexChanged);
            // 
            // LblSectType
            // 
            this.LblSectType.AutoSize = true;
            this.LblSectType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSectType.Location = new System.Drawing.Point(297, 16);
            this.LblSectType.Name = "LblSectType";
            this.LblSectType.Size = new System.Drawing.Size(367, 20);
            this.LblSectType.TabIndex = 2;
            this.LblSectType.Text = "This allows you to add a normal rectangular section";
            // 
            // LblInput1
            // 
            this.LblInput1.AutoSize = true;
            this.LblInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInput1.Location = new System.Drawing.Point(30, 105);
            this.LblInput1.Name = "LblInput1";
            this.LblInput1.Size = new System.Drawing.Size(60, 20);
            this.LblInput1.TabIndex = 3;
            this.LblInput1.Text = "Height:";
            // 
            // TxtInput1
            // 
            this.TxtInput1.Location = new System.Drawing.Point(132, 105);
            this.TxtInput1.Name = "TxtInput1";
            this.TxtInput1.Size = new System.Drawing.Size(100, 20);
            this.TxtInput1.TabIndex = 4;
            // 
            // LblInput2
            // 
            this.LblInput2.AutoSize = true;
            this.LblInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInput2.Location = new System.Drawing.Point(274, 105);
            this.LblInput2.Name = "LblInput2";
            this.LblInput2.Size = new System.Drawing.Size(54, 20);
            this.LblInput2.TabIndex = 5;
            this.LblInput2.Text = "Width:";
            // 
            // TxtInput2
            // 
            this.TxtInput2.Location = new System.Drawing.Point(370, 105);
            this.TxtInput2.Name = "TxtInput2";
            this.TxtInput2.Size = new System.Drawing.Size(100, 20);
            this.TxtInput2.TabIndex = 6;
            // 
            // LblInput3
            // 
            this.LblInput3.AutoSize = true;
            this.LblInput3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInput3.Location = new System.Drawing.Point(512, 105);
            this.LblInput3.Name = "LblInput3";
            this.LblInput3.Size = new System.Drawing.Size(63, 20);
            this.LblInput3.TabIndex = 7;
            this.LblInput3.Text = "Length:";
            // 
            // TxtInput3
            // 
            this.TxtInput3.Location = new System.Drawing.Point(617, 105);
            this.TxtInput3.Name = "TxtInput3";
            this.TxtInput3.Size = new System.Drawing.Size(100, 20);
            this.TxtInput3.TabIndex = 8;
            // 
            // BtnAddSect
            // 
            this.BtnAddSect.Location = new System.Drawing.Point(325, 150);
            this.BtnAddSect.Name = "BtnAddSect";
            this.BtnAddSect.Size = new System.Drawing.Size(135, 23);
            this.BtnAddSect.TabIndex = 9;
            this.BtnAddSect.Text = "Add Section";
            this.BtnAddSect.UseVisualStyleBackColor = true;
            this.BtnAddSect.Click += new System.EventHandler(this.BtnAddSect_Click);
            // 
            // LblArea
            // 
            this.LblArea.AutoSize = true;
            this.LblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblArea.Location = new System.Drawing.Point(30, 400);
            this.LblArea.Name = "LblArea";
            this.LblArea.Size = new System.Drawing.Size(85, 20);
            this.LblArea.TabIndex = 15;
            this.LblArea.Text = "Floor area:";
            // 
            // LblVol
            // 
            this.LblVol.AutoSize = true;
            this.LblVol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVol.Location = new System.Drawing.Point(30, 430);
            this.LblVol.Name = "LblVol";
            this.LblVol.Size = new System.Drawing.Size(110, 20);
            this.LblVol.TabIndex = 16;
            this.LblVol.Text = "Room volume:";
            // 
            // LblPaintReq
            // 
            this.LblPaintReq.AutoSize = true;
            this.LblPaintReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPaintReq.Location = new System.Drawing.Point(30, 460);
            this.LblPaintReq.Name = "LblPaintReq";
            this.LblPaintReq.Size = new System.Drawing.Size(172, 20);
            this.LblPaintReq.TabIndex = 17;
            this.LblPaintReq.Text = "Paint required for walls:";
            // 
            // LstSect
            // 
            this.LstSect.FormattingEnabled = true;
            this.LstSect.Location = new System.Drawing.Point(42, 189);
            this.LstSect.Name = "LstSect";
            this.LstSect.Size = new System.Drawing.Size(700, 199);
            this.LstSect.TabIndex = 20;
            // 
            // LblHyp
            // 
            this.LblHyp.AutoSize = true;
            this.LblHyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHyp.Location = new System.Drawing.Point(30, 150);
            this.LblHyp.Name = "LblHyp";
            this.LblHyp.Size = new System.Drawing.Size(99, 20);
            this.LblHyp.TabIndex = 21;
            this.LblHyp.Text = "Hypotenuse:";
            // 
            // TxtHyp
            // 
            this.TxtHyp.Location = new System.Drawing.Point(132, 150);
            this.TxtHyp.Name = "TxtHyp";
            this.TxtHyp.Size = new System.Drawing.Size(100, 20);
            this.TxtHyp.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(689, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tick the checkbox if a section has a wall and untick if it is an open connection " +
    "between 2 sections";
            // 
            // ChkWall1
            // 
            this.ChkWall1.AutoSize = true;
            this.ChkWall1.Location = new System.Drawing.Point(349, 108);
            this.ChkWall1.Name = "ChkWall1";
            this.ChkWall1.Size = new System.Drawing.Size(15, 14);
            this.ChkWall1.TabIndex = 24;
            this.ChkWall1.UseVisualStyleBackColor = true;
            // 
            // ChkWall2
            // 
            this.ChkWall2.AutoSize = true;
            this.ChkWall2.Location = new System.Drawing.Point(596, 108);
            this.ChkWall2.Name = "ChkWall2";
            this.ChkWall2.Size = new System.Drawing.Size(15, 14);
            this.ChkWall2.TabIndex = 25;
            this.ChkWall2.UseVisualStyleBackColor = true;
            // 
            // ChkWall3
            // 
            this.ChkWall3.AutoSize = true;
            this.ChkWall3.Location = new System.Drawing.Point(238, 155);
            this.ChkWall3.Name = "ChkWall3";
            this.ChkWall3.Size = new System.Drawing.Size(15, 14);
            this.ChkWall3.TabIndex = 26;
            this.ChkWall3.UseVisualStyleBackColor = true;
            // 
            // ChkRec1
            // 
            this.ChkRec1.AutoSize = true;
            this.ChkRec1.Location = new System.Drawing.Point(328, 108);
            this.ChkRec1.Name = "ChkRec1";
            this.ChkRec1.Size = new System.Drawing.Size(15, 14);
            this.ChkRec1.TabIndex = 27;
            this.ChkRec1.UseVisualStyleBackColor = true;
            // 
            // ChkRec2
            // 
            this.ChkRec2.AutoSize = true;
            this.ChkRec2.Location = new System.Drawing.Point(575, 108);
            this.ChkRec2.Name = "ChkRec2";
            this.ChkRec2.Size = new System.Drawing.Size(15, 14);
            this.ChkRec2.TabIndex = 28;
            this.ChkRec2.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 512);
            this.Controls.Add(this.ChkRec2);
            this.Controls.Add(this.ChkRec1);
            this.Controls.Add(this.ChkWall3);
            this.Controls.Add(this.ChkWall2);
            this.Controls.Add(this.ChkWall1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtHyp);
            this.Controls.Add(this.LblHyp);
            this.Controls.Add(this.LstSect);
            this.Controls.Add(this.LblPaintReq);
            this.Controls.Add(this.LblVol);
            this.Controls.Add(this.LblArea);
            this.Controls.Add(this.BtnAddSect);
            this.Controls.Add(this.TxtInput3);
            this.Controls.Add(this.LblInput3);
            this.Controls.Add(this.TxtInput2);
            this.Controls.Add(this.LblInput2);
            this.Controls.Add(this.TxtInput1);
            this.Controls.Add(this.LblInput1);
            this.Controls.Add(this.LblSectType);
            this.Controls.Add(this.CmbSectType);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Room";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbSectType;
        private System.Windows.Forms.Label LblSectType;
        private System.Windows.Forms.Label LblInput1;
        private System.Windows.Forms.TextBox TxtInput1;
        private System.Windows.Forms.Label LblInput2;
        private System.Windows.Forms.TextBox TxtInput2;
        private System.Windows.Forms.Label LblInput3;
        private System.Windows.Forms.TextBox TxtInput3;
        private System.Windows.Forms.Button BtnAddSect;
        private System.Windows.Forms.Label LblArea;
        private System.Windows.Forms.Label LblVol;
        private System.Windows.Forms.Label LblPaintReq;
        private System.Windows.Forms.ListBox LstSect;
        private System.Windows.Forms.Label LblHyp;
        private System.Windows.Forms.TextBox TxtHyp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ChkWall1;
        private System.Windows.Forms.CheckBox ChkWall2;
        private System.Windows.Forms.CheckBox ChkWall3;
        private System.Windows.Forms.CheckBox ChkRec1;
        private System.Windows.Forms.CheckBox ChkRec2;
    }
}

