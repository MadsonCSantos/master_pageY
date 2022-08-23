  class ProgramaName
        {
            static void main(string[] args)
            {
                Console.WriteLine("Qual seu nome?");
                var name = Console.ReadLine();
                var currentDate = DateTime.Now;
                Console.WriteLine($"{Environment.NewLine}Oi, {name}, hoje é {currentDate}");
                Console.Write($"{Environment.NewLine}Precione qualquer butão para sair!");
                Console.ReadKey(true);
            }
        }