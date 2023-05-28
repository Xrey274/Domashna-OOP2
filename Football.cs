using System;
using System.Linq;
using System.Collections.Generic;

namespace Football
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Team> teams = new List<Team>();

            while(true)
            {
                Console.WriteLine("1. Create new team");
                Console.WriteLine("2. Add player to team");
                Console.WriteLine("3. Add coach to team");
                Console.WriteLine("4. List team members");

                int choice = Convert.ToInt32(Console.ReadLine());

                Console.Clear();


                // Пример за създаване на инстанции на играчи, треньори, отбори и мачове
                FootballPlayer player1 = new Goalkeeper { Name = "John", Age = 25, Number = 1, Height = 185.5 };
                FootballPlayer player2 = new Defender { Name = "David", Age = 28, Number = 5, Height = 175.0 };
                Coach coach1 = new Coach { Name = "Mike", Age = 45 };
                Team team1 = new Team { Name = "Manchester City", Coach = coach1, Players = new List<FootballPlayer> { player1, player2 } };

                FootballPlayer player3 = new Goalkeeper { Name = "De Gea", Age = 25, Number = 1, Height = 185.5 };
                FootballPlayer player4 = new Defender { Name = "Ronaldo", Age = 28, Number = 5, Height = 175.0 };
                Coach coach2 = new Coach { Name = "Ten Hag", Age = 45 };
                Team team2 = new Team { Name = "Manchester Utd", Coach = coach2, Players = new List<FootballPlayer> { player3, player4 } };

                Referee referee = new Referee { Name = "Andrew", Age = 35 };
                AssistantReferee assistantReferee1 = new AssistantReferee { Name = "Alice", Age = 30 };
                AssistantReferee assistantReferee2 = new AssistantReferee { Name = "Bob", Age = 32 };
                Goal goal1 = new Goal { Minute = 25, Player = player1 };
                Goal goal2 = new Goal { Minute = 60, Player = player2 };
                List<Goal> goals = new List<Goal> { goal1, goal2};

                teams.Add(team1);
                teams.Add(team2);

                switch(choice)
                {
                    case 1:
                        teams.Add(CreateTeam());
                        break;
                    case 2:
                        Console.WriteLine("Choose team: ");

                        for(int i = 0; i < teams.Count; ++i)
                            Console.WriteLine(i + " " + teams[i].Name);

                        int teamChoice = Convert.ToInt32(Console.ReadLine());

                        teams[teamChoice].AddPlayer(CreatePlayer());
                        break;
                    case 3:
                        Console.WriteLine("Choose team: ");

                        for(int i = 0; i < teams.Count; ++i)
                            Console.WriteLine(i + " " + teams[i].Name);

                        int teamChoice1 = Convert.ToInt32(Console.ReadLine());

                        Coach coach = CreateCoach();

                        teams[teamChoice1].Coach = coach;


                        break;
                    case 4:
                        Console.WriteLine("Choose team: ");

                        for(int i = 0; i < teams.Count; ++i)
                            Console.WriteLine(i + " " + teams[i].Name);

                        int teamChoice2 = Convert.ToInt32(Console.ReadLine());

                        ListMembers(teams[teamChoice2]);
                        break;
                }
            }
        }

        static Team CreateTeam()
        {
            Team team = new Team();

            Console.WriteLine("Creating new team..");
            Console.WriteLine("Name: ");
            team.Name = Console.ReadLine();

            Coach coach = CreateCoach();
            team.Coach = coach;

            int number = 0;
            Console.WriteLine("Enter number of players: ");
            number = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < number; ++i)
            {
                FootballPlayer player = new FootballPlayer();
                player = CreatePlayer();
                team.AddPlayer(player);
            } 

            return team;
        }

        static Coach CreateCoach()
        {
            Coach coach = new Coach();

            Console.WriteLine("\nCreating new Coach..");
            Console.Write("Name: ");
            coach.Name = Console.ReadLine();
            Console.Write("Age: ");
            coach.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Experience: ");
            coach.Experience = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            return coach;
        }

        static FootballPlayer CreatePlayer()
        {
            FootballPlayer player;

            Console.WriteLine("\nCreating new Player..choose position: ");
            Console.WriteLine("1. Striker");
            Console.WriteLine("2. Midfielder");
            Console.WriteLine("3. Defender");
            Console.WriteLine("4. Goalkeeper");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    player = new Striker();
                    break;
                case 2:
                    player = new Midfielder();
                    break;
                case 3:
                    player = new Defender();
                    break;
                case 4:
                    player = new Goalkeeper();
                    break;
                default:
                    player = new FootballPlayer();
                    break;
            }




            Console.Write("Name: ");
            player.Name = Console.ReadLine();
            Console.Write("Age: ");
            player.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number: ");
            player.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Height: ");
            player.Age = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            return player;
        }

        static void ListMembers(Team team)
        {
            Console.WriteLine("Team Name: " + team.Name);
            Console.WriteLine("Coach: " + team.Coach.Name);
            Console.WriteLine(" Stats: ");
            Console.WriteLine("     Age:" + team.Coach.Age);
            Console.WriteLine("     Experience: " + team.Coach.Experience);

            for(int i = 0; i < team.Players.Count; i++)
            {
                Console.WriteLine("\nPlayer " + i + " Name: " + team.Players[i].Name);
                Console.WriteLine(" Stats: ");
                Console.WriteLine("     Age: " + team.Players[i].Age);
                Console.WriteLine("     Number: " + team.Players[i].Number);
                Console.WriteLine("     Height: " + team.Players[i].Height);
                Console.WriteLine("     Position: " + team.Players[i].GetType());
            }

        }
    }
}

