using System.Collections.Generic;

namespace Football
{
    public class Team
    {
        public string Name { get; set; }
        public Coach Coach { get; set; }
        public List<FootballPlayer> Players { get; set; }

        public void AddPlayer(FootballPlayer player)
        {
            Players.Add(player);
        }

        public double GetAverageAge()
        {
            int totalAge = 0;
            foreach (FootballPlayer player in Players)
            {
                totalAge += player.Age;
            }

            return (double)totalAge / Players.Count;
        }
    }
}