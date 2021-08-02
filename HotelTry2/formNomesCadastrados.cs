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
    public partial class formNomesCadastrados : Form
    {
        public formNomesCadastrados()
        {
            InitializeComponent();
        }

        private void formNomesCadastrados_Load(object sender, EventArgs e)
        {
            lb_Nomes.Items.Clear();
            for (int c = 0; c < mainForm.nomes_Total.Length; c++)
            {
                
                if(mainForm.nomes_Total[c] != null)
                {
                lb_Nomes.Items.Add(mainForm.nomes_Total[c]);
                }

            }
        }
    }
}
