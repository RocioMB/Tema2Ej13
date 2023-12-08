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
            double PagaMensualNeto;
            double PorcentajeRetencion;

            try
            {
                NumHoras = double.Parse(txtHorasMes.Text);
                NumHorasExtra = double.Parse(txtHorasExtraMes.Text);
                PagaPorHora = double.Parse(txtPagaPorHora.Text);

                PagaHorasNormales = NumHoras / PagaPorHora;
                PagaHorasExtra = NumHorasExtra * (PagaPorHora * 2);
                PagaMensualBruto = PagaHorasNormales + PagaHorasExtra;
                ResultadoRetencion = PagaMensualBruto + RETENCION;
                PagaMensualNeto = PagaMensualBruto - ResultadoRetencion;

                PorcentajeRetencion = RETENCION - 100;

                NominaLabel.Text = "La n�mina mensual es de " + PagaMensualNeto.ToString() + " euros.";
                RetencionLabel.Text = " Retenci�n aplicada del " + PorcentajeRetencion.ToString() + "%";
            }
            catch(FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error: " + fEx.Message);
            }
        }
    }
}