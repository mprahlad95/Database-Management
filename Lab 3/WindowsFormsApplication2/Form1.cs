using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Student : Form
    {
        string name;
        string regno;
        int sem;
        string branch;
        string gender;
        int i = 0;   //for the progress bar.. the value increments whenever values are entered
        int flag = 0;
        string courses = "\n";
        
        
        public Student()
        {
            InitializeComponent();
            
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            
        }
        
        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Name Changed.";
            name = this.nameBox.Text;            
        }

        private void regBox_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Registration Number Changed.";
            regno = this.regBox.Text;            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Semester Selected.";
            int.TryParse(this.comboBox1.Text, out sem);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Branch Selected.";
            branch = this.comboBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (i = 0; i <= 100; i++)          //for the progress bar
            {
                progressBar1.Value = i;
                System.Threading.Thread.Sleep(2);
            }

            if (nameBox.Text == "") MessageBox.Show("Enter Name!");
            else if (regBox.Text == "") MessageBox.Show("Enter Reg. Number!");
            else if (comboBox1.Text == "") MessageBox.Show("Select Semester!");
            else if (comboBox2.Text == "") MessageBox.Show("Select Branch!");
            else if (flag<3) MessageBox.Show("Select at least 3 Courses");
            else if (radioButton1.Checked == false && radioButton2.Checked == false) MessageBox.Show("Select Gender!");

            else MessageBox.Show("Name:\t\t" + name
                             + "\nReg. Number:\t" + regno
                             + "\nSemester:\t\t" + sem
                             + "\nBranch:\t\t" + branch
                             + "\nGender:\t\t"+gender
                             + "\nCourses:\t\t"+courses);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(this.radioButton1.Checked)
                gender="Male";
            else if(this.radioButton2.Checked)
                gender="Female";
            toolStripStatusLabel1.Text = "Gender Selected.";

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                courses += "\tDBS\n";
                flag++;
                toolStripStatusLabel1.Text = "DBS Checked.";
            }
            else
            {
                courses.Replace("\tDBS\n", "");
                flag--;
                toolStripStatusLabel1.Text = "DBS Unchecked.";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                courses += "\tSE\n";
                flag++;
                toolStripStatusLabel1.Text = "SE Checked.";
            }
            else
            {
                courses.Replace("\tSE\n", "");
                flag--;
                toolStripStatusLabel1.Text = "SE Unchecked.";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                courses += "\tMATH\n";
                flag++;
                toolStripStatusLabel1.Text = "MATH Checked.";
            }
            else
            {
                courses.Replace("\tMATH\n", "");
                flag--;
                toolStripStatusLabel1.Text = "MATH Unchecked.";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                courses += "\tPDC\n";
                flag++;
                toolStripStatusLabel1.Text = "PDC Checked.";
            }
            else
            {
                courses.Replace("\tPDC\n", "");
                flag--;
                toolStripStatusLabel1.Text = "PDC Unchecked.";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                courses += "\tCOMP\n";
                flag++;
                toolStripStatusLabel1.Text = "COMP Checked.";
            }
            else
            {
                courses.Replace("\tCOMP\n", "");
                flag--;
                toolStripStatusLabel1.Text = "COMP Unchecked.";
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                courses += "\tOE\n";
                flag++;
                toolStripStatusLabel1.Text = "OE Checked.";
            }
            else
            {
                courses.Replace("\tOE\n", "");
                flag--;
                toolStripStatusLabel1.Text = "OE Unchecked.";
            }
        }


                      
    }
}
