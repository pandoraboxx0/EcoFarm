namespace EcoFarm
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            txtUsuario = new TextBox();
            txtSenhaLogin = new TextBox();
            btnEntrar = new Button();
            linkCadastrar = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            linkEsqueceuSenha = new LinkLabel();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = SystemColors.ControlText;
            txtUsuario.Location = new Point(527, 359);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(313, 30);
            txtUsuario.TabIndex = 0;
            txtUsuario.Text = "Digite seu usuário";
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // txtSenhaLogin
            // 
            txtSenhaLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenhaLogin.Location = new Point(527, 409);
            txtSenhaLogin.Name = "txtSenhaLogin";
            txtSenhaLogin.Size = new Size(313, 30);
            txtSenhaLogin.TabIndex = 1;
            txtSenhaLogin.Text = "Digite sua senha";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.Green;
            btnEntrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEntrar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = SystemColors.ButtonFace;
            btnEntrar.Location = new Point(615, 469);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(129, 37);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // linkCadastrar
            // 
            linkCadastrar.AutoSize = true;
            linkCadastrar.BackColor = SystemColors.ActiveBorder;
            linkCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkCadastrar.ForeColor = SystemColors.ActiveCaptionText;
            linkCadastrar.LinkColor = Color.FromArgb(0, 64, 0);
            linkCadastrar.Location = new Point(1003, 576);
            linkCadastrar.Name = "linkCadastrar";
            linkCadastrar.Size = new Size(114, 28);
            linkCadastrar.TabIndex = 3;
            linkCadastrar.TabStop = true;
            linkCadastrar.Text = "Cadastre-se";
            linkCadastrar.LinkClicked += linkCadastrar_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(746, 576);
            label1.Name = "label1";
            label1.Size = new Size(251, 28);
            label1.TabIndex = 4;
            label1.Text = "Ainda não possui cadastro?";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(274, 576);
            label2.Name = "label2";
            label2.Size = new Size(157, 28);
            label2.TabIndex = 5;
            label2.Text = "Esqueceu senha?";
            // 
            // linkEsqueceuSenha
            // 
            linkEsqueceuSenha.AutoSize = true;
            linkEsqueceuSenha.BackColor = SystemColors.ActiveBorder;
            linkEsqueceuSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkEsqueceuSenha.ForeColor = SystemColors.ActiveCaptionText;
            linkEsqueceuSenha.LinkColor = Color.FromArgb(0, 64, 0);
            linkEsqueceuSenha.Location = new Point(438, 576);
            linkEsqueceuSenha.Name = "linkEsqueceuSenha";
            linkEsqueceuSenha.Size = new Size(110, 28);
            linkEsqueceuSenha.TabIndex = 6;
            linkEsqueceuSenha.TabStop = true;
            linkEsqueceuSenha.Text = "Clique aqui";
            linkEsqueceuSenha.LinkClicked += linkEsqueceuSenha_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Green;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Ivory;
            label3.Location = new Point(378, 707);
            label3.Name = "label3";
            label3.Size = new Size(618, 28);
            label3.TabIndex = 7;
            label3.Text = "Caso precise de suporte, favor nos contatar: suporte@ecofarm.com.br";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1368, 761);
            Controls.Add(label3);
            Controls.Add(linkEsqueceuSenha);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(linkCadastrar);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenhaLogin);
            Controls.Add(txtUsuario);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtSenhaLogin;
        private Button btnEntrar;
        private LinkLabel linkCadastrar;
        private Label label1;
        private Label label2;
        private LinkLabel linkEsqueceuSenha;
        private Label label3;
    }
}
