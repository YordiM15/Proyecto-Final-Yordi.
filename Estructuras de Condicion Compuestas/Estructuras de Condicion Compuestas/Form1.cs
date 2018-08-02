using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructuras_de_Condicion_Compuestas
{
    public partial class FrmEstrCondicional : Form
    {
        //Creacion de variables Globales.
        bool flagSimple1 = false;
        bool flagSimple2 = false;
        public FrmEstrCondicional()
        {
            InitializeComponent();
        }

        private void comparacionSimple()
        { 
            //Inicializacion de las variables
            flagSimple1 = false;
            flagSimple2 = false;
            //Creacion e Inicializacion de las variables del metodo
            bool flag1 = false;
            bool flag2 = false;
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            int num3 = int.Parse(txtNum3.Text);
            int num4 = int.Parse(txtNum4.Text);
            //Determino el valor de verdad de la primera comparacion 
            switch (cboOperadores1.SelectedIndex)
            {
                case 0: if (num1 == num2) flag1 = true;
                    break;
                case 1: if (num1 > num2) flag1 = true;
                    break;
                case 2: if (num1 < num2) flag1 = true;
                    break;
                case 3: if (num1 >= num2) flag1 = true;
                    break;
                case 4: if (num1 <= num2) flag1 = true;
                    break;
                case 5: if (num1 != num2) flag1 = true;
                    break;
                default: MessageBox.Show("No hay comparacion");
                    break;            
            }
            // Determino el valor de verdad de la segunda comparacion.
            switch (cboOperadores2.SelectedIndex)
            { 
                case 0:
                    if (num3 == num4) flag2 = true;
                    break;
                case 1:
                    if (num3 > num4) flag2 = true;
                    break;
                case 2:
                    if (num3 < num4) flag2 = true;
                    break;
                case 3:
                    if (num3 >= num4) flag2 = true;
                    break;
                case 4:
                    if (num3 <= num4) flag2 = true;
                    break;
                case 5:
                    if (num3 != num4) flag2 = true;
                    break;
                default: MessageBox.Show("No hay Comparacion");
                    break;


            }
            // Muestro los resultados en los labels lblResult1 y lblResult2
            if (flag1)
            {
                lblResult1.Text = "= VERDADERO";
            }
            else lblResult1.Text = "= FALSO";
            if (flag2)
            {
                lblResult2.Text = "= VERDADERO";
            }
            else lblResult2.Text = "= FALSO";

            //Actualizando las variables globales segun los resultados obtenidos
            flagSimple1 = flag1;
            flagSimple2 = flag2;

        
        }

        private void cboOperadores1_KeyDown(object sender, KeyEventArgs e)
        {
          // Si la tecla ENTER es pulsada...
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            
            }
        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si la tecla seleccionada no es un numero
            // y no es la tecla de retroceso o enter... 
            // no realizar nada (cancelar)...
            if ((e.KeyChar < 48 || e.KeyChar > 57)
                && (e.KeyChar != 8 && e.KeyChar != 13))
            {
                MessageBox.Show("Debe insertar un numero");
                e.Handled = true;

            
            
            }
        }

        private void txtNum1_Leave(object sender, EventArgs e)
        {
            // Si al salir, el campo esta vacio, poner "0" en el...
            // Utilizar sender para que el evento se pueda extender a cualquier TextBox
            if ((sender as TextBox).Text == "")
            {
                (sender as TextBox).Text = "0";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rbCompuesto_CheckedChanged(object sender, EventArgs e)
        {
            //Condicion: 
            //Hago visible el segundo grupo de controles si
            //el RadioBox correspondiente (rbCompuesto) esta seleccionado...
            cboConectivos.Visible = rbCompuesto.Checked;
            lblConectivos.Visible = rbCompuesto.Checked;
            lblResult3.Visible = rbCompuesto.Checked;
            lineResult.Visible = rbCompuesto.Checked;
            // Habilito e Inabilito los botones correspondientes.
            btnComparar.Enabled = !rbCompuesto.Checked;
            btnComparar2.Enabled = rbCompuesto.Checked;

        }

        private void cboOperadores1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblResult1.Text = "=";
            lblResult3.Text = "=";
        }

        private void cboConectivos_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            lblResult3.Text = "=";

        }

        private void cboOperadores2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblResult2.Text = "=";
            lblResult3.Text = "=";
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            comparacionSimple();
        }

        private void btnComparar2_Click(object sender, EventArgs e)
        {
            comparacionSimple();
            switch (cboConectivos.SelectedIndex)
            {
                case 0: if (flagSimple1 && flagSimple2)
                    {
                        lblResult3.Text = "= VERDADERO";
                    }
                    else lblResult3.Text = "= FALSO";
                    break;
                case 1: if (flagSimple1 || flagSimple2)
                    {
                        lblResult3.Text = "= VERDADERO";
                    }
                    else lblResult3.Text = "= FALSO";
                    break;
                case 2: if (flagSimple1 ^ flagSimple2)
                    {
                        lblResult3.Text = "= VERDADERO";
                    }
                    else lblResult3.Text = "= FALSO";
                    break;
                default: MessageBox.Show("No hay Comparacion");
                    break;
            
            
            
            
            
            }
                   
                  
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
