using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceCheckout.App
{
    public class PedidoService
    {
        public static string GerarPedido(string regiao, int numeroPedido)
        { string resultado = $"{regiao.ToUpper()}-{numeroPedido.ToString("D4")}";
            return resultado;
        }
    
        public static int CalcularPontosFidelidade(int valorTotal)
        {
            int valorCompra = 10;
            int numeroPontos = 2;
            int parcelasDezReais = valorTotal / valorCompra;
            int pontos = parcelasDezReais * numeroPontos;

            return pontos;

        }
    
        public static bool TemDireitoAFreteGratis(int valorTotal, bool eClienteVip)
        {

            if (valorTotal >= 200 || eClienteVip)
            {
                return true;
            }
            else
            {
                return false;
            }
        }






    }




}