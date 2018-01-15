using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ASampleProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            StreamReader sr = new StreamReader(@".\names.txt");
            while (!sr.EndOfStream)
            {
                this.listBox1.Items.Add(sr.ReadLine());
            }
            sr.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
        }
    }
}
