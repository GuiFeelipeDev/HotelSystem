
namespace HotelTry2
{
    partial class formCadastro
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
            this.tb_nomeCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_tipoQarto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nmrDias = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.btn_limparCampos = new System.Windows.Forms.Button();
            this.cb_nmrQuarto = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tb_nomeCliente
            // 
            this.tb_nomeCliente.Font = new System.Drawing.Font("Lucida Console", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_nomeCliente.Location = new System.Drawing.Point(21, 39);
            this.tb_nomeCliente.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.tb_nomeCliente.Name = "tb_nomeCliente";
            this.tb_nomeCliente.Size = new System.Drawing.Size(432, 29);
            this.tb_nomeCliente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // cb_tipoQarto
            // 
            this.cb_tipoQarto.FormattingEnabled = true;
            this.cb_tipoQarto.Items.AddRange(new object[] {
            "Simples",
            "Suíte",
            "Luxo"});
            this.cb_tipoQarto.Location = new System.Drawing.Point(21, 101);
            this.cb_tipoQarto.Name = "cb_tipoQarto";
            this.cb_tipoQarto.Size = new System.Drawing.Size(150, 31);
            this.cb_tipoQarto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(276, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Número do quarto:";
            // 
            // tb_nmrDias
            // 
            this.tb_nmrDias.Location = new System.Drawing.Point(21, 170);
            this.tb_nmrDias.Name = "tb_nmrDias";
            this.tb_nmrDias.Size = new System.Drawing.Size(150, 30);
            this.tb_nmrDias.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(21, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nº de dias:";
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cadastrar.Location = new System.Drawing.Point(70, 214);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(149, 42);
            this.btn_Cadastrar.TabIndex = 8;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // btn_limparCampos
            // 
            this.btn_limparCampos.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_limparCampos.Location = new System.Drawing.Point(252, 214);
            this.btn_limparCampos.Name = "btn_limparCampos";
            this.btn_limparCampos.Size = new System.Drawing.Size(149, 42);
            this.btn_limparCampos.TabIndex = 9;
            this.btn_limparCampos.Text = "Limpar Campos";
            this.btn_limparCampos.UseVisualStyleBackColor = true;
            this.btn_limparCampos.Click += new System.EventHandler(this.btn_limparCampos_Click);
            // 
            // cb_nmrQuarto
            // 
            this.cb_nmrQuarto.FormattingEnabled = true;
            this.cb_nmrQuarto.Location = new System.Drawing.Point(293, 101);
            this.cb_nmrQuarto.Name = "cb_nmrQuarto";
            this.cb_nmrQuarto.Size = new System.Drawing.Size(160, 31);
            this.cb_nmrQuarto.TabIndex = 10;
            // 
            // formCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 271);
            this.Controls.Add(this.cb_nmrQuarto);
            this.Controls.Add(this.btn_limparCampos);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_nmrDias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_tipoQarto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_nomeCliente);
            this.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Location = new System.Drawing.Point(495, 318);
            this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.MaximumSize = new System.Drawing.Size(495, 318);
            this.Name = "formCadastro";
            this.Text = "Cadastro de Hóspedes";
            this.Load += new System.EventHandler(this.formCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_nomeCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_tipoQarto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nmrDias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Button btn_limparCampos;
        private System.Windows.Forms.ComboBox cb_nmrQuarto;
    }
}