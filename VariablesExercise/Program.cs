namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userName = "Paralax";
            int age = 432;
            char planetNumber = '9';
            bool planetStatus = true;
            double humanDollars = 846.50;
            decimal alienDollars = 563452.36m;


            Console.WriteLine($"Hello, my name is {userName}. I am {age} years old. I am from the planet Aphla-{planetNumber}. " +
                $"Did I destroy my home planet? This is {planetStatus}. But it was an accident and now I'm looking for a hiding place on your's to " +
                $"keeping conducting my experiments. I am willing to pay {humanDollars} in human dollars or {alienDollars} in alien dollars. Thank you for " +
                $"considering my offer. With love, {userName}."); 
        
        }
    }
}
