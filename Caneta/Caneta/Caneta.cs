using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caneta
{
    class Caneta
    {
        //Métodos com definição de acesso como rptected para que classes filhas como a "Caneta_econômica" possa ter acesso
        protected String cor; 
        protected String cor_tinta;
        protected String modelo;
        protected String marca;
        protected int qtde_tinta;
        public static int canetas_criadas;
        public static int qtde_escreveu;
        public static List<string> hist_escrita = new List<string>();

        //Propriedade para pegar e setar informações do atributo que é protected ou provate
        public string Cor
        {
            get
            {
                return cor;
            }

            set
            {
                cor = value;
            }
        }

        //Propriedade para pegar e setar informações do atributo que é protected ou provate
        public string Cor_tinta
        {
            get
            {
                return cor_tinta;
            }

            set
            {
                cor_tinta = value;
            }
        }

        //Propriedade para pegar e setar informações do atributo que é protected ou provate
        public string Modelo
        {
            get
            {
                return modelo;
            }

            set
            {
                modelo = value;
            }
        }
        
        //Propriedade para pegar e setar informações do atributo que é protected ou provate
        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
            }
        }


        //Propriedade para pegar e setar informações do atributo que é protected ou provate
        public int Qtde_tinta
        {
            get
            {
                return qtde_tinta;
            }

            set
            {
                qtde_tinta = value;
            }
        }

        //Método para gerar aleatoriamente uma nova cor para a caneta
        public String gerar_cor()
        {
            String[] cores = new String[5];
            Random randNum = new Random();
            cores[0] = "Azul";
            cores[1] = "Vermelho";
            cores[2] = "Verde";
            return cores[randNum.Next(0,3)];
        }

        //Método para gerar aleatoriamente uma nova marca para a caneta
        public String gerar_marca()
        {
            String[] marcas = new String[5];
            Random randNum = new Random();
            marcas[0] = "BIC";
            marcas[1] = "Faber - Castell";
            marcas[2] = "Crown";
            return marcas[randNum.Next(0,3)];
        }

        //Método para gerar aleatoriamente uma nova cor de tinta
        public String gerar_cor_tinta()
        {
            String[] cores_tinta = new String[5];
            Random randNum = new Random();
            cores_tinta[0] = "Azul";
            cores_tinta[1] = "Vermelho";
            cores_tinta[2] = "Verde";
            return cores_tinta[randNum.Next(0,3)];
        }

        //Método para gerar aleatoriamente um modelo de caneta
        public String gerar_modelo()
        {
            String[] modelos = new String[5];
            Random randNum = new Random();
            modelos[0] = "Azul";
            modelos[1] = "Vermelho";
            modelos[2] = "Verde";
            return modelos[randNum.Next(0,3)];
        }

        //Constrtur padrão sem parâmetros
        public Caneta()
        {
            this.Cor = gerar_cor();
            this.Cor_tinta = gerar_cor_tinta();
            this.Marca = gerar_marca();
            this.Modelo = gerar_modelo();
            this.Qtde_tinta = 10; 
        }

        /*Método utilizado para escrever coma  caneta - 
          Obs: o método possuí a palavra reservada virtual pois será sobreescrito pelo método
          da classe filha "Caneta_economica"
             */   
    public virtual int escrever(int qtde_tinta)
        {
            if (qtde_tinta >= 2)
            { 
            this.Qtde_tinta = qtde_tinta - 2;
            return this.Qtde_tinta;
            }
            else
            {
                throw new Exception("Você não pussuí mais tinta nessa caneta ou o suficiente para realizar uma nova escrita. Gera uma noca caneta para continuar escrevendo.");
                return qtde_tinta;
            }
        }

        public static void atualizar_num_canetas()
        {
            canetas_criadas++;
        }

        public static void atualizar_vezes_escreveu()
        {
            qtde_escreveu++;
        }
    }
}
