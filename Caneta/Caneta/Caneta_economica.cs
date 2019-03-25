using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caneta
{
    //Definindo que a classe Caneta_economica é uma classe filha da "Caneta" Classe mãe
    class Caneta_economica : Caneta
    {



        /*Método para escrever e gastar apenas a medida de tinta, a caneta "normal" gasta 2
          Obs: o método possuí a palavra reservada override pois está sobreescrevendo o método
          escrever da clase mãe "Caneta"
        */
        public override int escrever(int qtde_tinta)
        {
            if (qtde_tinta >= 1)
            {
                Qtde_tinta = qtde_tinta - 1;
                return this.Qtde_tinta;
            }
            else
            {
                throw new Exception("Você não pussuí mais tinta nessa caneta ou o suficiente para realizar uma nova escrita. Gera uma noca caneta para continuar escrevendo.");
                return qtde_tinta;
            }


        }
    }
}
