using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T2PlataformasDeDesarrollo
{
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }
        public void SetTitle(string title)
        {
            this.Text = title;
        }
        public void SetDatos1(string datos)
        {
            datosMedicamento.Text = datos;
        }
        public void SetDireccion(string direccion)
        {
            datosEnvio.Text = direccion;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enviar_Click(object sender, EventArgs e)
        {
            String mensaje = "Pedido enviado";
            MessageBox.Show(mensaje);
        }
    }
}
