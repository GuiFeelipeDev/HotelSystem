using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelTry2
{
    public partial class formCadCliente : Form
    {
        mainForm.cadastro_Nomes cad_Nomes = new mainForm.cadastro_Nomes();
        public int i;
        public formCadCliente()
        {
            InitializeComponent();
        }


        private void btn_cadCliente_Click(object sender, EventArgs e)
        {
            cad_Nomes.cad_nomeCliente = tb_NomeCliente.Text;
            mainForm.nomes_Total[i] = cad_Nomes.cad_nomeCliente;
            MessageBox.Show("Cliente "+mainForm.nomes_Total[i]+" cadastrado com sucesso!");
            i++;

        }

        private void btn_clearName_Click(object sender, EventArgs e)
        {
            tb_NomeCliente.Text = "";
            tb_NomeCliente.Focus();
        }
    }
}
