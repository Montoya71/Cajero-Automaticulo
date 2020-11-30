using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Consulta = new Form2();
            Consulta.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Seguro que desa salir?", "Abandonar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (r == DialogResult.Cancel)
            {
                return;
            }
            else if (r == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
