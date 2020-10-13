using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjeto2
{
    class cl_calcular
    {
        private int porcentagem = 5;
        private int porcentagem2 = 5;

        public int CalcularPrecoFinal(int preco_inicial, int tipo_produto)
        {
            int preco_final = 0;

            switch (tipo_produto)
            {
                case 1:
                    preco_final = preco_inicial + (preco_final * porcentagem / 100);
                    break;

                case 2:
                    preco_final = preco_inicial / (preco_final * porcentagem2 / 100);
                    break;

                
            }
            return preco_final;
        }


    }
}
