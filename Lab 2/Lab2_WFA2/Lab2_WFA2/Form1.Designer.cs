namespace Lab2_WFA2
{
    partial class StudentForm
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
            this.rno = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.m1box = new System.Windows.Forms.TextBox();
            this.m2box = new System.Windows.Forms.TextBox();
            this.m3box = new System.Windows.Forms.TextBox();
            this.avgbtn = new System.Windows.Forms.Button();
            this.avglbl = new System.Windows.Forms.Label();
            this.grdlbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grdbtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rno
            // 
            this.rno.Location = new System.Drawing.Point(62, 12);
            this.rno.Name = "rno";
            this.rno.Size = new System.Drawing.Size(138, 20);
            this.rno.TabIndex = 0;
            this.rno.TextChanged += new System.EventHandler(this.rno_TextChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(62, 38);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(138, 20);
            this.name.TabIndex = 0;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // m1box
            // 
            this.m1box.Location = new System.Drawing.Point(62, 102);
            this.m1box.Name = "m1box";
            this.m1box.Size = new System.Drawing.Size(138, 20);
            this.m1box.TabIndex = 0;
            this.m1box.TextChanged += new System.EventHandler(this.m1box_TextChanged);
            // 
            // m2box
            // 
            this.m2box.Location = new System.Drawing.Point(62, 128);
            this.m2box.Name = "m2box";
            this.m2box.Size = new System.Drawing.Size(138, 20);
            this.m2box.TabIndex = 0;
            this.m2box.TextChanged += new System.EventHandler(this.m2box_TextChanged);
            // 
            // m3box
            // 
            this.m3box.Location = new System.Drawing.Point(62, 154);
            this.m3box.Name = "m3box";
            this.m3box.Size = new System.Drawing.Size(138, 20);
            this.m3box.TabIndex = 0;
            this.m3box.TextChanged += new System.EventHandler(this.m3box_TextChanged);
            // 
            // avgbtn
            // 
            this.avgbtn.Location = new System.Drawing.Point(206, 12);
            this.avgbtn.Name = "avgbtn";
            this.avgbtn.Size = new System.Drawing.Size(75, 72);
            this.avgbtn.TabIndex = 1;
            this.avgbtn.Text = "Average";
            this.avgbtn.UseVisualStyleBackColor = true;
            this.avgbtn.Click += new System.EventHandler(this.avgbtn_Click);
            // 
            // avglbl
            // 
            this.avglbl.AutoSize = true;
            this.avglbl.Location = new System.Drawing.Point(155, 181);
            this.avglbl.Name = "avglbl";
            this.avglbl.Size = new System.Drawing.Size(25, 13);
            this.avglbl.TabIndex = 2;
            this.avglbl.Text = "------";
            // 
            // grdlbl
            // 
            this.grdlbl.AutoSize = true;
            this.grdlbl.Location = new System.Drawing.Point(155, 198);
            this.grdlbl.Name = "grdlbl";
            this.grdlbl.Size = new System.Drawing.Size(25, 13);
            this.grdlbl.TabIndex = 3;
            this.grdlbl.Text = "------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Reg. No.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Marks #1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Semester";
            // 
            // grdbtn
            // 
            this.grdbtn.Location = new System.Drawing.Point(206, 102);
            this.grdbtn.Name = "grdbtn";
            this.grdbtn.Size = new System.Drawing.Size(75, 72);
            this.grdbtn.TabIndex = 1;
            this.grdbtn.Text = "Grade";
            this.grdbtn.UseVisualStyleBackColor = true;
            this.grdbtn.Click += new System.EventHandler(this.grdbtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(99, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Average:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(99, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Grade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Marks #2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Marks #3";
            // 
            // sem
            // 
            this.sem.Location = new System.Drawing.Point(62, 64);
            this.sem.Name = "sem";
            this.sem.Size = new System.Drawing.Size(138, 20);
            this.sem.TabIndex = 0;
            this.sem.TextChanged += new System.EventHandler(this.sem_TextChanged);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 220);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grdlbl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.avglbl);
            this.Controls.Add(this.grdbtn);
            this.Controls.Add(this.avgbtn);
            this.Controls.Add(this.m3box);
            this.Controls.Add(this.m2box);
            this.Controls.Add(this.m1box);
            this.Controls.Add(this.sem);
            this.Controls.Add(this.name);
            this.Controls.Add(this.rno);
            this.MaximizeBox = false;
            this.Name = "StudentForm";
            this.Text = "Student Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rno;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox m1box;
        private System.Windows.Forms.TextBox m2box;
        private System.Windows.Forms.TextBox m3box;
        private System.Windows.Forms.Button avgbtn;
        private System.Windows.Forms.Label avglbl;
        private System.Windows.Forms.Label grdlbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button grdbtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox sem;

    }
}

