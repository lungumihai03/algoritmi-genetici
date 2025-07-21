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
    public partial class Form5 : Form
    {
        private Timer timer;
        public Form5()
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
            this.Opacity -= 0.05;

            // Dacă opacitatea a ajuns la 0, oprim Timer-ul
            if (this.Opacity <= 0)
                Application.Exit();
    }
    private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
