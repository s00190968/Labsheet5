using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueTable
{
    class Team : IComparable
    {

        private string name;
        private string nmanagerNme;
        private int points;
        private int wins;
        private int losses;
        private int draws;
        private int games;

        public Team(string name) : this(name, "Not added")
        {
            this.name = name;
            this.points = 0;
            this.wins = 0;
            this.losses = 0;
            this.draws = 0;
            this.games = 0;
        }

        public Team(string teamname, string managername)
        {
            Name = teamname;
            ManagerName = managername;
        }

        public string Name { get; private set; }
        public string ManagerName { get; private set; }
        public int Points { get; private set; }
        public int Wins { get; private set; }
        public int Losses { get; private set; }
        public int Draws { get; private set; }
        public int Games { get; private set; }

        public enum Result { Win, Draw, Lose};

        public void AddResult(Result currentResult)
        {
            switch (currentResult)
            {
                case Result.Win:
                    Wins ++;
                    Points += 3;
                    Games ++;
                    break;
                case Result.Lose:
                    Games++;
                    Losses++;
                    break;
                case Result.Draw:
                    Games++;
                    Draws++;
                    Points += 1;
                    break;
            }
        }

        public void printTeamDetails()
        {
            Console.WriteLine(string.Format("{0,20} {1,20} {2,10} {3, 10} {4, 10} {5, 10}", Name, ManagerName, Points, Wins, Losses, Draws));
        }

        int IComparable.CompareTo(object obj)
        {
            //throw new NotImplementedException();
            Team that = (Team)obj;
            return that.Points.CompareTo(this.Points);
        }
    }
}
