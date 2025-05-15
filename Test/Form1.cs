namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(this.txtMonitorFilesLocation.Text))
                {
                    MessageBox.Show("Ingresa la ubicación de los archivos a monitorear", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrWhiteSpace(this.txtInstallationFolder.Text))
                {
                    MessageBox.Show("Ingresa la ubicación de los archivos de instalación", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrWhiteSpace(this.txtVersion.Text))
                {
                    MessageBox.Show("Ingresa el numero de versión", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MonitorUpdaterManagerSample.UpdateMonitor(this.txtMonitorFilesLocation.Text, this.txtInstallationFolder.Text, this.txtVersion.Text);

                    this.txtMonitorFilesLocation.Text = string.Empty;
                    this.txtInstallationFolder.Text = string.Empty;
                    this.txtVersion.Text = string.Empty;

                    MessageBox.Show("Proceso ejecutado correctamente", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al intentar ejecutar la solicitud, informe al administrador. Error: " + ex.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}