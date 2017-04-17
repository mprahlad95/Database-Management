using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace SQL_FrontEnd1
{
    public partial class Form1 : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;

        public void connect1()
        {
            string oradb = "Data Source=ictorcl;User Id=it410;Password=student";
            conn = new OracleConnection(oradb);
            conn.Open();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            connect1();
            string did, name, address;
                did = textBox1.Text;
                name = textBox2.Text;
                address = textBox3.Text;
            comm = new OracleCommand();
            comm.Connection = conn;
            string cmd = "insert into PERSON values('" + did + "','" + name +"','"+ address +"')";
            comm.CommandText=cmd;
            comm.CommandType = CommandType.Text;
            int flag = 0;
            try
            {
                comm.ExecuteNonQuery();
            }
            catch(OracleException oe)
            {
                MessageBox.Show(oe.Message);
                flag = 1;
            }
            if(flag==0)
                MessageBox.Show("Inserted!");
            conn.Close();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            String regno, model;
            int year;
            regno = textBox4.Text;
            model = textBox5.Text;
            year = int.Parse(textBox6.Text);
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            //Refresh the view of Person in dataGridView1
            connect1();
            comm = new OracleCommand();
            comm.CommandText="select * from PERSON";
            comm.CommandType=CommandType.Text;
            ds=new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "PERSON");
            dt = ds.Tables["PERSON"];
            dataGridView1.DataSource = dt;
            conn.Close();
          
        }

   
 
    }
}
