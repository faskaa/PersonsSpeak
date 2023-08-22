namespace ConsoleApp1
{
    public interface IPerson
    {
        public void Speak();
                      
    }
    
    public class RussianPerson : IPerson
    {
        public void Speak()
        {
            Console.WriteLine("Здравствуйте");
        }
    }
    public class FrenchPerson : IPerson 
    {
        public void Speak()
        {
            Console.WriteLine("Bonjour");
        }
    }
    public class SpanishPerson : IPerson
    {
        public void Speak()
        {
            Console.WriteLine("Hola");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}