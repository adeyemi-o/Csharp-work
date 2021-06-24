using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoshuaH_301186067_A2
{
    public abstract class Tournament
    {
        // Fields:
        // matches : List<Match>
        private readonly List<Match> matches;

        // Properties:
        // Matches { get; } : List<Match>
        public List<Match> Matches { get { return matches; } }
        // Name { get; set; } : string
        public string Name { get; set; }
        // Teams { get; } : List<Team>
        public List<Team> Teams { get; }

        // Constructors:
        // Tournament(string name)
        public Tournament(string name)
        {
            Name = name;
            matches = new List<Match>();
        }

        // Methods: 
        // AddTeam(Team team) : void
        public void AddTeam(Team team)
        {
            Teams.Add(team);
        }
        // AddWinner(Team winner, Team loser) : void
        public void AddWinner(Team winner, Team loser)
        {
            Match match = FindMatch(winner, loser);
            if (match != null)
            {
                match.WinningTeam = winner;
            }
        }
        // FindMatch(Team team1, Team team2) : Match
        public Match FindMatch(Team team1, Team team2)
        {
            foreach (Match match in matches)
            {
                if (match.Teams.Contains(team1) && match.Teams.Contains(team2))
                {
                    return match;
                }
            }
            return null; // no match found with those teams
        }
        // SetMatches() : void
        public abstract void SetMatches();
        // ToString() : string
        public override string ToString()
        {
            // TODO
            return base.ToString();
        }
    }
}
