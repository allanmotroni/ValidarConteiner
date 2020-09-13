using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidarConteiner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonValidar_Click(object sender, EventArgs e)
        {
            try
            {
                string conteiner = textBoxNumero.Text;
                ValidacoesBasicas(textBoxNumero);

                if (Validar(conteiner))
                {
                    labelMensagem.ForeColor = Color.Green;
                    labelMensagem.Text = string.Format("CONTÊINER {0} É VÁLIDO!", conteiner);
                }
                else
                {
                    labelMensagem.ForeColor = Color.Red;
                    labelMensagem.Text = string.Format("CONTÊINER {0} É INVÁLIDO!", conteiner);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGerarDigito_Click(object sender, EventArgs e)
        {
            try
            {
                string conteinerSemDigito = textBoxNumeroSemDigito.Text;
                ValidacoesBasicas(textBoxNumeroSemDigito);

                string digitoVerificador = GerarDigitoVerificador(conteinerSemDigito);
                textBoxConteinerComDigitoGerado.Text = string.Concat(conteinerSemDigito, digitoVerificador);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidacoesBasicas(TextBox textBox)
        {
            string conteiner = textBox.Text;
            if (string.IsNullOrEmpty(conteiner))
                throw new Exception("Campo vazio!");

            if (conteiner.Length != textBox.MaxLength)
                throw new Exception(string.Format("Campo deve ter {0} caracteres!", textBox.MaxLength));

            if (!conteiner.Substring(0, 4).IsLetter())
                throw new Exception("Os 4 primeiros caracteres devem ser letras!");
        }

        private bool Validar(string conteiner)
        {
            try
            {
                string digitoVerificador = conteiner.Substring(conteiner.Length - 1, 1);
                string digitoVerificadorEncontrado = GerarDigitoVerificador(conteiner);

                return digitoVerificador == digitoVerificadorEncontrado;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private string GerarDigitoVerificador(string conteiner)
        {
            try
            {
                Dictionary<string, int> listaLetras = GerarSiglasNumericas();
                int numero = 0;
                double total = 0;
                double subTotal = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (i < 4) //letras
                    {
                        listaLetras.TryGetValue(conteiner[i].ToString(), out numero);
                    }
                    else //números
                    {
                        numero = Convert.ToInt32(conteiner[i].ToString());
                    }

                    subTotal = numero * Math.Pow(2, i);
                    total += subTotal;
                }
                double resto = total % 11;
                double digitoVerificadorEncontrado = resto == 10 ? 0 : resto;
                return digitoVerificadorEncontrado.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private Dictionary<string, int> GerarSiglasNumericas()
        {
            Dictionary<string, int> lista = new Dictionary<string, int>();
            lista.Add("A", 10);
            lista.Add("B", 12);
            lista.Add("C", 13);
            lista.Add("D", 14);
            lista.Add("E", 15);
            lista.Add("F", 16);
            lista.Add("G", 17);
            lista.Add("H", 18);
            lista.Add("I", 19);
            lista.Add("J", 20);
            lista.Add("K", 21);
            lista.Add("L", 23);
            lista.Add("M", 24);
            lista.Add("N", 25);
            lista.Add("O", 26);
            lista.Add("P", 27);
            lista.Add("Q", 28);
            lista.Add("R", 29);
            lista.Add("S", 30);
            lista.Add("T", 31);
            lista.Add("U", 32);
            lista.Add("V", 34);
            lista.Add("W", 35);
            lista.Add("X", 36);
            lista.Add("Y", 37);
            lista.Add("Z", 38);
            return lista;
        }

    }
}
