namespace Ejercicio_13_Tema_2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void BotonNomina_Click(object sender, EventArgs e)
        {
            const double RETENCION = 0.18;
            double NumHoras;
            double NumHorasExtra;
            double PagaPorHora;
            double PagaHorasNormales;
            double PagaHorasExtra;
            double PagaMensualBruto;
            double ResultadoRetencion;
            //!? RMB2324 Cambiado nombre variables
            double PagaMensualNetoRMB2324;
            double PorcentajeRetencionRMB2324;

            try
            {
                NumHoras = double.Parse(txtHorasMes.Text);
                NumHorasExtra = double.Parse(txtHorasExtraMes.Text);
                PagaPorHora = double.Parse(txtPagaPorHora.Text);

                //!? RMB2324 Cambiamos división por multiplicación en línea 32
                PagaHorasNormales = NumHoras * PagaPorHora;
                PagaHorasExtra = NumHorasExtra * (PagaPorHora * 2);
                PagaMensualBruto = PagaHorasNormales + PagaHorasExtra;
                //!? RMB2324 Cambiamos suma por multiplicación en línea 36
                ResultadoRetencion = PagaMensualBruto * RETENCION;
                PagaMensualNetoRMB2324 = PagaMensualBruto - ResultadoRetencion;

                //!? RMB2324 Cambiamos resta por multiplicación en línea 40
                PorcentajeRetencionRMB2324 = RETENCION * 100;

                NominaLabel.Text = "La nómina mensual es de " + PagaMensualNetoRMB2324.ToString() + " euros.";
                RetencionLabel.Text = " Retención aplicada del " + PorcentajeRetencionRMB2324.ToString() + "%";
            }
            catch(FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error: " + fEx.Message);
            }
        }
    }
}