using System.Globalization;
using System.IO.Pipes;
using System.Security.Claims;

namespace ListaExerciciosAcademia
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //EXERCÍCIO 1
            /* 
            double a, b, result;
            Console.Write("Digite o primeiro valor: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            b = double.Parse(Console.ReadLine());
            result = (a + b) / 2;
            Console.WriteLine("Média aritmética: " + result);
            */




            //EXERCÍCIO 2
            /*
            double a, b, c, d, result;
            Console.Write("Digite o primeiro valor: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro valor: ");
            c = double.Parse(Console.ReadLine());
            Console.Write("Digite o quarto valor: ");
            d = double.Parse(Console.ReadLine());
            result = (a + b + c + d) / 4;
            Console.WriteLine("Média aritmética: " + result);
            */




            //EXERCÍCIO 3
            /*
            int a, b;
            a = 10;
            b = 20;
            Console.WriteLine("A: " + a);
            Console.WriteLine("B: " + b);
            a = 20;
            b = 10;
            Console.WriteLine("A: " + a);
            Console.WriteLine("B: " + b);
            */



            //EXERCÍCIO 4
            /*
            int d, m, a;
            Console.WriteLine("Digite um dia: ");
            d = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um mês: ");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um ano: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine(a + "" + m + "" + d);
            int ano2;
            ano2 = a % 100;
            Console.WriteLine(ano2 + "" + m + "" + d);
            */



            //EXERCÍCIO 5
            /*
            double dist, gas;
            Console.WriteLine("Digite a distância percorrida: ");
            dist = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite quantos litros de combustível foram utilizados: ");
            gas = double.Parse(Console.ReadLine());
            double result = dist / gas;
            Console.WriteLine("Consumo (KM/L): "+ result.ToString("f2"));
            */

            //EXERCÍCIO 6 - Não finalizado
            /*
            int a, b;
            */



            //EXERCÍCIO 7
            /*
            int num, vendas, porcent;
            double salario;
            Console.WriteLine("Digite o número do vendedor: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o salário fixo do vendedor: ");
            salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o total de vendas efetuadas pelo vendedor: ");
            vendas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o percentual ganho pelo vendedor em cima das vendas: ");
            porcent = int.Parse(Console.ReadLine());

            double salarioFinal = (((double)porcent / 100) * vendas) + salario;
            Console.WriteLine("Número do funcionário: " + num);
            Console.WriteLine("Salário final do funcionário: " + salarioFinal.ToString("f2"));
            */


            //EXERCÍCIO 8
            /*
            double c, f;
            Console.WriteLine("Digite a temperatura em Celsius: ");
            c = double.Parse(Console.ReadLine());
            f = ((9 * c) + 160) / 5;
            Console.WriteLine("Temperatura convertida: " + f.ToString("f1"));
            */

            //EXERCÍCIO 9
            /*
            double prod, entrada, parcelas, aux;
            Console.WriteLine("Digite o valor da mercadoria: ");
            prod = double.Parse(Console.ReadLine());

            aux = prod % 3;
            entrada = ((prod - aux) / 3) + aux;
            parcelas = (prod - aux) / 3;
            Console.WriteLine("\n");
            Console.WriteLine("Valor digitado: " + prod.ToString("C"));
            Console.WriteLine("Entrada: " + entrada.ToString("C"));
            Console.WriteLine("Duas parcelas de: " + parcelas.ToString("C"));
            */



            //EXERCÍCIO 10
            /*
            int entrada;
            int nota1 = 0, nota2 = 0, nota5 = 0, nota10 = 0, nota20 = 0, nota50 = 0, nota100 = 0;
            Console.WriteLine("Digite um valor para sacar: ");
            entrada = int.Parse(Console.ReadLine());
            double sacado = entrada;

            if (entrada >= 100)
            {

                nota100 = entrada / 100;
                entrada = entrada - (100 * nota100);

            }
            if (entrada >= 50)
            {

                nota50 = entrada / 50;
                entrada = entrada - (50 * nota50);

            }
            if (entrada >= 20)
            {

                nota20 = entrada / 20;
                entrada = entrada - (20 * nota20);

            }
            if (entrada >= 10)
            {

                nota10 = entrada / 10;
                entrada = entrada - (10 * nota10);

            }
            if (entrada >= 5)
            {

                nota5 = entrada / 5;
                entrada = entrada - (5 * nota5);

            }
            if (entrada >= 2)
            {

                nota2 = entrada / 2;
                entrada = entrada - (2 * nota2);

            }
            if (entrada >= 1)
            {

                nota1 = entrada / 1;
                entrada = entrada - (1 * nota1);
            }

            Console.WriteLine("Valor sacado: " + sacado.ToString("C"));
            Console.WriteLine("Quantidade de notas de R$100: " + nota100);
            Console.WriteLine("Quantidade de notas de R$50: " + nota50);
            Console.WriteLine("Quantidade de notas de R$20: " + nota20);
            Console.WriteLine("Quantidade de notas de R$10: " + nota10);
            Console.WriteLine("Quantidade de notas de R$5: " + nota5);
            Console.WriteLine("Quantidade de notas de R$2: " + nota2);
            Console.WriteLine("Quantidade de notas de R$1: " + nota1);
            */

            //EXERCÍCIO 11
            /*
            int eleitores, votosBrancos, votosNulos, votosValidos;
            double tot = 0;
            Console.Write("Digite a quantidade de eleitores: ");
            eleitores = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de votos brancos: ");
            votosBrancos = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de votos nulos: ");
            votosNulos = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de votos válidos: ");
            votosValidos = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            if (votosBrancos + votosNulos + votosValidos != eleitores)
            {

                Console.WriteLine("Quantidade de votos incompatíveis com a quantidade de eleitores.");

            }
            else
            {

                Console.WriteLine("Quantidade de eleitores: " + eleitores);
                tot = ((double)votosBrancos / eleitores) * 100;
                Console.WriteLine("Porcentagem de votos brancos: " + tot.ToString("f1") + "%");
                tot = ((double)votosNulos / eleitores) * 100;
                Console.WriteLine("Porcentagem de votos nulos: " + tot.ToString("f1") + "%");
                tot = ((double)votosValidos / eleitores) * 100;
                Console.WriteLine("Porcentagem de votos válidos: " + tot.ToString("f1") + "%");

            }
            */


            //EXERCÍCIO 12
            /*
            double kmTot, kmInicio, kmFinal, combust, recebido, mediaConsumo, lucroDiario;
            Console.Write("Quilometragem no começo do dia: ");
            kmInicio = double.Parse(Console.ReadLine());
            Console.Write("Quilometragem no final do dia: ");
            kmFinal = double.Parse(Console.ReadLine());
            Console.Write("Quantidade de combustível gasto (em litros): ");
            combust = double.Parse(Console.ReadLine());
            Console.Write("Valor recebido pelos passageiros: R$ ");
            recebido = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("----------------Resultado----------------");

            kmTot = kmFinal - kmInicio;
            mediaConsumo = kmTot / combust;
            lucroDiario = recebido - (combust * 6.90);

            Console.WriteLine("Consumo: " + mediaConsumo.ToString("f1") + "km/l");
            if (lucroDiario > 0)
            {

                Console.WriteLine("Lucro: " + lucroDiario.ToString("C"));

            }
            else {

                Console.WriteLine("Prejuízo: " + lucroDiario.ToString("C"));
            
            }
            */


            //EXERCÍCIO 13
            /*
            double salarioMin, precoCusto, bicicletaVendidas, salarioFinal, valorBicicleta;
            Console.Write("Salário mínimo: ");
            salarioMin = double.Parse(Console.ReadLine());
            Console.Write("Preço de custo de uma bicicleta: ");
            precoCusto = double.Parse(Console.ReadLine());
            Console.Write("Quantidade de bicicletas vendidas: ");
            bicicletaVendidas = double.Parse(Console.ReadLine());

            salarioMin = salarioMin * 2;
            valorBicicleta = (precoCusto / 0.5);
            double comissao = (precoCusto / 0.15) * bicicletaVendidas;
            salarioFinal = salarioMin + comissao + (bicicletaVendidas*valorBicicleta);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Salário final do funcionário: " + salarioFinal);
            */



        }
    }
}