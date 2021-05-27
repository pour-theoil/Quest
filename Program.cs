using System;
using System.Collections.Generic;
using System.Linq;


// Every class in the program is defined within the "Quest" namespace
// Classes within the same namespace refer to one another without a "using" statement
namespace Quest
{
    class Program
    {
        static void Adventuregame()
        {
            Console.Clear();
            // Create a few challenges for our Adventurer's quest
            // The "Challenge" Constructor takes three arguments
            //   the text of the challenge
            //   a correct answer
            //   a number of awesome points to gain or lose depending on the success of the challenge
            Challenge twoPlusTwo = new Challenge("2 + 2?", 4, 10);
            Challenge theAnswer = new Challenge(
                "What's the answer to life, the universe and everything?", 42, 25);
            Challenge whatSecond = new Challenge(
                "What is the current second?", DateTime.Now.Second, 50);

            int randomNumber = new Random().Next() % 10;
            Challenge guessRandom = new Challenge("What number am I thinking of?", randomNumber, 25);

            Challenge favoriteBeatle = new Challenge(
                @"Who's your favorite Beatle?
    1) John
    2) Paul
    3) George
    4) Ringo
",
                4, 20
            );
            Challenge coffee = new Challenge(
                @"What goes in coffee?
    1) Nothing
    2) Cream
    3) Sugar

", 1, 40);
            Challenge nss = new Challenge(
                @"Is NSS fun?
    1) Yah
    2) Nah
    3) Sugar

", 3, 50);
            Challenge ocean = new Challenge(
                @"What is the best Ocean?
    1) Atlantic
    2) Pacific
    3) Indian
    4) Artic

", 4, 20);
            

            // "Awesomeness" is like our Adventurer's current "score"
            // A higher Awesomeness is better

            // Here we set some reasonable min and max values.
            //  If an Adventurer has an Awesomeness greater than the max, they are truly awesome
            //  If an Adventurer has an Awesomeness less than the min, they are terrible
            int minAwesomeness = 0;
            int maxAwesomeness = 100;


            Robe discription = new Robe();
            //  
            discription.Length = 30;

            Console.Write($"What is your name adventurer? ");
            string adventurename = Console.ReadLine();
            // Make a new "Adventurer" object using the "Adventurer" class
            Adventurer theAdventurer = new Adventurer(adventurename, discription);

            theAdventurer.GetDescription();

            int randomint()
            {
                int i = new Random().Next() % 10;
                return i;
            }
            // A list of challenges for the Adventurer to complete
            // Note we can use the List class here because have the line "using System.Collections.Generic;" at the top of the file.
            Dictionary<Challenge, int> challenges = new Dictionary<Challenge, int>();
            challenges.Add(twoPlusTwo, randomint());
            challenges.Add(theAnswer, randomint());
            challenges.Add(whatSecond, randomint());
            challenges.Add(favoriteBeatle, randomint());
            challenges.Add(coffee, randomint());
            challenges.Add(nss, randomint());
            challenges.Add(ocean, randomint());

            var sorted = from pair in challenges
                 orderby pair.Value descending
                 select pair;
            int i =0;
            // Loop through all the challenges and subject the Adventurer to them
            foreach (var challenge in sorted)
            {
                if (i < 4)
                {

                challenge.Key.RunChallenge(theAdventurer);
                }
                i++;
            }

            // This code examines how Awesome the Adventurer is after completing the challenges
            // And praises or humiliates them accordingly
            if (theAdventurer.Awesomeness >= maxAwesomeness)
            {
                Console.WriteLine("YOU DID IT! You are truly awesome!");
            }
            else if (theAdventurer.Awesomeness <= minAwesomeness)
            {
                Console.WriteLine("Get out of my sight. Your lack of awesomeness offends me!");
            }
            else
            {
                Console.WriteLine("I guess you did...ok? ...sorta. Still, you should get out of my sight.");
            }

        }
        static void Main(string[] args){
            Adventuregame();

            Console.WriteLine("This game is fun would you like to play again?!?");
            Console.Write("Y or N: ");
            string answer = Console.ReadLine().ToLower();
            if (answer == "y")
            {
                Adventuregame();
            }
   
        }
    }
}
