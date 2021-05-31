using System;

namespace Poo
{
    class Program
    {
        static void Main(string[] args)
        {
            telefone motog = new telefone();
            bool retorno = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($@"
______________________________
|  ________________________  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |   Digite o numero    |  |
|  |                      |  |
|  |         '1'          |  |
|  |                      |  |
|  | para ligar o celular |  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |______________________|  |
|             []             |
|____________________________|
                ");

                int respotaL = int.Parse(Console.ReadLine());

                switch (respotaL)
                {
                    case 1:
                        motog.Ligar();
                        if (motog.ligado == true)
                        {


                            retorno = false;
                            Console.WriteLine($@"
______________________________
|  ________________________  |
|  |                      |  |
|  |   Digite o numero    |  |
|  |                      |  |
|  |         '1'          |  |
|  |                      |  |
|  | para Enviar mensagem |  |
|  |                      |  |
|  |         '2'          |  |
|  |                      |  |
|  |    para Fazer uma    |  |
|  |        ligaçao       |  |
|  |                      |  |
|  |         '3'          |  |
|  |                      |  |
|  |     para desligar    |  |
|  |                      |  |
|  |______________________|  |
|             []             |
|____________________________|
                ");
                            bool retornarW = false;
                            do
                            {


                                int respostab = int.Parse(Console.ReadLine());
                                if (respostab == 1)
                                {

                                    Console.ForegroundColor = ConsoleColor.Green;

                                    Console.WriteLine($@"
______________________________
|  ________________________  |
|  |                      |  |
|  |  Whatsapp Premium 2  |  |
|  | ____________________ |  |
|  |  Contatos            |  |
|  | ____________________ |  |
|  |                      |  |
|  |  Mãe                 |  |
|  |  (11)98343513        |  |
|  |  Pai                 |  |
|  |  (11)93244592        |  |
|  |  Vô                  |  |
|  |  (11)97743345        |  |
|  |______________________|  |
|             []             |
|____________________________|
                ");
                                    Console.WriteLine("Escolha um contato");
                                    string contato = Console.ReadLine();
                                    switch (contato)
                                    {
                                        case "Mãe":
                                            Console.WriteLine(motog.Enviarmsg());
                                            Console.WriteLine("VAI LAVA A LOÇA");
                                            retorno = true;
                                            break;
                                        case "Pai":
                                            Console.WriteLine(motog.Enviarmsg());
                                            Console.WriteLine($@"ok");
                                            retorno = true;
                                            break;
                                        case "Vô":
                                            Console.WriteLine(motog.Enviarmsg());
                                            Console.WriteLine("Amem netinho(a) ");
                                            retorno = true;
                                            break;
                                        default:
                                            retorno = true;
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("DIGITE UMA OPÇÃO VALIDA");
                                            Console.ResetColor();
                                            break;
                                    }
                                }
                                else if (respostab == 2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    motog.Fazerligação();
                                    Console.WriteLine($@"
______________________________
|  ________________________  |
|  |                      |  |
|  |  Ligação             |  |
|  | ____________________ |  |
|  |  Contatos            |  |
|  | ____________________ |  |
|  |                      |  |
|  |  Mãe                 |  |
|  |  (11)912345678       |  |
|  |  Pai                 |  |
|  |  (11)987654321       |  |
|  |  Vô                  |  |
|  |  (11)98675431        |  |
|  |______________________|  |
|             []             |
|____________________________|
                ");
                                    Console.WriteLine("Escolha um contato");
                                    string contato = Console.ReadLine();
                                    switch (contato)
                                    {
                                        case "Mãe":
                                            Console.WriteLine(motog.Fazerligação());
                                            Console.WriteLine($@"
______________________________
|  ________________________  |
|  |                      |  |
|  |______________________|  |
|  |         Mãe          |  |
|  |______________________|  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |      Chamando...     |  |
|  |                      |  |
|  |     (pipipi)         |  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |______________________|  |
|             []             |
|____________________________|
                ");
                                            retorno = true;
                                            break;
                                        case "Pai":
                                            Console.WriteLine(motog.Fazerligação());
                                            Console.WriteLine($@"
______________________________
|  ________________________  |
|  |                      |  |
|  |______________________|  |
|  |         Pai          |  |
|  |______________________|  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |      Chamando...     |  |
|  |                      |  |
|  |     (pipipi)         |  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |______________________|  |
|             []             |
|____________________________|
                ");
                                            retorno = true;
                                            break;
                                        case "Vô":
                                            Console.WriteLine(motog.Fazerligação());
                                            Console.WriteLine($@"
______________________________
|  ________________________  |
|  |                      |  |
|  |______________________|  |
|  |          Vô          |  |
|  |______________________|  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |      Chamando...     |  |
|  |                      |  |
|  |     (pipipi)         |  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |______________________|  |
|             []             |
|____________________________|
                ");
                                            retorno = true;
                                            break;


                                        default:
                                            retorno = true;
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("DIGITE UMA OPÇÃO VALIDA");
                                            Console.ResetColor();
                                            break;
                                    }
                                }
                                else if (respostab == 3)
                                {
                                    motog.Desligar();
                                    Console.WriteLine("O Celular foi desligado");
                                    retorno = true;

                                }
                                else
                                {
                                    retorno = true;
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("DIGITE UMA OPÇÃO VALIDA");
                                    Console.ResetColor();
                                }
                            } while (retornarW);
                        }
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("DIGITE UMA OPÇÃO VALIDA");
                        Console.ResetColor();
                        retorno = true;
                        break;
                }
            } while (retorno);

        }
    }
}
