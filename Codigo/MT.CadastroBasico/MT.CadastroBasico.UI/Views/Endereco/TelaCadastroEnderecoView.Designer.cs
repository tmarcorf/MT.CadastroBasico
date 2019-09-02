namespace MT.CadastroBasico.UI.Views.Endereco
{
    partial class TelaCadastroEnderecoView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.txbLogradouro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txbBairro = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txbCidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(15, 50);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição";
            // 
            // txbDescricao
            // 
            this.txbDescricao.Location = new System.Drawing.Point(76, 47);
            this.txbDescricao.MaxLength = 50;
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(312, 20);
            this.txbDescricao.TabIndex = 1;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(9, 76);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(61, 13);
            this.lblLogradouro.TabIndex = 2;
            this.lblLogradouro.Text = "Logradouro";
            // 
            // txbLogradouro
            // 
            this.txbLogradouro.Location = new System.Drawing.Point(76, 73);
            this.txbLogradouro.MaxLength = 50;
            this.txbLogradouro.Name = "txbLogradouro";
            this.txbLogradouro.Size = new System.Drawing.Size(312, 20);
            this.txbLogradouro.TabIndex = 3;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(36, 102);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 4;
            this.lblBairro.Text = "Bairro";
            // 
            // txbBairro
            // 
            this.txbBairro.Location = new System.Drawing.Point(76, 99);
            this.txbBairro.MaxLength = 50;
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.Size = new System.Drawing.Size(312, 20);
            this.txbBairro.TabIndex = 5;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(30, 128);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 6;
            this.lblCidade.Text = "Cidade";
            // 
            // txbCidade
            // 
            this.txbCidade.Location = new System.Drawing.Point(76, 125);
            this.txbCidade.MaxLength = 50;
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.Size = new System.Drawing.Size(312, 20);
            this.txbCidade.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Insira as informações para o cadastro do endereço";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(313, 168);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 26);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.EventoCliqueBotaoSalvar);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(232, 168);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 26);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.EventoClickBotaoCancelar);
            // 
            // TelaCadastroEnderecoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 210);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txbBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txbLogradouro);
            this.Controls.Add(this.lblLogradouro);
            this.Controls.Add(this.txbDescricao);
            this.Controls.Add(this.lblDescricao);
            this.MaximizeBox = false;
            this.Name = "TelaCadastroEnderecoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Endereço";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.TextBox txbLogradouro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txbBairro;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txbCidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
    }
}