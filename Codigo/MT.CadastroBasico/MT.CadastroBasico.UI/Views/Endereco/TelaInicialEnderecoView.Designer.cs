namespace MT.CadastroBasico.UI.Views.Endereco
{
    partial class TelaInicialEnderecoView
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
            this.lblListaDeEnderecos = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.gridListaDeEnderecos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridListaDeEnderecos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListaDeEnderecos
            // 
            this.lblListaDeEnderecos.AutoSize = true;
            this.lblListaDeEnderecos.Location = new System.Drawing.Point(12, 35);
            this.lblListaDeEnderecos.Name = "lblListaDeEnderecos";
            this.lblListaDeEnderecos.Size = new System.Drawing.Size(98, 13);
            this.lblListaDeEnderecos.TabIndex = 0;
            this.lblListaDeEnderecos.Text = "Lista de Endereços";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(435, 22);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 26);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.EventoClickBotaoNovo);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(516, 22);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 26);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(516, 321);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 26);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.EventoClickBotaoFechar);
            // 
            // gridListaDeEnderecos
            // 
            this.gridListaDeEnderecos.AllowUserToAddRows = false;
            this.gridListaDeEnderecos.AllowUserToDeleteRows = false;
            this.gridListaDeEnderecos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListaDeEnderecos.Location = new System.Drawing.Point(12, 60);
            this.gridListaDeEnderecos.Name = "gridListaDeEnderecos";
            this.gridListaDeEnderecos.Size = new System.Drawing.Size(579, 255);
            this.gridListaDeEnderecos.TabIndex = 4;
            // 
            // TelaInicialEnderecoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 358);
            this.Controls.Add(this.gridListaDeEnderecos);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lblListaDeEnderecos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TelaInicialEnderecoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Endereços";
            this.Load += new System.EventHandler(this.EventoFormularioEnderecoCarregado);
            ((System.ComponentModel.ISupportInitialize)(this.gridListaDeEnderecos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListaDeEnderecos;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridView gridListaDeEnderecos;
    }
}