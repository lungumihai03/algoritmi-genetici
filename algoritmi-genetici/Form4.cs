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
    public partial class Form4 : Form
    {
        private Timer timer;
        public Form4()
        {
            InitializeComponent();


            // Inițializați timerul
            timer = new Timer();
            timer.Interval = 100;

            // Atașăm evenimentul pentru Timer
            timer.Tick += Timer_Tick;
        }
      
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Scădem opacitatea cu o valoare mică
            this.Opacity -= 0.05;

            // Dacă opacitatea a ajuns la 0, oprim Timer-ul
            if (this.Opacity <= 0)
            {
                timer.Stop();
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
