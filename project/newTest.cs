using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Xml;
using System.Text.Json.Serialization;
using System.IO;

namespace project
{
    public partial class newTest : Form
    {
        public newTest()
        {
            InitializeComponent();

        }

        private void startToWriteTest_Click_1(object sender, EventArgs e)
        {
            if (TestName.Text != "")
            {

                try
                {
                    TestDetails test = new TestDetails(TestName.Text);
                    this.Hide();
                    Questions q = new Questions();
                    q.Test = test;
                    // q.OnAddQuestion += Add;
                    q.Show();
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
            else
            {
                MessageBox.Show("enter id or name not valid ");
            }

        }

        //private void returnHomePage_Click_1(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    Form1 f = new Form1();
        //    f.Show();
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();

        }
    }


}
