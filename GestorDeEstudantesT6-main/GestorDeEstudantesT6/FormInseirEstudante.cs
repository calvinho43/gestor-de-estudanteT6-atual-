using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantesT6
{
    public partial class FormInseirEstudante : Form
    {
        public FormInseirEstudante()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        bool Verificar()
        {
            if ((textBoxNome.Text.Trim()=="") ||
                (textBoxSobrenome.Text.Trim()=="") ||
                (textBoxTelefone.Text.Trim()=="") ||
                (textBoxEndereco.Text.Trim()=="") ||
                (pictureBoxUsuario.Image == null))
                
            {
                return false;
            }
            else
            {
                return true;
            }
        }
     
        private void EnviarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog selecionarImagem = new OpenFileDialog();

            selecionarImagem.Filter = "selecione a foto(*.jpg;*.png;*.gif)|";
            if (selecionarImagem.ShowDialog() == DialogResult.OK)
            {
                pictureBoxUsuario.Image = Image.FromFile(selecionarImagem.FileName);
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            Estudante estudante = new Estudante();
            string nome = textBoxNome.Text;
            string sobrenome = textBoxSobrenome.Text;
            DateTime nascimento = dateTimePicker1.Value;
            string telefone = textBoxTelefone.Text;
            string endereco = textBoxEndereco.Text;
            string genero = "Feminino";

        }

        




            