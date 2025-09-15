using Actividad.Models;

namespace Actividad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnListarIncidentes.Enabled = false;
            gbAdministracion.Enabled = false;
            btnCreacionComisaria.Enabled = true;
            gbOperacionSobreAgente.Enabled = false;

        }

        Comisaria comisaria;

        private void btnCreacionComisaria_Click(object sender, EventArgs e)
        {
            comisaria = new Comisaria();

            Policia policia1 = new Policia(40158729, "Facundo", 256);
            Policia policia2 = new Policia(30258985, "Sofía", 145);

            comisaria.AsignarPolicia(policia1);
            comisaria.AsignarPolicia(policia2);

            #region Mostrar nro placa de policias
            cmbPlacaAgente.Items.Clear();
            cmbPlacaAgente.Items.Add(policia1.NumeroPlaca);
            cmbPlacaAgente.Items.Add(policia2.NumeroPlaca);

            btnListarIncidentes.Enabled = true;
            gbAdministracion.Enabled = true;
            btnCreacionComisaria.Enabled = true;
            gbOperacionSobreAgente.Enabled = true;
            #endregion

        }

        private void btnAsignacionGuardias_Click(object sender, EventArgs e)
        {
            if (cmbPlacaAgente.SelectedItem != null)
            {
                int nroPlaca = Convert.ToInt32(cmbPlacaAgente.Text);
                int nroGuardia = Convert.ToInt32(nudNroGuardia.Value);
                int hDesde = Convert.ToInt32(nudHoraDesde.Value);
                int mDesde = Convert.ToInt32(nudMinutoDesde.Value);
                int duracion = Convert.ToInt32(nudDuracionEnM.Value);

                Policia policia = comisaria.VerAgente(nroPlaca);

                comisaria.AsignarGuardia(nroGuardia, hDesde, mDesde, duracion, policia);

                #region Limpio campos
                cmbPlacaAgente.SelectedIndex = -1;
                nudNroGuardia.Value = 0;
                nudHoraDesde.Value = 0;
                nudMinutoDesde.Value = 0;
                nudDuracionEnM.Value = 0;
                tbMotivo.Clear();
                #endregion
            }
            else
            {
                MessageBox.Show("Debes seleccionar la placa del agente...");
            }

        }

        private void btnRegistrarIncidente_Click(object sender, EventArgs e)
        {
            if (cmbPlacaAgente.SelectedItem != null && cmbTipoIncidente.SelectedItem != null)
            {
                int tipoIncidente = cmbTipoIncidente.SelectedIndex;
                int horaIncidente = Convert.ToInt32(nudHoraIncidente.Value);
                int minutoIncidente = Convert.ToInt32(nudMinutoIncidente.Value);
                string motivo = tbMotivo.Text;

                string nombreSujeto = tbNombrePersona.Text;
                int dniSujeto = Convert.ToInt32(tbDNIPersona.Text);
                Persona persona = new Persona(dniSujeto, nombreSujeto);



                int nroPlaca = Convert.ToInt32(cmbPlacaAgente.SelectedItem.ToString());
                Policia policia = comisaria.VerAgente(nroPlaca);


                comisaria.RegistrarIncidente(policia, persona, motivo, horaIncidente, minutoIncidente, tipoIncidente);

                #region Limpio campos
                cmbPlacaAgente.SelectedIndex = -1;
                cmbTipoIncidente.SelectedIndex = -1;
                nudHoraIncidente.Value = 0;
                nudMinutoIncidente.Value = 0;
                tbMotivo.Clear();
                tbNombrePersona.Clear();
                tbDNIPersona.Clear();
                #endregion
            }
            else
            {
                MessageBox.Show("Debes seleccionar la Placa del agente y el Tipo de Incidente!");
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnListarIncidentes_Click(object sender, EventArgs e)
        {
            FVerIncidentes fIncidentes = new FVerIncidentes();

            if (comisaria != null && comisaria.CantidadIncidentes > 0)
            {

                for (int i = 0; i < comisaria.CantidadIncidentes; i++)
                {
                    fIncidentes.tbResultado.Text += $"\r\n--{i + 1}---------------------\r\n";

                    Incidente incidente = comisaria.VerIncidente(i);

                    fIncidentes.tbResultado.Text += incidente.VerDescripcion();
                }

                fIncidentes.tbResultado.Text += $"\r\n-----------------------";
                fIncidentes.ShowDialog();
                fIncidentes.Dispose();
            }
            else
            {
                MessageBox.Show("No se han registrado Incidentes");
            }
        }
    }
}
