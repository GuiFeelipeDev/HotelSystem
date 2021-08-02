
namespace HotelTry2
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Cadastro = new System.Windows.Forms.Button();
            this.btn_Cadastrados = new System.Windows.Forms.Button();
            this.btn_cadNome = new System.Windows.Forms.Button();
            this.btn_verNomes = new System.Windows.Forms.Button();
            this.btn_cadQuarto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(99, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label1.Size = new System.Drawing.Size(279, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "BEM VINDO!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(92, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label2.Size = new System.Drawing.Size(303, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "O que deseja?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Cadastro
            // 
            this.btn_Cadastro.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cadastro.Location = new System.Drawing.Point(71, 335);
            this.btn_Cadastro.Margin = new System.Windows.Forms.Padding(4, 30, 4, 3);
            this.btn_Cadastro.Name = "btn_Cadastro";
            this.btn_Cadastro.Size = new System.Drawing.Size(150, 60);
            this.btn_Cadastro.TabIndex = 2;
            this.btn_Cadastro.Text = "Cadastrar Hospedagem";
            this.btn_Cadastro.UseVisualStyleBackColor = true;
            this.btn_Cadastro.Click += new System.EventHandler(this.btn_Cadastro_Click);
            // 
            // btn_Cadastrados
            // 
            this.btn_Cadastrados.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cadastrados.Location = new System.Drawing.Point(255, 335);
            this.btn_Cadastrados.Margin = new System.Windows.Forms.Padding(4, 30, 4, 3);
            this.btn_Cadastrados.Name = "btn_Cadastrados";
            this.btn_Cadastrados.Size = new System.Drawing.Size(150, 60);
            this.btn_Cadastrados.TabIndex = 3;
            this.btn_Cadastrados.Text = "Checar Hospedagens";
            this.btn_Cadastrados.UseVisualStyleBackColor = true;
            this.btn_Cadastrados.Click += new System.EventHandler(this.btn_Cadastrados_Click);
            // 
            // btn_cadNome
            // 
            this.btn_cadNome.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cadNome.Location = new System.Drawing.Point(71, 147);
            this.btn_cadNome.Margin = new System.Windows.Forms.Padding(4, 30, 4, 3);
            this.btn_cadNome.Name = "btn_cadNome";
            this.btn_cadNome.Size = new System.Drawing.Size(150, 60);
            this.btn_cadNome.TabIndex = 4;
            this.btn_cadNome.Text = "Cadastrar Cliente";
            this.btn_cadNome.UseVisualStyleBackColor = true;
            this.btn_cadNome.Click += new System.EventHandler(this.btn_cadNome_Click);
            // 
            // btn_verNomes
            // 
            this.btn_verNomes.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_verNomes.Location = new System.Drawing.Point(255, 147);
            this.btn_verNomes.Margin = new System.Windows.Forms.Padding(4, 30, 4, 3);
            this.btn_verNomes.Name = "btn_verNomes";
            this.btn_verNomes.Size = new System.Drawing.Size(150, 60);
            this.btn_verNomes.TabIndex = 5;
            this.btn_verNomes.Text = "Ver Nomes Cadastrados";
            this.btn_verNomes.UseVisualStyleBackColor = true;
            this.btn_verNomes.Click += new System.EventHandler(this.btn_verNomes_Click);
            // 
            // btn_cadQuarto
            // 
            this.btn_cadQuarto.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cadQuarto.Location = new System.Drawing.Point(160, 242);
            this.btn_cadQuarto.Margin = new System.Windows.Forms.Padding(4, 30, 4, 3);
            this.btn_cadQuarto.Name = "btn_cadQuarto";
            this.btn_cadQuarto.Size = new System.Drawing.Size(150, 60);
            this.btn_cadQuarto.TabIndex = 6;
            this.btn_cadQuarto.Text = "Cadastrar Quartos";
            this.btn_cadQuarto.UseVisualStyleBackColor = true;
            this.btn_cadQuarto.Click += new System.EventHandler(this.btn_cadQuarto_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 435);
            this.Controls.Add(this.btn_cadQuarto);
            this.Controls.Add(this.btn_verNomes);
            this.Controls.Add(this.btn_cadNome);
            this.Controls.Add(this.btn_Cadastrados);
            this.Controls.Add(this.btn_Cadastro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MaximumSize = new System.Drawing.Size(502, 482);
            this.MinimumSize = new System.Drawing.Size(502, 482);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel CACERENSE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Cadastro;
        private System.Windows.Forms.Button btn_Cadastrados;
        private System.Windows.Forms.Button btn_cadNome;
        private System.Windows.Forms.Button btn_verNomes;
        private System.Windows.Forms.Button btn_cadQuarto;
    }
}

