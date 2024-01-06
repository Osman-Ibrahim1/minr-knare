namespace minräknare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Välkommen: ");
            Miniräknare miniräknare = new Miniräknare();

            try
            {
                Console.Write("Ange det första numret: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ange det andra numret: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ange operationen (+, -, *, /): ");
                char operation = Convert.ToChar(Console.ReadLine());

                double resultat = 0;

                switch (operation)
                {
                    case '+':
                        resultat = miniräknare.Addera(num1, num2);
                        break;
                    case '-':
                        resultat = miniräknare.Subtrahera(num1, num2);
                        break;
                    case '*':
                        resultat = miniräknare.Multiplicera(num1, num2);
                        break;
                    case '/':
                        resultat = miniräknare.Dividera(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Ogiltig operation.");
                        return;
                }

                Console.WriteLine($"Resultat: {resultat}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ogiltig inmatning. Ange giltiga nummer.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Fel: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ett oväntat fel inträffade: {ex.Message}");
            }

        }
    }
}