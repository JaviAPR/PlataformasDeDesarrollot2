using System.Text.RegularExpressions;

namespace T2PlataformasDeDesarrollo
{
    public partial class Form1 : Form
    {
        Factura facturas;
        public Form1()
        {
            InitializeComponent();
            facturas = new Factura();
        }




        private void confirmar(object sender, EventArgs e)
        {
            if (nombreMedicamento.Text == "")
            {
                errorNombreVacio();
            }
            else if (EsAlfanumerico(nombreMedicamento.Text) == false)
            {
                errorNombre();
            }
            else if (tipoMedicamento.SelectedItem == null)
            {
                errorTipo();
            }
            else if (cantidad.Text == "")
            {
                errorCantiVacia();
            }
            else if (convertirNumero(cantidad.Text) == false)
            {
                errorConvertNumero();
            }
            else if (int.Parse(cantidad.Text) < 0)
            {
                errorCantiNegativa();
            }
            else if (principal.Checked == false && secundaria.Checked == false)
            {
                errorSucursal();
            }
            else if (cemefar.Checked == false && cofarma.Checked == false && empsephar.Checked == false)
            {
                errorDistribuidor();
            }
            else
            {
                if (cemefar.Checked == true)
                {
                    facturas.SetTitle("Pedido al distribuidor "+ cemefar.Text);
                }
                else if(cofarma.Checked == true)
                {
                    facturas.SetTitle("Pedido al distribuidor " + cofarma.Text);
                }
                else if(empsephar.Checked == true)
                {
                    facturas.SetTitle("Pedido al distribuidor " + empsephar.Text);
                }
                
                facturas.SetDatos1(cantidad.Text + "unidades del " + tipoMedicamento.Text +" "+ nombreMedicamento.Text);

                if (principal.Checked == true && secundaria.Checked == true)
                {
                    facturas.SetDireccion("Para las dos farmacias \nla farmacia situada en Calle de la Rosa n. 28.\ny la farmacia situada en Calle Alcazabilla n. 3.");
                }
                else if (principal.Checked == true)
                {
                    facturas.SetDireccion("Para la farmacia situada en Calle de la Rosa n. 28.");
                }
                else if(secundaria.Checked == true)
                {
                    facturas.SetDireccion("Para la farmacia situada en Calle Alcazabilla n. 3.");
                }
                
                
                facturas.ShowDialog();
            }
        }

        private void borrar(object sender, EventArgs e)
        {
            cemefar.Checked = false;
            cofarma.Checked = false;
            empsephar.Checked = false;
            secundaria.Checked = false;
            principal.Checked = false;
            nombreMedicamento.ResetText();
            cantidad.ResetText();
            tipoMedicamento.ResetText();
            tipoMedicamento.SelectedItem = null;
        }


        static bool EsAlfanumerico(string input)
        {
            Regex regex = new Regex("^[a-zA-Z0-9]*$"); 
            return regex.IsMatch(input);
        }
        static bool convertirNumero(String numero)
        {
            int canti;
            return int.TryParse(numero, out canti);
        }



        public void errorNombreVacio()
        {
            string text = "Error! \n el nombre no puede estar vacio";
            MessageBox.Show(text);
        }
        public void errorNombre()
        {
            string text = "Error! \n el nombre no puede tener caracteres especiales";
            MessageBox.Show(text);
        }
        public void errorTipo()
        {
            string text = "Error! \n Debe seleccionar un tipo de Medicamento";
            MessageBox.Show(text);
        }
        public void errorCantiVacia()
        {
            string text = "Error! \n Debe ingresar la cantidad de medicamento";
            MessageBox.Show(text);
        }
        public void errorConvertNumero()
        {
            string text = "Error! \n La cantidad debe ser numerica";
            MessageBox.Show(text);
        }
        public void errorCantiNegativa()
        {
            string text = "Error! \n La cantidad debe ser mayor a 0";
            MessageBox.Show(text);
        }
        public void errorSucursal()
        {
            string text = "Error! \n Debe seleccionar una sucursal para el pedido";
            MessageBox.Show(text);
        }
        public void errorDistribuidor()
        {
            string text = "Error! \n Debe seleccionar un distribuidor para el pedido";
            MessageBox.Show(text);
        }





        
    }
}
