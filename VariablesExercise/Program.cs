namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string favoriteVacation = "Hawaii";
            int timesVisited = 2;
            char planToGOx = '4';
            double vacationMoney = 3000;
            decimal gdp = 115627000000m;

            Console.WriteLine($"My favorite place to vacation is {favoriteVacation}. I've only visited {timesVisited}" +
                              $" times but I'm going at least {planToGOx} more you feel me!");

            Console.WriteLine($" Is it true that Hawaii has high cost of living? ");
            
            bool userAnswer = bool.Parse(Console.ReadLine());

            if (userAnswer == true)
            {
                Console.WriteLine($" Well it's a secluded island that has to pay for exports on" +
                                  $" mostly everything and they rely heavily opn tourism. That's why I'm trying to" +
                                  $" bring at least {vacationMoney} maybe a little more. Man I just looked them up" +
                                  $" on-line they has one of the lowest gpd in the country, only {gdp}.");
            }

            if (userAnswer == false)
            {
                Console.WriteLine("Well I've heard otherwise but I'm going there to see for myself!");
            }



        }
    }
}
