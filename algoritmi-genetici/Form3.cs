using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;
using OpenAI_API;
using OpenAI_API.Chat;
using System.Text.RegularExpressions;

namespace algoritmi_genetici
{
    public partial class Form3 : Form
    {
        
        double valoareNumerica;
        string response;
        int a = Form1.global.a;
        int b = Form1.global.b;
        int c = Form1.global.c1;
        int d = Form1.global.d;
        int e = Form1.global.e;
        int intervalStart = Form1.global.interval1; // Valoarea de start a intervalului
        int intervalEnd = Form1.global.interval2;   // Valoarea de sfârșit a intervalului
        public Form3()
        {
            InitializeComponent();
        }

        public static class forma
        {
            public static int test=0;
           
        }
        private async void Form3_Load(object sender, EventArgs e)
        {

            int alfa = 0;

            int[] rezultate = new int[(int)(intervalEnd - intervalStart) + 1];
            double[] probabili = new double[(int)(intervalEnd - intervalStart) + 1];
            double[] procente = new double[(int)(intervalEnd - intervalStart) + 1];
            double[] nr_astept = new double[(int)(intervalEnd - intervalStart) + 1];
            double[] suma = new double[4];
            double[] max = new double[4];
            double[] media = new double[4];
           
            if (Form1.global.info == 1)
            {
                for (int i = intervalStart; i <= intervalEnd; i++)
                {

                    rezultate[i] = Form1.global.a * i + Form1.global.b;
                    suma[0] += rezultate[i];
                }   
               
            }
            else
            {
                if (Form1.global.info == 2)
                {
                    for (int i = intervalStart; i <= intervalEnd; i++)
                    {

                        rezultate[i] = Form1.global.a * i * i + Form1.global.b * i + Form1.global.c1;
                        suma[0] += rezultate[i];
                    }
                }
                else
                {
                    if (Form1.global.info == 3)
                    {
                        for (int i = intervalStart; i <= intervalEnd; i++)
                        {

                            rezultate[i] = Form1.global.a * i * i * i + Form1.global.b * i * i + Form1.global.c1 * i + Form1.global.d;
                            suma[0] += rezultate[i];
                        }
                    }
                    else
                    {
                        if (Form1.global.info == 4)
                        {
                            for (int i = intervalStart; i <= intervalEnd; i++)
                            {

                                rezultate[i] = Form1.global.a * i * i * i * i + Form1.global.b * i * i * i + Form1.global.c1 * i * i + Form1.global.d * i + Form1.global.e;
                                suma[0] += rezultate[i];
                            }
                        }
                    }   
                }
               
            }
                
            media[0] = suma[0] / rezultate.Length;
            
            for (int i = intervalStart; i <= intervalEnd; i++)
            {
                if (max[0] < rezultate[i])
                {
                    max[0] = rezultate[i];
                }

            }
            for (int i = intervalStart; i <= intervalEnd; i++)
            {
                probabili[i] = rezultate[i] / suma[0];
                procente[i] = probabili[i] * 100;
                nr_astept[i] = rezultate[i] / media[0];
                suma[1] += probabili[i];
                suma[2] += procente[i];
                suma[3] += nr_astept[i];
                

            }
            media[1] = suma[1] / probabili.Length;
            media[2] = suma[2] / procente.Length;
            media[3] = suma[3] / nr_astept.Length;
            for (int i = intervalStart; i <= intervalEnd; i++)
            {
                if (max[1] < probabili[i])
                {
                    max[1] = probabili[i];
                }
                if (max[2] < procente[i])
                {
                    max[2] = procente[i];
                }
                if (max[3] < nr_astept[i])
                {
                    max[3] = nr_astept[i];
                }
            }

                string temp = Convert.ToString(Form1.global.interval2, 2);
            int n = temp.Length;
            string valoareBinar;
            int a = Form1.global.interval1;
            int b = Form1.global.interval2;
            string[] binar = new string[b - a + 1];
            for (int i = intervalStart; i <= intervalEnd;i++) 
            {
                valoareBinar = Convert.ToString(i, 2);
                while (valoareBinar.Length < n)
                {
                    valoareBinar = "0" + valoareBinar;
                }
                binar[i] = valoareBinar;
                dataGridView1.Rows.Add(i+1,binar[i],i, rezultate[i], probabili[i], procente[i], nr_astept[i]);
            }
            string[] nume = new string[4];
            nume[0] = "Functia Fitness";
            nume[1] = "Probabilitatea de selectie";
            nume[2] = "Procente";
            nume[3] = "Numar asteptat";
            for (int i =0; i<=3; i++)
            {
                dataGridView2.Rows.Add(nume[i], suma[i], media[i], max[i]);
            }

        }
    }
}
