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

//Nota: Traté de hacer el programa con doble ventana y la CheckBox, pero no supe cómo tomar los datos y usarlos para
//poder realizar las operaciones y lo solicitado.

namespace Examen2.NET
{
    public partial class Form1 : Form
    {
        private VentanaDivisas formVentanaDiv;
        private Button btnCalcular;
        private ComboBox cmbDivisas;
        private TextBox txtMonto;
        private Label lblMonto;
        private Label lblDivisas;
        private GroupBox grpConversiones;
        private Label lblMXN;
        private Label lblUSD;
        private Label lblCAD;
        private Label lblEUR;
        private Label lblJPY;
        private Label lblConversiones;
        private TextBox txtMXN;
        private TextBox txtUSD;
        private TextBox txtCAD;
        private TextBox txtEUR;
        private TextBox txtJPY;
        private String montoIngresado;
        private Double dolaresUSD;
        private Double dolaresCAD;
        private Double euros;
        private Double pesos;
        private Double yenes;

        public Form1()
        {
            btnCalcular = new Button();
            cmbDivisas = new ComboBox();
            cmbDivisas.Items.Add("MXN - Peso Mexicano");
            cmbDivisas.Items.Add("USD - Dólar Estadounidense");
            cmbDivisas.Items.Add("CAD - Dólar Canadiense");
            cmbDivisas.Items.Add("EUR - Euro");
            cmbDivisas.Items.Add("JPY - Yen Japonés");

            lblDivisas = new Label();
            lblMonto = new Label();
            txtMonto = new TextBox();
            grpConversiones = new GroupBox();

            lblMXN = new Label();
            lblUSD = new Label();
            lblCAD = new Label();
            lblEUR = new Label();
            lblJPY = new Label();
            lblConversiones = new Label();

            txtMXN = new TextBox();
            txtUSD = new TextBox();
            txtCAD = new TextBox();
            txtEUR = new TextBox();
            txtJPY = new TextBox();

            InitializeComponent();
            InicializarComponentes();
        }

