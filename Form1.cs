namespace TP_03_PROJETO_03
{
    public partial class Form1 : Form
    {

        public EqSegundoGrau umaEquacao = new EqSegundoGrau();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            EqSegundoGrau umaEquacao = new EqSegundoGrau();

            umaEquacao.A = txtA.Text;
            umaEquacao.B = txtB.Text;
            umaEquacao.C = txtC.Text;



            EqSegundoGrauBLL.ValidarDados(umaEquacao);
            if (Erro.TemErro)
            {
                MessageBox.Show(Erro.Mensagem);
            }
            else
            {
                txtA.Text = umaEquacao.A.ToString();
                txtB.Text = umaEquacao.B;
                txtC.Text = umaEquacao.C;

                txtDelta.Text = umaEquacao.CalcDelta();
                txtX1.Text = umaEquacao.CalcX1();
                txtX2.Text = umaEquacao.CalcX2();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtDelta.Clear();
            txtX1.Clear();
            txtX2.Clear(); 
        }
    }
}


