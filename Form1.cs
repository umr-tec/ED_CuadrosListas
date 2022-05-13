using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED_Ejemplo4_Cuadros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dibujarPanel1.DoubleBuffered = !dibujarPanel1.DoubleBuffered;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dibujarPanel1.Width = (70 * 100) / ClientSize.Width;
        }
    }
}
