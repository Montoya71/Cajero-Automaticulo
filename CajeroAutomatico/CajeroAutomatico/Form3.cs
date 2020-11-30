using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CajeroAutomatico
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Cantidad, b50, b100, b200, b500;
            Cantidad = Convert.ToInt32(txtRetiro.Text);
            Dato.MontoRetirado = Cantidad;
            if (Dato.Resultado > Dato.MontoRetirado)
            {
                MessageBox.Show("Completado exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                double Total;
                Total = Dato.Resultado - Cantidad;
                txtSaldoFinal.Text = Convert.ToString(Total);
                //500 pesos
                b500 = Cantidad / 500;
                Cantidad = Cantidad % 500;

                //200 pesos
                b200 = Cantidad / 200;
                Cantidad = Cantidad % 200;

                //100 pesos
                b100 = Cantidad / 100;
                Cantidad = Cantidad % 100;

                //50 pesos
                b50 = Cantidad / 50;
                Cantidad = Cantidad % 50;

                txt500.Text = b500.ToString();
                txt200.Text = b200.ToString();
                txt100.Text = b100.ToString();
                txt50.Text = b50.ToString();

            }else if(Dato.Resultado < Dato.MontoRetirado)
            {
                MessageBox.Show("Usted no cuenta con esa canridad de dinero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter escribir = new StreamWriter(@"C:\Users\emman\Desktop\Tiket.txt");
            try
            {
                escribir.WriteLine("---------Tiket---------");
                escribir.WriteLine("Cuenta: " + Dato.ID);
                escribir.WriteLine("Saldo Inicial: $" + Dato.Resultado);
                escribir.WriteLine("Monto Retirrado: $" + Dato.MontoRetirado);
                escribir.WriteLine("Saldo Final: $" + txtSaldoFinal.Text);
                escribir.WriteLine("-----------------------");
                escribir.WriteLine("\n");
            }
            catch
            {
                MessageBox.Show("Error", "Tiket", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            escribir.Close();
        }
    }
}
