using System;

namespace ListExample
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Cliente c1 = new Cliente();
            int menuchoice = 0;

            while (menuchoice != 4)
            {

                Console.WriteLine("MENU");
                Console.WriteLine("Escolha uma das opcoes abaixo: \n");

                Console.WriteLine("1. Add");

                Console.WriteLine("2. Show list");

                Console.WriteLine("3. Remove");

                Console.WriteLine("4. Exit \n");



                menuchoice = int.Parse(Console.ReadLine());

                switch (menuchoice)
                {
                    case 1:
                        Console.WriteLine("*********** add ***********");
                        c1.Add();
                        Console.Clear();

                        break;
                    case 2:
                        Console.WriteLine("*********** SHOW ***********");
                        c1.showList();
                        Console.ReadKey();
                        Console.Clear();
                        break;
					case 3:
						Console.WriteLine("*********** remove ***********");
						c1.Remove();
                        Console.Clear();
						break;

                    case 4:
                        break;
                    default:
                        Console.WriteLine("Digite uma opcao valida!");
                        break;
                }
            }

        }
    }
}
