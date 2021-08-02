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
    public partial class formCadQuarto : Form
    {
        mainForm.cadastro_Quartos cad_Qrt = new mainForm.cadastro_Quartos();
        public int i;
        public formCadQuarto()
        {
            InitializeComponent();
        }

        private void btn_cadQuarto_Click(object sender, EventArgs e)
        {
            cad_Qrt.nmr_qrtCadastrado = Convert.ToInt32(tb_nmrQuarto.Text);
            mainForm.quartos_Cad[i] = cad_Qrt.nmr_qrtCadastrado;
            MessageBox.Show("Quarto " + mainForm.quartos_Cad[i] + " cadastrado com sucesso!");
            i++;
        }

        private void btn_clearNmr_Click(object sender, EventArgs e)
        {
            tb_nmrQuarto.Text = "";
            tb_nmrQuarto.Focus();
        }
    }
}
