
namespace HotelTry2
{
    partial class formCadCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_NomeCliente = new System.Windows.Forms.TextBox();
            this.btn_cadCliente = new System.Windows.Forms.Button();
            this.btn_clearName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe o nome do cliente:";
            // 
            // tb_NomeCliente
            // 
            this.tb_NomeCliente.Location = new System.Drawing.Point(12, 42);
            this.tb_NomeCliente.Name = "tb_NomeCliente";
            this.tb_NomeCliente.Size = new System.Drawing.Size(514, 38);
            this.tb_NomeCliente.TabIndex = 1;
            // 
            // btn_cadCliente
            // 
            this.btn_cadCliente.Location = new System.Drawing.Point(66, 125);
            this.btn_cadCliente.Name = "btn_cadCliente";
            this.btn_cadCliente.Size = new System.Drawing.Size(175, 55);
            this.btn_cadCliente.TabIndex = 2;
            this.btn_cadCliente.Text = "Cadastrar";
            this.btn_cadCliente.UseVisualStyleBackColor = true;
            this.btn_cadCliente.Click += new System.EventHandler(this.btn_cadCliente_Click);
            // 
            // btn_clearName
            // 
            this.btn_clearName.Location = new System.Drawing.Point(292, 125);
            this.btn_clearName.Name = "btn_clearName";
            this.btn_clearName.Size = new System.Drawing.Size(175, 55);
            this.btn_clearName.TabIndex = 3;
            this.btn_clearName.Text = "Limpar";
            this.btn_clearName.UseVisualStyleBackColor = true;
            this.btn_clearName.Click += new System.EventHandler(this.btn_clearName_Click);
            // 
            // formCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 222);
            this.Controls.Add(this.btn_clearName);
            this.Controls.Add(this.btn_cadCliente);
            this.Controls.Add(this.tb_NomeCliente);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "formCadCliente";
            this.Text = "formCadCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_NomeCliente;
        private System.Windows.Forms.Button btn_cadCliente;
        private System.Windows.Forms.Button btn_clearName;
    }
}