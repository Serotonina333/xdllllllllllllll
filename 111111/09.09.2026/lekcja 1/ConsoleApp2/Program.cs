namespace kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {


                Console.WriteLine("Podaj 1 liczbę:");

                double liczba1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Podaj działanie");
                string znak = Console.ReadLine();

                Console.WriteLine("Podaj 2 liczbę:");

                double liczba2 = Convert.ToDouble(Console.ReadLine());

                double wynik = 0;


                switch (znak)
                {
                    case "+":
                        wynik = liczba1 + liczba2;
                        break;
                    case "-":
                        wynik = liczba1 - liczba2;
                        break;
                    case "*":
                        wynik = liczba1 * liczba2;
                        break;
                    case "/":
                        if (liczba2 == 0)
                            throw new Exception("dzielenie przez 0");
                        wynik = liczba1 / liczba2;
                        break;
                        
                    default:

                        break;
                }
                Console.WriteLine("wynik: " + wynik);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

                


            Console.ReadLine();
        }
    }
}
