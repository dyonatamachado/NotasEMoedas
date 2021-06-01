using System;

namespace NotasEMoedas
{
    class Program
    {
        static void Main(string[] args)
        {

            double valor;
            int inteiro;
            int[] notas = new int[6] { 0, 0, 0, 0, 0, 0 };
            int[] moedas = new int[6] { 0, 0, 0, 0, 0, 0 };

            double[] tiponotas = new double[6];
            tiponotas[0] = 100.00;
            tiponotas[1] = 50.00;
            tiponotas[2] = 20.00;
            tiponotas[3] = 10.00;
            tiponotas[4] = 5.00;
            tiponotas[5] = 2.00;

            double[] tipomoedas = new double[6];
            tipomoedas[0] = 1.00;
            tipomoedas[1] = 0.50;
            tipomoedas[2] = 0.25;
            tipomoedas[3] = 0.10;
            tipomoedas[4] = 0.05;
            tipomoedas[5] = 0.01;

            valor = Convert.ToDouble(Console.ReadLine());

            while (valor != 0)
            {
                if (valor >= 100)
                {
                    inteiro = (int)valor;
                    notas[0] = (int)(inteiro / 100);
                    valor -= notas[0] * 100;
                }
                else if (valor >= 50 && valor < 100)
                {
                    inteiro = (int)valor;
                    notas[1] = (int)(inteiro / 50);
                    valor -= notas[1] * 50;
                }
                else if (valor >= 20 && valor < 50)
                {
                    inteiro = (int)valor;
                    notas[2] = (int)inteiro / 20;
                    valor -= notas[2] * 20;
                }
                else if (valor >= 10 && valor < 20)
                {
                    inteiro = (int)valor;
                    notas[3] = (int)inteiro / 10;
                    valor -= notas[3] * 10;
                }
                else if (valor >= 5 && valor < 10)
                {
                    inteiro = (int)valor;
                    notas[4] = (int)inteiro / 5;
                    valor -= notas[4] * 5;
                }
                else if (valor >= 2 && valor < 5)
                {
                    inteiro = (int)valor;
                    notas[5] = (int)inteiro / 2;
                    valor -= notas[5] * 2;
                }
                else if (valor >= 1 && valor < 2)
                {
                    inteiro = (int)valor;
                    moedas[0] = (int)valor;
                    valor -= moedas[0];
                }
                else if (valor >= 0.5 && valor < 1)
                {
                    moedas[1] = (int)valor * 2;
                    valor -= moedas[1] * 0.5;
                }
                else if (valor >= 0.25 && valor < 0.5)
                {
                    moedas[2] = (int)valor * 4;
                    valor -= moedas[2] * 0.25;
                }
                else if (valor >= 0.1 && valor < 0.25)
                {
                    moedas[3] = (int)valor * 10;
                    valor -= moedas[3] * 0.1;
                }
                else if (valor >= 0.05 && valor < 0.1)
                {
                    moedas[4] = (int)valor * 20;
                    valor -= moedas[4] * 0.05;
                }
                else if (valor >= 0.01 && valor < 0.05)
                {
                    moedas[5] = (int)valor * 100;
                    valor -= moedas[5] * 0.01;
                }

            }

            Console.WriteLine("NOTAS:");

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(notas[i] + " nota(s) de R$ " + tiponotas[i].ToString("N2"));
            }

            Console.WriteLine("MOEDAS:");

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(moedas[i] + " nota(s) de R$ " + tipomoedas[i].ToString("N2"));
            }



        }
    }
}