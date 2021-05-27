using System;

namespace Quest
{
    public class Prize
    {
        private string _text;

        public Prize(string text) 
        {
            _text = text;
        }

        public void Showprize(Adventurer player) 
        {
            if(player.Awesomeness > 0)
            {
                for (int i = 0; i < player.Awesomeness - 1; i++) {
                    Console.Write($"{_text}");
                }
            }
                else
                {
                    Console.WriteLine("You LOOOOOSE");
        }
        }

    }
}