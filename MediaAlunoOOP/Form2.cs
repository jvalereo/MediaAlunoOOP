using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using MediaAlunoOOP.Classe.Dados;

namespace MediaAlunoOOP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnClique_Click(object sender, EventArgs e)
        {
            //Treinamento, Programação Orientação ao Objeto
            //Inserindo dados, double
            //Programa, Media do aluno 
            //Jonas Valereo - Técnico em Informática 

            //declarando , validação das textbox, if 

            //declarando, validação da textboxPortugues
            if (textBoxPortugues.Text == "")
            {
                MessageBox.Show("Nota de portugues.", "Preencha", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textBoxPortugues.BackColor = Color.Aqua;
                textBoxPortugues.Focus();

                return; 
            }

            //declarando, validação da textboxMatematica
            if(textBoxMatematica.Text == "")
            {
                MessageBox.Show("Nota de matemática.", "Preenchar", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                textBoxMatematica.BackColor = Color.Aqua;
                textBoxMatematica.Focus();

                return;
            }

            //declarando, validação da textboxCiencia
            if(textBoxCiencia.Text == "")
            {
                MessageBox.Show("Nota de ciência.", "Preenchar", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textBoxCiencia.BackColor = Color.Aqua;
                textBoxCiencia.Focus();

                return;
            }

            //fim da autenticação das textbox

            /*declarando o codigo entrada de dado na textBox,
            declarando variaveis auxiliares*/
            double portugues = double.Parse(textBoxPortugues.Text, CultureInfo.InvariantCulture);
            double matematica = double.Parse(textBoxMatematica.Text, CultureInfo.InvariantCulture);
            double ciencia = double.Parse(textBoxCiencia.Text, CultureInfo.InvariantCulture);

            //declarando obejeto m da classe dados
            Dados m = new Dados(portugues, matematica, ciencia);

            /*declarando, imprimir saida de dados messageBox, chamando o objeto m,
             chamando o método toString da classe dados*/
            MessageBox.Show("Média do aluno " + m.ToString(), "Mensagem",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //declarando limpar textbox apos finalizar a média do aluno
            textBoxPortugues.Clear();
            textBoxMatematica.Clear();
            textBoxCiencia.Clear();
            textBoxPortugues.Focus();
            textBoxPortugues.BackColor = Color.White;
            textBoxMatematica.BackColor = Color.White;
            textBoxCiencia.BackColor = Color.White;

            //fim do programa buttom clique
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //declarando limpar textbox buttom cancelar
            textBoxPortugues.Clear();
            textBoxMatematica.Clear();
            textBoxCiencia.Clear();
            textBoxPortugues.Focus();
            textBoxPortugues.BackColor = Color.White;
            textBoxMatematica.BackColor = Color.White;
            textBoxCiencia.BackColor = Color.White;

            //fim do programa buttom cancelar
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            //declarando close buttom fechar
            Close();

            //fim do programa buttom fechar
        }

        //fim do programa
    }
}
