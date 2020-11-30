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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Dato.ID = Convert.ToInt32(txt_ID.Text);


            if (Dato.ID == 1234557)
            {
                MessageBox.Show("Completado exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSaldo.Text = Convert.ToString(Dato.tarjeta1);
            }
            else if (Dato.ID == 7658973)
            {
                MessageBox.Show("Completado exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSaldo.Text = Convert.ToString(Dato.tarjeta2);
            }
            else if (Dato.ID == 7845783)
            {
                MessageBox.Show("Completado exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSaldo.Text = Convert.ToString(Dato.tarjeta3);
            }
            else
            {
                DialogResult r = MessageBox.Show("Su cuenta es erronea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (r == DialogResult.OK)
                {
                    return;
                }
            }

            Dato.Resultado = Convert.ToInt32(txtSaldo.Text); 
        }

        private void btnSalir_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 Consulta = new Form3();
            Consulta.ShowDialog();
        }
    }
}
