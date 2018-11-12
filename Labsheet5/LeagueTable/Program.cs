using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Team[] teams = new Team[5];

            Team SligoRovers = new Team("Sligo  Rovers");
            Team FinnHarps = new Team("Finn  Harps");
            Team GalwayUnited = new Team("Galway  United");
            Team DerryCity = new Team("Derry  City");
            Team Dundalk = new Team("Dundalk");

            teams[0] = SligoRovers;
            teams[1] = FinnHarps;
            teams[2] = GalwayUnited;
            teams[3] = DerryCity;
            teams[4] = Dundalk;

            printTeamsdetails(teams);

            SligoRovers.AddResult(Team.Result.Win);
            FinnHarps.AddResult(Team.Result.Lose);
            FinnHarps.AddResult(Team.Result.Draw);
            GalwayUnited.AddResult(Team.Result.Win);
            Dundalk.AddResult(Team.Result.Lose);

            printTeamsdetails(teams);

            Array.Sort(teams);

            printTeamsdetails(teams);

        }

        public static void printTeamsdetails(Team[] teams)
        {
            Console.WriteLine(string.Format("{0,20} {1,20} {2,10} {3, 10} {4, 10} {5, 10}", "Team name:", "Manager:", " Points:", "Wins:", "Losses:", "Draws:"));
            Console.WriteLine();
            foreach (Team team in teams)
            {
                team.printTeamDetails();
            }
            Console.WriteLine("\n");
        }
    }
}
