using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Heli DAniel García Varela.
//4°B Examen 2 de Programación Visual.NET

namespace Examen2.NET
{
    public partial class VentanaDivisas : Form
    {
        private CheckedListBox clbDivisas;
        private Button btnAceptar;
        private Button btnCancelar;

        public VentanaDivisas()
        {
            InitializeComponent();
            InicializarComponentes();
        }

        private void InicializarComponentes()
        {
            this.Size = new Size(220, 190);
            this.Text = "Divisas";
            this.StartPosition = FormStartPosition.CenterScreen;

            clbDivisas = new CheckedListBox();
            clbDivisas.Items.Add("MXN - Peso Mexicano");
            clbDivisas.Items.Add("USD - Dólar Estadounidense.");
            clbDivisas.Items.Add("CAD - Dólar Canadiense.");
            clbDivisas.Items.Add("EUR - Euro.");
            clbDivisas.Items.Add("JPY - Yen Japonés.");
            clbDivisas.Size = new Size(175, 90);
            clbDivisas.Location = new Point(12, 12);

            btnAceptar = new Button();
            btnAceptar.Text = "Aceptar";
            btnAceptar.Size = new Size(60, 25);
            btnAceptar.Location = new Point(115, 105);

            btnCancelar = new Button();
            btnCancelar.Text = "Cancelar";
            btnCancelar.Size = new Size(60, 25);
            btnCancelar.Location = new Point(20, 105);

            this.Controls.Add(clbDivisas);
            this.Controls.Add(btnAceptar);
            this.Controls.Add(btnCancelar);

            btnCancelar.Click += new EventHandler(btnCancelar_Click);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
 
            if (clbDivisas.GetItemChecked(0))
            {
                
            }
            if (clbDivisas.GetItemChecked(1))
            {

            }
            if (clbDivisas.GetItemChecked(2))
            {

            }
            if (clbDivisas.GetItemChecked(3))
            {

            }
            if (clbDivisas.GetItemChecked(4))
            {

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
