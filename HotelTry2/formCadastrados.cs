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
    public partial class formCadastrados : Form
    {
        public formCadastrados()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void formCadastrados_Load(object sender, EventArgs e)
        {
                lb_clienteNome.Items.Clear();
                lb_tipoQuarto.Items.Clear();
                lb_qntDias.Items.Clear();
                lb_nmrQuarto.Items.Clear();
                lb_total.Items.Clear();
                foreach (mainForm.cadastro_Clientes hspd in mainForm.clientes_Cadastrados)
                {
                    lb_clienteNome.Items.Add(hspd.nome_Cliente);
                    lb_tipoQuarto.Items.Add(hspd.tipo_Quarto);
                    lb_qntDias.Items.Add(hspd.qtd_Dias);
                    lb_nmrQuarto.Items.Add(hspd.nmr_Quarto);
                    lb_total.Items.Add("R$"+hspd.valor_total+",00");
                }
            
        }
    }
}
