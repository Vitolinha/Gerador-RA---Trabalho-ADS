using Gerador_de_RA.Modelo;

namespace Gerador_de_RA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Executar()
        {
            Controle controle = new Controle();
            controle.Executar(cboxPeriodo.Text, cboxCurso.Text, cboxCampus.Text);
            if (controle.mensagem.Equals(""))
            {
                lblRA.Text = controle.codaluno;
            }
            else
            {
                lblRA.Text = controle.mensagem;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblInsiraCampus_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cboxPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            Executar();
        }
    }
}
