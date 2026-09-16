namespace lekcja_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string imie;

            Console.WriteLine("Podaj imię:");
            imie = Console.ReadLine();

            string nazwisko;

            Console.WriteLine("Podaj nazwisko:");
            nazwisko = Console.ReadLine();

            string wiek;

            Console.WriteLine("Podaj wiek:");
            wiek = Console.ReadLine();

            string wyksztalcenie;

            Console.WriteLine("Podaj wyksztalcenie:");
            wyksztalcenie = Console.ReadLine();

            Console.WriteLine("Witaj: " + imie + nazwisko + "\n" + "twój wiek to:" + wiek + "\n" + "twoje wykształcenie to:" + wyksztalcenie);
             

            Console.ReadKey();
        }
    }
}
