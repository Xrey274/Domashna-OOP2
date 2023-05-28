using System;
using System.Collections.Generic;

namespace Football
{
    public class Referee : Person { }

    public class Game
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public List<AssistantReferee> AssistantReferees { get; set; }
        public List<Goal> Goals { get; set; }
        public string Result { get; set; }
        public Team Winner { get; set; }
    }

    public class Goal
    {
        public int Minute { get; set; }
        public FootballPlayer Player { get; set; }
    }

    public class AssistantReferee : Person { }
}