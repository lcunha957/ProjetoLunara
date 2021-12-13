using System;

namespace ProjetoSaqueEletronicoLunara
{
    class SaqueEletronico
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao nosso Banco: Banco Dos Sonhos");
            Console.WriteLine("Por gentileza, informe o seu nome completo:");
            string NomeDoCliente = Console.ReadLine();
            Console.WriteLine("\n" + NomeDoCliente + " \n" + "Digite um numero inteiro, sem pontos e nem virgulas, para fazer o saque: ");
            int ValorDoSaque = int.Parse(Console.ReadLine());
            Console.WriteLine("O valor do saque eh: " + ValorDoSaque);
            Console.WriteLine("Digite se deseja receber em notas de cem: (sim/nao)");
            string ReceberEmCem = Console.ReadLine();
            Console.WriteLine("Digite se deseja receber em notas de cinquenta: (sim/nao)");
            string ReceberEmCinquenta = Console.ReadLine();
            Console.WriteLine("Digite se deseja receber em notas de vinte: (sim/nao)");
            string ReceberEmVinte = Console.ReadLine();



            if (ReceberEmCem == "sim")
            {
                int DividePorCem = ValorDoSaque / 100;
                int ParteInteiraDeCem = ValorDoSaque - (DividePorCem * 100);
                int DividePorCinquenta = ParteInteiraDeCem / 50;
                int AcumulativoCinquentaECem = (DividePorCinquenta * 50) + (DividePorCem * 100);
                int ParteInteiraDeCinquenta = (ValorDoSaque) - AcumulativoCinquentaECem;
                int DividePorVinte = ParteInteiraDeCinquenta / 20;
                int ParteInteiraDeVinte = (DividePorVinte*20);
                int NotasDeCem = DividePorCem;
                int NotasDeCinquenta = (ParteInteiraDeCem / 50);
                int NotasDeVinte = (ParteInteiraDeVinte / 20);
                Console.WriteLine("Para o seu valor de saque " + ValorDoSaque  + " reais,  temos " + NotasDeCem + " notas de cem , ");
                Console.WriteLine( NotasDeCinquenta + " notas de cinquenta, " + NotasDeVinte + " notas de vinte");
                Console.WriteLine("Obrigado(a) por usar os nossos servico(s) de Banco");
                Console.WriteLine("Banco dos Sonhos agradece ao contato.");

                if (ReceberEmCem == "nao")
                {
                    DividePorCem = 0;

                    if ((ParteInteiraDeCinquenta == 0) || (NotasDeCinquenta == 0))
                    Console.WriteLine("Nao temos nota(s) de cinquenta disponiveis para o valor do saque");

                    if ((ParteInteiraDeVinte == 0) || (NotasDeVinte == 0))
                        Console.WriteLine("Nao temos nota(s) de vinte disponiveris para o valor de saque");

                }


            }


            if (ReceberEmCinquenta == "sim")
            {
                int DividePorCem = ValorDoSaque / 100;
                int ParteInteiraDeCem = ValorDoSaque - (DividePorCem * 100);
                int DividePorCinquenta = ParteInteiraDeCem / 50;
                int AcumulativoCinquentaECem = (DividePorCinquenta * 50) + (DividePorCem * 100);
                int ParteInteiraDeCinquenta = (ValorDoSaque) - AcumulativoCinquentaECem;
                int DividePorVinte = ParteInteiraDeCinquenta / 20;
                int ParteInteiraDeVinte = (DividePorVinte * 20);
                int NotasDeCem = DividePorCem;
                int NotasDeCinquenta = (ParteInteiraDeCem / 50);
                int NotasDeVinte = (ParteInteiraDeVinte / 20);
            
                
                    if (ReceberEmCinquenta == "nao")
                    { 
                        DividePorCinquenta = 0;


                        if (DividePorCem == 0)
                            Console.WriteLine("Nao temos nota(s) de cem disponiveis pára o valor do saque");

                        if ((ParteInteiraDeCinquenta == 0) || (NotasDeCinquenta == 0))
                            Console.WriteLine("Nao temos nota(s) de cinquenta disponiveis para o valor do saque");

                        if ((ParteInteiraDeVinte == 0) || (NotasDeVinte == 0))
                            Console.WriteLine("Nao temos nota(s) de vinte disponiveris para o valor de saque");

                    }



                
            }

            if (ReceberEmVinte == "sim")
            {
                int DividePorCem = ValorDoSaque / 100;
                int ParteInteiraDeCem = ValorDoSaque - (DividePorCem * 100);
                int DividePorCinquenta = ParteInteiraDeCem / 50;
                int AcumulativoCinquentaECem = (DividePorCinquenta * 50) + (DividePorCem * 100);
                int ParteInteiraDeCinquenta = (ValorDoSaque) - AcumulativoCinquentaECem;
                int DividePorVinte = ParteInteiraDeCinquenta / 20;
                int ParteInteiraDeVinte = (DividePorVinte * 20);
                int NotasDeCem = DividePorCem;
                int NotasDeCinquenta = (ParteInteiraDeCem / 50);
                int NotasDeVinte = (ParteInteiraDeVinte / 20);
   

                if (ReceberEmVinte == "nao")
                {
                    DividePorVinte = 0;

                    if (DividePorCem == 0)
                        Console.WriteLine("Nao temos nota(s) de cem disponiveis pára o valor do saque");

                    if ((ParteInteiraDeCinquenta == 0) || (NotasDeCinquenta == 0))
                        Console.WriteLine("Nao temos nota(s) de cinquenta disponiveis para o valor do saque");

                    if ((ParteInteiraDeVinte == 0) || (NotasDeVinte == 0))
                        Console.WriteLine("Nao temos nota(s) de vinte disponiveris para o valor de saque");

                }

            }
        }
    }
}
