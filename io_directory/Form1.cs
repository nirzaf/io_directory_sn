using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace io_directory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
             System.IO.Directory.CreateDirectory("E:\\tuts\\" + this.dir_textBox1.Text);
            Int32 i;
            for (i = 0; i < 10 ; i++)
            {
               System.IO.Directory.CreateDirectory("E:\\tuts\\"+i.ToString() );
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Boolean r;
            r = System.IO.Directory.Exists("E:\\tuts\\hi");
            if (r == true)
            {
                System.IO.Directory.Delete("E:\\tuts\\hi", true);
                MessageBox.Show("Done!");
            }
            else
            {
                MessageBox.Show("Your folder not found!");
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Boolean r;
            r=System.IO.Directory.Exists("E:\\tuts\\hi");
            if (r == true)
            {
                MessageBox.Show("I found the folder!");
            }
            else
            {
                MessageBox.Show("Your folder not found!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.IO.Directory.Move("C:\\temp\\koala", "C:\\temp\\test\\bad_koala");
        }
    }
}
