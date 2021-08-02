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
    public partial class mainForm : Form
    {
        formCadastro frmCad = new formCadastro();
        formCadastrados frmCads = new formCadastrados();
        formCadCliente frmCadCl = new formCadCliente();
        formNomesCadastrados frmNomesCad = new formNomesCadastrados();
        formCadQuarto frmCadQ = new formCadQuarto();
        public struct cadastro_Nomes
        {
            public string cad_nomeCliente;
        }
        public static String[] nomes_Total = new String[15];
        public struct cadastro_Quartos{
            public int nmr_qrtCadastrado;
        }
        public static int[] quartos_Cad = new int[15];

        //Struct da DB
        public struct cadastro_Clientes{
            //Dados do cadastro
            public string nome_Cliente;
            public string tipo_Quarto;
            public int nmr_Quarto;
            public int qtd_Dias;
            public int valor_total;
        }
        public static List<cadastro_Clientes> clientes_Cadastrados = new List<cadastro_Clientes>();

        public mainForm()
        {
            InitializeComponent();
        }

        private void btn_Cadastro_Click(object sender, EventArgs e)
        {
            frmCad.ShowDialog();
        }

        private void btn_Cadastrados_Click(object sender, EventArgs e)
        {
            frmCads.ShowDialog();
        }

        private void btn_cadNome_Click(object sender, EventArgs e)
        {
            frmCadCl.ShowDialog();
        }

        private void btn_verNomes_Click(object sender, EventArgs e)
        {
            frmNomesCad.ShowDialog();

        }

        private void btn_cadQuarto_Click(object sender, EventArgs e)
        {
            frmCadQ.ShowDialog();
        }
    }
}
