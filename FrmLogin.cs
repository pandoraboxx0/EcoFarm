namespace EcoFarm
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCadastro frmCadastro = new FrmCadastro();
            frmCadastro.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkEsqueceuSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FrmSenha frmSenha = new FrmSenha();
            frmSenha.Show();

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

        }
    }
}
