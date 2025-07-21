using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algoritmi_genetici
{
    public partial class Form2 : Form
    {
        int i, n;
        

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string temp = Convert.ToString(Form1.global.interval2, 2);
            n = temp.Length;
            string valoareBinar;
            int a = Form1.global.interval1;
            int b = Form1.global.interval2;
            int c = b - a;
           
            string[] binar = new string[b-a+1];
            for (i=0 ;i<=c;i++)
            {
                valoareBinar = Convert.ToString(a, 2);
                
                while (valoareBinar.Length < n)
                {
                    valoareBinar = "0" + valoareBinar;
                }
                binar[i] = valoareBinar;
                dataGridView1.Rows.Add(a, binar[i]);
                a++;
            }

        }

    }
}
