using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab2_WFA2
{
    public partial class StudentForm : Form
    {
        string input = string.Empty;
        string nm = string.Empty;
        string reg  = string.Empty;
        int sm     = 0;
        float m1, m2, m3;
        float avg;
        string grd;

        public StudentForm()
        {
            InitializeComponent();
        }

        private void rno_TextChanged(object sender, EventArgs e)
        {
            reg = this.rno.Text;
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            nm = this.name.Text;
        }

        private void sem_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(this.sem.Text, out sm);
        }

        private void m1box_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(this.m1box.Text, out m1);
        }

        private void m2box_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(this.m2box.Text, out m2);
        }

        private void m3box_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(this.m3box.Text, out m3);
        }

        private void avgbtn_Click(object sender, EventArgs e)
        {
            float tot = m1 + m2 + m3;
            avg = tot/3;
            avglbl.Text = avg.ToString();
        }

        private void grdbtn_Click(object sender, EventArgs e)
        {
            if (avg >= 90) grd = "A+";
            else if (avg >= 80) grd = "A";
            else if (avg >= 70) grd = "B";
            else if (avg >= 60) grd = "C";
            else if (avg >= 50) grd = "D";
            else if (avg >= 40) grd = "E";
            else grd = "F";
            grdlbl.Text = grd;
        }

        
    }
}
