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
    public partial class Form1 : Form
    {
       
        
        public Form1()
        {
            
            InitializeComponent();
            

        }


        string[] nomes = new string[10];

        public int count;

        private void button1_Click(object sender, EventArgs e)
        {

            if(txtNome.Text != string.Empty)
            {
                nomes[count] = txtNome.Text;
                txtNome.Text = string.Empty;
                txtNome.Focus();
                count++;

            }
           

        }
        

        //Falta fazer ainda
        private void btnDeletar_Click(object sender, EventArgs e)
        {


            txtNome.Text = string.Empty;
            txtNome.Focus();

            for (int i = 9; i <= 0; i--)
            {
                if (nomes[i] != null)
                {
                    txtNome.Text += nomes[i] + System.Environment.NewLine;
                }
            }
        }

        //Atualiza a lista do vetor
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            txtViewNome.Text = string.Empty;

            for (int i = 0; i <= 9; i++)
            {
                if (nomes[i] != null)
                {
                    txtViewNome.Text += nomes[i] + System.Environment.NewLine;
                }
            }


        }
    }
}
