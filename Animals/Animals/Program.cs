using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"What animal would you like to hear? Dog, Cat, or Pig");
            string answer = Console.ReadLine().ToLower();

            string sound = speak(answer);
            Console.WriteLine($"A {answer} makes the sound: {sound}!");
        }

        static string speak(string animal)
        {
            string sound;
            if (animal.ToLower() == "dog")
            {
                sound = "woof";
                return sound;
            }
            else if (animal.ToLower() == "cat")
            {
                sound = "meow";
                return sound;
            }
            else if (animal.ToLower() == "pig")
            {
                sound = "oink";
                return sound;
            }
            return "sound";
        }
    }
}
