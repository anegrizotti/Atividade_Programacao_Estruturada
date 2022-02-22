using System;

namespace Atividade_Programacao_Estruturada.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aux = 0;
            int[] numeros = new int[10];

            // leitura dos 10 números de entrada
            PedeEGuardaNumeros(aux, numeros);
            Console.WriteLine();

            // define que o maior número foi o primeiro digitado, para poder compara com os outros
            int maiorNumero = numeros[0];

            // calcula o maior número
            Console.WriteLine("Maior número: ");
            Console.WriteLine(CalculaMaiorNumero(numeros, ref maiorNumero));
            Console.WriteLine();

            // define que o menor número foi o primeiro digitado, para poder compara com os outros
            int menorNumero;

            // calcula o menor número
            Console.WriteLine("Menor número: ");
            Console.WriteLine(CalculaMenorNumero(numeros, out menorNumero));
            Console.WriteLine();

            // definindo que a soma inicial é 0
            int soma = 0;

            // calcula a média dos números
            Console.WriteLine("Média dos números: ");
            Console.WriteLine(CalculaMediaDosNumeros(numeros, ref soma));
            Console.WriteLine();

            // encontra os 3 maiores valores
            int segundoMaior = numeros[0];
            int terceiroMaior = numeros[0];
            EncontraTresMaiores(numeros, ref maiorNumero, ref segundoMaior, ref terceiroMaior);
            Console.WriteLine();

            // encontra os valores negativos 
            Console.WriteLine("Valores negativos: ");
            EncontraNegativos(numeros);
            Console.WriteLine();

            // mostra os valores da sequencia
            Console.WriteLine("Valores da sequência: ");
            MostraValores(numeros);
            Console.WriteLine();

            // remove um item da sequencia
            RemoveItemDaSequencia(numeros);
            Console.WriteLine();
        }

        #region métodos utilizados
        private static void EncontraTresMaiores(int[] numeros, ref int maiorNumero, ref int segundoMaior, ref int terceiroMaior)
        {
            for (int i = 0; i < 10; i++)
            {
                if (numeros[i] > segundoMaior && numeros[i] < maiorNumero)
                {
                    segundoMaior = numeros[i];
                }

            }

            for (int i = 0; i < 10; i++)
            {
                if (numeros[i] > terceiroMaior && numeros[i] < maiorNumero && numeros[i] < segundoMaior)
                {
                    terceiroMaior = numeros[i];
                }
            }

            Console.WriteLine("Maior número: " + maiorNumero);
            Console.WriteLine("Segundo maior número: "+segundoMaior);
            Console.WriteLine("Terceiro maior número: "+terceiroMaior);
        }

        private static void RemoveItemDaSequencia(int[] numeros)
        {
            Console.WriteLine("Digite o indice da sequencia que você deseja remover: ");
            int indiceRemovido = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] novaSequencia = new int[9];

            if (indiceRemovido < 0 || indiceRemovido > 9)
            {
                Console.WriteLine("Este indice não existe!");
            }
            else
            {
                int indiceNovaSequencia = 0;

                for (int i = 0; i < 10; i++)
                {
                    if (i != indiceRemovido)
                    {
                        novaSequencia[indiceNovaSequencia] = numeros[i];
                        indiceNovaSequencia++;
                    }
                }

                Console.WriteLine("Nova sequência:");

                for (int i = 0; i < 9;i ++)
                {
                    Console.WriteLine(novaSequencia[i]);
                }
            }
        }

        private static void MostraValores(int[] numeros)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }

        private static void EncontraNegativos(int[] numeros)
        {
            for (int i = 0; i < 10; i++)
            {
                if (numeros[i] < 0)
                {
                    Console.WriteLine("O número " + numeros[i] + " é negativo.");
                }
            }
        }

        private static int CalculaMediaDosNumeros(int[] numeros, ref int soma)
        {
            for (int i = 0; i < 10; i++)
            {
                soma = soma + numeros[i];
            }

            int mediaDosNumeros = soma / 10;

            return mediaDosNumeros;
        }

        private static int CalculaMaiorNumero(int[] numeros, ref int maiorNumero)
        {
            for (int i = 0; i < 10; i++)
            {
                if (numeros[i] > maiorNumero)
                {
                    maiorNumero = numeros[i];
                }
            }

            return maiorNumero;
        }

        private static int CalculaMenorNumero(int[] numeros, out int menorNumero)
        {
            menorNumero = numeros[0];

            for (int i = 0; i < 10; i++)
            {
                if (numeros[i] < menorNumero)
                {
                    menorNumero = numeros[i];
                }
            }

            return menorNumero;
        }

        private static void PedeEGuardaNumeros(int aux, int[] numeros)
        {
            for (int i = 0; i < 10; i++)
            {
                aux = i + 1;
                Console.WriteLine("Digite o número " + aux + ":");
                numeros[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();

            }

        }
        #endregion

    }

}
