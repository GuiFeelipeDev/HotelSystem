
namespace HotelTry2
{
    partial class formNomesCadastrados
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
            this.lb_Nomes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Nomes
            // 
            this.lb_Nomes.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Nomes.FormattingEnabled = true;
            this.lb_Nomes.ItemHeight = 20;
            this.lb_Nomes.Location = new System.Drawing.Point(22, 46);
            this.lb_Nomes.Name = "lb_Nomes";
            this.lb_Nomes.Size = new System.Drawing.Size(498, 364);
            this.lb_Nomes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clientes Cadastrados:";
            // 
            // formNomesCadastrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 442);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Nomes);
            this.Name = "formNomesCadastrados";
            this.Text = "Clientes Cadastrados";
            this.Load += new System.EventHandler(this.formNomesCadastrados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Nomes;
        private System.Windows.Forms.Label label1;
    }
}