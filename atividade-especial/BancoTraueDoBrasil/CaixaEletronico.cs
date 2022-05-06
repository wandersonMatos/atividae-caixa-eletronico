using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoTraueDoBrasil
{
    internal class CaixaEletronico
    {
        public static string CalcularSaque(int valorSaque)
        {
            int dinheiro = valorSaque;
            string ultimoDigitoValor = valorSaque.ToString().Substring(valorSaque.ToString().Length - 1, 1);
            string resultado = "";
            List<int> listaNotasValidas = new List<int>() { 100, 50, 20, 10, 5, 2 };
            List<int> listaNotasSaque = new List<int>();

            for (int i = 0; i < listaNotasValidas.Count; i++)
            {
                if (valorSaque == 1 || valorSaque == 3)
                {
                    resultado = "não é possivel realizar o saque";

                }
                else if (ultimoDigitoValor == "1" || ultimoDigitoValor == "3" || ultimoDigitoValor == "6" || ultimoDigitoValor == "8")
                {

                    if (i != listaNotasValidas.Count - 1)
                    {
                        listaNotasSaque.Add((dinheiro - listaNotasValidas[i]) / listaNotasValidas[i]);
                        dinheiro = dinheiro % listaNotasValidas[i];
                        dinheiro += listaNotasValidas[i];

                    }
                    else
                    {
                        listaNotasSaque.Add((dinheiro / listaNotasValidas[i]));
                        dinheiro = dinheiro % listaNotasValidas[i];
                    }

                }
                else
                {
                    listaNotasSaque.Add(dinheiro / listaNotasValidas[i]);
                    dinheiro = dinheiro % listaNotasValidas[i];
                }
            }

            resultado += "Valor Sacado: R$" + valorSaque + ",00. Sendo:\n";

            for (int i = 0; i < listaNotasSaque.Count; i++)
            {
                resultado += listaNotasSaque[i] + " nota(s) de R$" + listaNotasValidas[i] + ",00.\n";
            }

            return resultado;
        }
    }
}
