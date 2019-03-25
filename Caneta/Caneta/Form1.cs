using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caneta
{
    public partial class Form1 : Form
    {
        //Declarando um onjeto vazio do tipo caneta (Classe mãe)
        Caneta caneta;


        public Form1()
        {
            InitializeComponent();
        }


        //Método para atualizar a sinformações da caneta na tela
        public void atualizar_info_caneta()
        {
            label_modelo.Text = "Modelo: " + caneta.Modelo;
            label_marca.Text = "Marca: " + caneta.Marca;
            label_cor.Text = "Cor: " + caneta.Cor;
            label_cor_tinta.Text = "Cor tinta: " + caneta.Cor_tinta;
            label_qtde_tinta.Text = "Quantidade de tinta: " + caneta.Qtde_tinta;
        }

        //Método para atualizar a quantidade de tinta na tela
        public void atualizar_tinta(int qtde_tinta)
        {
            label_qtde_tinta.Text = "Quantidade de tinta: " + qtde_tinta;
        }

        //Método para atualizar a quantidade de vezes que foi escrito na tela
        public void atualizar_n_escreveu(int qtde)
        {
            label_vezes_escreveu.Text = "Quantas vezes escreveu: " + qtde;
        }

        //Botão para realizar a escrita do texto
        private void botao_escrever_Click_1(object sender, EventArgs e)
        {
            try { 
            if (caneta != null)
            {
                //Verificando se existe alguma entrada no caixa de texto da escrita
                if (txt_caixa.Text.Length != 0)
                    { 
                    caneta.Qtde_tinta = caneta.escrever(caneta.Qtde_tinta);
                    Caneta.hist_escrita.Add(txt_caixa.Text);
                    Caneta.atualizar_vezes_escreveu();
                    atualizar_tinta(caneta.Qtde_tinta);
                    atualizar_n_escreveu(Caneta.qtde_escreveu);
                    atualizar_hist_escritas();
                    }
                else
                //Jogando uma nova exceção caso não exista uma entrada no caixa de texto
                    {
                        throw new Exception("Você não inseriu nenhuma entrada de escrita, insira uma entrada e tente novamente!");
                    }
                }

            else
	        {   //Criando uma nova exceção para lançar uma mensagem na tela quando o usuário tentar escrever
                //enquanto uma caneta não tiver sido criada
                throw new Exception("Você não pode escrever sem uma caneta! Gere uma caneta primeiro!");
                    
            }
            }//Após lançar o try, o catch irá pegar a exceção e lançar a respectiva mensagem na tela
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        //Método que implementa o que for de interesse duranrte a inicialização da tela
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Botão para gerar a caneta
        private void button_gerar_caneta(object sender, EventArgs e)
        {
            //Estrutura de condição para verificar se o CheckBox está selecionado, se caso estiver ele irá utilizar 
            //a caneta econônomica, caso não irá utilizar caneta padrão
            if (eco.Checked == true)
            {
                caneta = new Caneta_economica();
                atualizar_info_caneta();
            }
            else
            {
                caneta = new Caneta();
                atualizar_info_caneta();
            }
        }

        //Método para atualizar as palavras escritas no ListBox da tela
        private void atualizar_hist_escritas()
        {
            
                listBox_hist_escritas.Items.Add(Caneta.hist_escrita[Caneta.hist_escrita.Count -1]);
            
        }
    }
}
