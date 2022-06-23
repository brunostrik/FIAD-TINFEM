using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIAD_TINFEM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Testa o preenchimento do email
            if(txtEmail.Text.Length == 0)
            {
                //mensagem de erro e parada
                MessageBox.Show("Preencha o email", "Atenção", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Testa o preenchimento da senha
            if (txtSenha.Text.Length == 0)
            {
                //mensagem de erro e parada
                MessageBox.Show("Preencha a senha", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
