using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace MediaAlunoOOP.Classe.Dados
{
    class Dados
    {
        //Treinamento, Programação Orientação ao Objeto
        //Inserindo dados, double
        //Programa, Media do aluno 
        //Jonas Valereo - Técnico em Informática 


        //declarando os attributos , campos e variaveis da classe dados
        //declarando tipo private, tipo double

        private double _portugues;
        private double _matematica;
        private double _ciencia;

        //declarando, construtor da classe dados
        public Dados (double portugues, double matematica, double ciencia){

            _portugues = portugues;
            _matematica = matematica;
            _ciencia = ciencia;

            }

        //declarando o metodo média da classe dados
        public double Media()
        {
            double s = (_portugues + _matematica + _ciencia) / 3.0;

         /*declarando a media do aluno, aprovado ou reprovado, 
            toma de decisão if e else */
            if (s >= 7.0)
            {
                 

                MessageBox.Show("Parabéns, aluno aprovado ", "Mensagem",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Infelizmente, aluno reprovado ", "Mensagem",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return s;
        }


        //declarando modificador da class dados, tipo string
        public override string ToString()
        {
            return  Media().ToString("F2", CultureInfo.InvariantCulture);
      
        }


    }
        //fim da classe dados
}
