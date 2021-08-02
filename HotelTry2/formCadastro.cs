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
    public partial class formCadastro : Form
    {
        public int check_Cadastro;
        public formCadastro()
        {
            InitializeComponent();
        }

        private void btn_limparCampos_Click(object sender, EventArgs e)
        {
            tb_nmrDias.Text = "";
            cb_nmrQuarto.Text = "";
            tb_nomeCliente.Text = "";
            cb_tipoQarto.SelectedIndex = -1;
            tb_nomeCliente.Focus();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            mainForm.cadastro_Clientes cad_Cl = new mainForm.cadastro_Clientes();
            for(int c = 0; c < mainForm.nomes_Total.Length; c++)
            {
                if (tb_nomeCliente.Text == mainForm.nomes_Total[c])
                {
                    check_Cadastro = 1;
                    c = mainForm.nomes_Total.Length;
                }
                else
                {
                    check_Cadastro = 0;
                }
            }
            if(check_Cadastro == 1)
            {
                if (tb_nomeCliente.Text != "" && tb_nmrDias.Text != "" && cb_tipoQarto.Text != "" && cb_nmrQuarto.Text != "")
                {
                    cad_Cl.nome_Cliente = tb_nomeCliente.Text;
                    cad_Cl.qtd_Dias = Convert.ToInt32(tb_nmrDias.Text);
                    cad_Cl.tipo_Quarto = cb_tipoQarto.Text;
                    cad_Cl.nmr_Quarto = Convert.ToInt32(cb_nmrQuarto.Text);
                    if (cb_tipoQarto.Text == "Simples")
                    {
                        cad_Cl.valor_total = Convert.ToInt32(tb_nmrDias.Text) * 50;
                    }
                    else if (cb_tipoQarto.Text == "Suíte")
                    {
                        cad_Cl.valor_total = Convert.ToInt32(tb_nmrDias.Text) * 80;
                    }
                    else
                    {
                        cad_Cl.valor_total = Convert.ToInt32(tb_nmrDias.Text) * 150;
                    }


                    mainForm.clientes_Cadastrados.Add(cad_Cl);              
                    MessageBox.Show("Cliente cadastrado com sucesso! ");
                    cb_nmrQuarto.Items.Remove(cad_Cl.nmr_Quarto);
                    for(int i = 0; i < mainForm.quartos_Cad.Length; i++)
                    {
                        if(cad_Cl.nmr_Quarto == mainForm.quartos_Cad[i])
                        {
                            mainForm.quartos_Cad[i] = 0;
                        
                        }
                        if (i != 0)
                        {
                            if (mainForm.quartos_Cad[i - 1] == 0)
                            {
                                mainForm.quartos_Cad[i - 1] = mainForm.quartos_Cad[i];
                                mainForm.quartos_Cad[i] = 0;
                            }
                        }
                    }

                    cb_nmrQuarto.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Insira todos os dados corretamente!");
                }
            }
            else
            {
                MessageBox.Show("Cliente não encontrado!");
            }



        }

        private void formCadastro_Load(object sender, EventArgs e)
        {
            cb_nmrQuarto.Items.Clear();
            for(int c = 0; c < mainForm.quartos_Cad.Length; c++)
            {
                if(mainForm.quartos_Cad[c] != 0)
                {
                    cb_nmrQuarto.Items.Add(mainForm.quartos_Cad[c]);

                }

            }
        }
    }
}
