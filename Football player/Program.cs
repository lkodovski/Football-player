// Exercise 3: Football player
using System;

namespace Classes
{
    public class Player
    {
        public string Name;
        public string Team;

        public void Score(string opponent, int goals)
        {
            Console.WriteLine($"{Name} from {Team} scored {goals} goal(s) against {opponent}!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player();
            player.Name = "Stefan";
            player.Team = "Vardar";
            player.Score("Shkendija", 2);
        }
    }
}