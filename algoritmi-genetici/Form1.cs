using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace algoritmi_genetici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void T3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '0' && e.KeyChar != '1' && !char.IsControl(e.KeyChar) && e.KeyChar != '2' && e.KeyChar != '3' && e.KeyChar != '4' && e.KeyChar != '5' && e.KeyChar != '6' && e.KeyChar != '7' && e.KeyChar != '8' && e.KeyChar != '9')
            {
                e.Handled = true;
            }
        }
        public static class global
        {
            public static int interval1, interval2, func=0, p, c, number;
            public static string  token;
            public static int a, b, c1, d, e, info=0;
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            textA.TabIndex = 0;

            textBox1.Visible = false;
            textBox4.Visible = false;
            textBox2.Visible = true;
            textBox3.Visible = true;
            label5.Visible = false;
            label3.Visible = true;
            textA.Text = "";
            textB.Text = "";
            textC.Text = " ";
            textD.Text = " ";
            textE.Text = " ";
            
            if (radioButton3.Checked)
            {
                textA.TabIndex = 0;
                global.a = 1;
                global.b = 0;
                putere1.Visible = false;
                putere2.Visible = false;
                putere3.Visible = false;
                putere4.Visible = false;
                x1.Visible = false;
                x2.Visible = false;
                x3.Visible = false;
                s1.Visible = false;
                s2.Visible = false;
                s3.Visible = false;
                textC.Visible = false;
                textD.Visible = false;
                textE.Visible = false;
                global.info = 1;
            }
            if (radioButton4.Checked)
            {
                textA.TabIndex = 0;
                global.a = 1;
                global.b = 1;
                global.c1 = 0;
                global.info = 2;
                putere1.Visible = true;
                putere1.Text = "2";
                putere2.Visible = false;
                putere3.Visible = false;
                putere4.Visible = false;
                x1.Visible = true;
                x2.Visible = false;
                x3.Visible = false;
                s1.Visible = true;
                s2.Visible = false;
                s3.Visible = false;
                textC.Visible = true;
                textD.Visible = false;
                textE.Visible = false;
                textC.Text = "";
                textD.Text = " ";
                textE.Text = " ";
            }
            if (radioButton5.Checked)
            {
                textA.TabIndex = 0;
                global.a = 1;
                global.b = 1;
                global.c1 = 1;
                global.d = 0;
                global.info = 3;
                putere1.Visible = true;
                putere1.Text = "3";
                putere2.Visible = true;
                putere3.Visible = false;
                putere4.Visible = false;
                x1.Visible = true;
                x2.Visible = true;
                x3.Visible = false;
                s1.Visible = true;
                s2.Visible = true;
                s3.Visible = false;
                textC.Visible = true;
                textD.Visible = true;
                textE.Visible = false;
                textC.Text = "";
                textD.Text = "";
                textE.Text = " ";
            }
            if (radioButton6.Checked)
            {
                textA.TabIndex = 0;
                global.a = 1;
                global.b = 1;
                global.c1 = 1;
                global.d = 1;
                global.e = 0;
                global.info = 4;
                putere1.Visible = true;
                putere1.Text = "4";
                putere2.Visible = true;
                putere2.Text = "3";
                putere3.Visible = true;
                putere4.Visible = false;
                x1.Visible = true;
                x2.Visible = true;
                x3.Visible = true;
                s1.Visible = true;
                s2.Visible = true;
                s3.Visible = true;
                textC.Visible = true;
                textD.Visible = true;
                textE.Visible = true;
                textC.Text = "";
                textD.Text = "";
                textE.Text = "";
            }
            global.func = 1;
            global.func = 1;
            

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            
        }
        

        private async void button1_Click(object sender, EventArgs e)
        {
            
           
           if(textA.Text =="" || textB.Text == "" || textC.Text == "" || textD.Text == "" || textE.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Nu ați introdus nimic!!!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }
           else {
                
                global.a = int.Parse(textA.Text);
                global.b = int.Parse(textB.Text);
                if(global.info == 2)
                    global.c1 = int.Parse(textC.Text);
                if(global.info == 3)
                {
                        global.c1 = int.Parse(textC.Text);
                        global.d = int.Parse(textD.Text);
                }
               
                if(global.info == 4)
                {
                    global.c1 = int.Parse(textC.Text);
                    global.d = int.Parse(textD.Text);
                    global.e = int.Parse(textE.Text);
                }
                
                global.interval1 = int.Parse(textBox2.Text);
                global.interval2 = int.Parse(textBox3.Text);
                Form2 form2 = new Form2();
                Form3 form3 = new Form3();
                form2.Show();
                form3.Show();
            }
        }

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox4.Visible = false;
            textBox2.Visible = true;
            textBox3.Visible = true;
            label5.Visible = false;
            label3.Visible = true;
            global.func = 1;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