        private void InicializarComponentes()
        {
            //Inicialización de componentes.
            this.Size = new Size(345, 450);
            this.Text = "Conversor de moneda.";
            this.StartPosition = FormStartPosition.CenterScreen;

            btnCalcular.Size = new Size(65, 30);
            btnCalcular.Text = "Calcular";
            btnCalcular.Location = new Point(220, 75);

            lblDivisas.Text = "Divisas";
            lblDivisas.Location = new Point(15, 20);

            lblMonto.Text = "Monto";
            lblMonto.Location = new Point(200, 20);

            cmbDivisas.Location = new Point(15, 45);
            cmbDivisas.SelectedIndex=0;

            txtMonto.Location = new Point(200, 45);

            lblConversiones.Text = "Conversiones";
            lblConversiones.Location = new Point(90, 150);

            //

            lblMXN.Location = new Point(60,185);
            lblUSD.Location = new Point(60,210);
            lblCAD.Location = new Point(60,235);
            lblEUR.Location = new Point(60,260);
            lblJPY.Location = new Point(60,285);
                  
            txtMXN.Location = new Point(160,185);
            txtUSD.Location = new Point(160,210);
            txtCAD.Location = new Point(160,235);
            txtEUR.Location = new Point(160,260);
            txtJPY.Location = new Point(160,285);


            //lbls y txtboxes del grupo de Conversiones.
            lblMXN.Text = "MXN";
            lblUSD.Text = "USD";
            lblCAD.Text = "CAD";
            lblEUR.Text = "EUR";
            lblJPY.Text = "JPY";


            //Agregar a la Ventana.
            this.Controls.Add(btnCalcular);
            this.Controls.Add(txtMonto);
            this.Controls.Add(lblMonto);
            this.Controls.Add(lblDivisas);
            this.Controls.Add(cmbDivisas);

            this.Controls.Add(lblMXN);
            this.Controls.Add(lblUSD);
            this.Controls.Add(lblCAD);
            this.Controls.Add(lblEUR);
            this.Controls.Add(lblJPY);
            this.Controls.Add(txtMXN);
            this.Controls.Add(txtUSD);
            this.Controls.Add(txtCAD);
            this.Controls.Add(txtEUR);
            this.Controls.Add(txtJPY);
            this.Controls.Add(lblConversiones);

            //Eventos
            btnCalcular.Click += new EventHandler(btnCalcular_Click);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //formVentanaDiv = new VentanaDivisas();
            //formVentanaDiv.Show();


            try
            {
                if (cmbDivisas.SelectedItem.ToString() == "MXN - Peso Mexicano")
                {
                    txtMXN.Visible = false;
                    lblMXN.Visible = false;
                    txtUSD.Visible = true;
                    lblUSD.Visible = true;
                    txtCAD.Visible = true;
                    lblCAD.Visible = true;
                    txtEUR.Visible = true;
                    lblEUR.Visible = true;
                    txtJPY.Visible = true;
                    lblJPY.Visible = true;
                    pesos = Convert.ToDouble(txtMonto.Text);
                    txtUSD.Text = ("$ " + pesos * 0.05).ToString();
                    txtCAD.Text = ("$ " + pesos * 0.06).ToString();
                    txtEUR.Text = ("€ " + pesos * 0.04).ToString();
                    txtJPY.Text = ("¥ " + pesos * 5.32).ToString();
                }
                if (cmbDivisas.SelectedItem.ToString() == "USD - Dólar Estadounidense")
                {
                    txtUSD.Visible = false;
                    lblUSD.Visible = false;
                    txtMXN.Visible = true;
                    lblMXN.Visible = true;
                    txtCAD.Visible = true;
                    lblCAD.Visible = true;
                    txtEUR.Visible = true;
                    lblEUR.Visible = true;
                    txtJPY.Visible = true;
                    lblJPY.Visible = true;
                    dolaresUSD = Convert.ToDouble(txtMonto.Text);
                    txtMXN.Text = ("$ " + dolaresUSD * 21.23).ToString();
                    txtCAD.Text = ("$ " + dolaresUSD * 1.28).ToString();
                    txtEUR.Text = ("€ " + dolaresUSD * 0.89).ToString();
                    txtJPY.Text = ("¥ " + dolaresUSD * 113.05).ToString();
                }
                if (cmbDivisas.SelectedItem.ToString() == "CAD - Dólar Canadiense")
                {
                    txtMXN.Visible = true;
                    lblMXN.Visible = true;
                    txtCAD.Visible = false;
                    lblCAD.Visible = false;
                    txtUSD.Visible = true;
                    lblUSD.Visible = true;
                    txtEUR.Visible = true;
                    lblEUR.Visible = true;
                    txtJPY.Visible = true;
                    lblJPY.Visible = true;
                    dolaresCAD = Convert.ToDouble(txtMonto.Text);
                    txtMXN.Text = ("$ " + dolaresCAD * 16.55).ToString();
                    txtUSD.Text = ("$ " + dolaresCAD * 0.78).ToString();
                    txtEUR.Text = ("€ " + dolaresCAD * 0.69).ToString();
                    txtJPY.Text = ("¥ " + dolaresCAD * 88.12).ToString();
                }
                if (cmbDivisas.SelectedItem.ToString() == "EUR - Euro")
                {
                    txtMXN.Visible = true;
                    lblMXN.Visible = true;
                    txtEUR.Visible = false;
                    lblEUR.Visible = false;
                    txtCAD.Visible = true;
                    lblCAD.Visible = true;
                    txtUSD.Visible = true;
                    lblUSD.Visible = true;
                    txtJPY.Visible = true;
                    lblJPY.Visible = true;
                    euros = Convert.ToDouble(txtMonto.Text);
                    txtMXN.Text = ("$ " + dolaresCAD * 23.96).ToString();
                    txtUSD.Text = ("$ " + dolaresCAD * 1.13).ToString();
                    txtCAD.Text = ("$ " + dolaresUSD * 1.45).ToString();
                    txtJPY.Text = ("¥ " + dolaresCAD * 127.56).ToString();
                }
                if (cmbDivisas.SelectedItem.ToString() == "JPY - Yen Japonés")
                {
                    txtMXN.Visible = true;
                    lblMXN.Visible = true;
                    txtEUR.Visible = true;
                    lblEUR.Visible = true;
                    txtCAD.Visible = true;
                    lblCAD.Visible = true;
                    txtUSD.Visible = true;
                    lblUSD.Visible = true;
                    txtJPY.Visible = false;
                    lblJPY.Visible = false;
                    yenes = Convert.ToDouble(txtMonto.Text);
                    txtMXN.Text = ("$ " + dolaresCAD * 0.1878).ToString();
                    txtUSD.Text = ("$ " + dolaresCAD * 0.0088).ToString();
                    txtCAD.Text = ("$ " + dolaresUSD * 0.0113).ToString();
                    txtEUR.Text = ("€ " + dolaresCAD * 0.0078).ToString();
                }
            }
            catch (Exception ex)
            {
                txtMonto.Text = ("Ingresa un monto.");
            }


        }

        
    }
}
