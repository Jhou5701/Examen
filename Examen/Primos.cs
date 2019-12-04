using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Primos : Form
    {
        public Primos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            int con = 1;
            a = int.Parse(this.txtingreso.Text);
            primo(a);
            for (int i = a; i <= 5;i++)
            {
                con = i + a;
                i++;
            }
            this.txtresultado.Text = con.ToString();
        }
        public void primo(int num = 0, int divisor=1, int divisores=0)
        {
            do
            {
                if (num % divisor == 0)
                {
                    divisores++;
                }
                divisor++;
            } while (divisor <= num);
            if (divisores == 2)
            {
                MessageBox.Show("El numero es primo");
            }
            else
            {
                MessageBox.Show("El numero no es primo");
            }
            
        }
    }
    }

