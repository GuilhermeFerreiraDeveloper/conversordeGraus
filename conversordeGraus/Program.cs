using System.Text.RegularExpressions;

namespace conversordeGraus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = 0, celsius = 0, kelvin = 0;
            int opcao;
            string novo = "";


            Console.WriteLine("deseja fazer uma converção (s / n)");
            novo = Console.ReadLine().ToLower();

            while (novo == "s")
            {

                Console.WriteLine("Escolha a opção");
                Console.WriteLine("1 | Converter de Celsius");
                Console.WriteLine("2 | Converter de Fahrenheit");
                Console.WriteLine("3 | Converter de Kelvin");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {

                    case 1:
                        Console.WriteLine("Entre com o valor de Celsius para conversão");
                        celsius = Convert.ToInt32(Console.ReadLine());

                        fahrenheit = (celsius * 1.8) + 32;
                        kelvin = celsius + 273.15;
                        Console.WriteLine("Valor em Fahrenheit: " + fahrenheit + "\n" +
                                          "Valor em Kelvin: " + kelvin
                        );
                        break;
                    case 2:
                        Console.WriteLine("Entre com o valor de Fahrenheit para conversão");
                        fahrenheit = Convert.ToInt32(Console.ReadLine());

                        celsius = (fahrenheit - 32) * 1.8;
                        kelvin = (fahrenheit + 459.67) * 1.8;

                        Console.WriteLine("Valor em Celsius: " + celsius + "\n" +
                                          "Valor em Kelvin: " + kelvin
                        );
                        break;
                    case 3:
                        Console.WriteLine("Entre com o valor de Kelvin para conversão");
                        kelvin = Convert.ToInt32(Console.ReadLine());

                        celsius = kelvin - 273.15;
                        fahrenheit = (kelvin * 1.8) - 459.67;

                        Console.WriteLine("Valor em Celsius: " + celsius + "\n" +
                                          "Valor em Fahrenheit: " + fahrenheit
                        );
                        break;

                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}