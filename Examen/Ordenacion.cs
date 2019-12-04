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
    public partial class Ordenacion : Form
    {
        public Ordenacion()
        {
            InitializeComponent();
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                var seed = Environment.TickCount;
                var random = new Random(seed);

                var value = random.Next(1, 10);
                this.listValores.Items.Add(value);

            }
        }
    }
}

