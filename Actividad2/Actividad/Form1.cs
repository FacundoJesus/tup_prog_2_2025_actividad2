using Actividad.Models;

namespace Actividad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreacionComisaria_Click(object sender, EventArgs e)
        {
            Comisaria comisaria = new Comisaria();
        }

        private void btnRegistrarIncidente_Click(object sender, EventArgs e)
        {

        }
    }
}
