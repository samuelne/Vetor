using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vetor
{
    public partial class menuVetor : Form
    {
       
        
        public menuVetor()
        {
            
            InitializeComponent();
            this.ActiveControl = txtNome;


        }

        public menuVetor(string mensagem)
        {
            this.mensagem = mensagem;
        }

        string[] nomes = new string[10];

        public int count;
        private string mensagem;




        //Após clicar ele irá incluir o nome no vetor
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            txtNome.Focus();

            if (txtNome.Text != string.Empty)
            {
                if (count <= 9)
                {
                    nomes[count] = txtNome.Text;
                    txtNome.Text = string.Empty;
                    count++;
                    txtNome.Focus();

                    txtNome.Focus();
                    txtViewNome.Text = string.Empty;

                    for (int i = 0; i <= 9; i++)
                    {
                        if (nomes[i] != string.Empty)
                        {
                            txtViewNome.Text += i + " " + nomes[i] + System.Environment.NewLine;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Não é possivel mais adicionar Nomes");
                }

            }


        }
        

        //Falta fazer ainda
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                nomes[count - 1] = string.Empty;
                count -= 1;
                //MessageBox.Show("Contador = " + count);

                txtNome.Focus();
                txtViewNome.Text = string.Empty;

                for (int i = 0; i <= 9; i++)
                {
                    if (nomes[i] != string.Empty)
                    {
                        txtViewNome.Text += i + " " + nomes[i] + System.Environment.NewLine;
                    }
                }
            }
            
        }

        //Atualiza a lista do vetor
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            txtNome.Focus();
            txtViewNome.Text = string.Empty;

            for (int i = 0; i <= 9; i++)
            {
                if (nomes[i] != string.Empty)
                {
                    txtViewNome.Text += i + " " + nomes[i] + System.Environment.NewLine;
                }
            }


        }
    }
}
