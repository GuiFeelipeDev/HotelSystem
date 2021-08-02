
namespace HotelTry2
{
    partial class formCadQuarto
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
            this.btn_clearNmr = new System.Windows.Forms.Button();
            this.btn_cadQuarto = new System.Windows.Forms.Button();
            this.tb_nmrQuarto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_clearNmr
            // 
            this.btn_clearNmr.Location = new System.Drawing.Point(310, 89);
            this.btn_clearNmr.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clearNmr.Name = "btn_clearNmr";
            this.btn_clearNmr.Size = new System.Drawing.Size(175, 55);
            this.btn_clearNmr.TabIndex = 7;
            this.btn_clearNmr.Text = "Limpar";
            this.btn_clearNmr.UseVisualStyleBackColor = true;
            this.btn_clearNmr.Click += new System.EventHandler(this.btn_clearNmr_Click);
            // 
            // btn_cadQuarto
            // 
            this.btn_cadQuarto.Location = new System.Drawing.Point(77, 89);
            this.btn_cadQuarto.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cadQuarto.Name = "btn_cadQuarto";
            this.btn_cadQuarto.Size = new System.Drawing.Size(175, 55);
            this.btn_cadQuarto.TabIndex = 6;
            this.btn_cadQuarto.Text = "Cadastrar";
            this.btn_cadQuarto.UseVisualStyleBackColor = true;
            this.btn_cadQuarto.Click += new System.EventHandler(this.btn_cadQuarto_Click);
            // 
            // tb_nmrQuarto
            // 
            this.tb_nmrQuarto.Location = new System.Drawing.Point(386, 24);
            this.tb_nmrQuarto.Margin = new System.Windows.Forms.Padding(4);
            this.tb_nmrQuarto.Name = "tb_nmrQuarto";
            this.tb_nmrQuarto.Size = new System.Drawing.Size(146, 34);
            this.tb_nmrQuarto.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Informe o nº do quarto:";
            // 
            // formCadQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 173);
            this.Controls.Add(this.btn_clearNmr);
            this.Controls.Add(this.btn_cadQuarto);
            this.Controls.Add(this.tb_nmrQuarto);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(589, 220);
            this.MinimumSize = new System.Drawing.Size(589, 220);
            this.Name = "formCadQuarto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formCadQuarto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_clearNmr;
        private System.Windows.Forms.Button btn_cadQuarto;
        private System.Windows.Forms.TextBox tb_nmrQuarto;
        private System.Windows.Forms.Label label1;
    }
}