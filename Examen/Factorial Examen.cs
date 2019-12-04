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
    public partial class Factorial_Examen : Form
    {
        public Factorial_Examen()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int limite=0;
            double suma = 0;
            limite = int.Parse(this.txtingreso.Text);
            suma = Clases.Examen.sumaFactorial(limite);
            this.txtresultado.Text = suma.ToString();
        }
    }
}
