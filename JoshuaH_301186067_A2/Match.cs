using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoshuaH_301186067_A2
{
    public class Match
    {
        // Fields:
        // finished : bool
        private bool finished;
        // teams : Team[]
        private Team[] teams;
        // winningTeam : Team
        private Team winningTeam;

        // Properties:
        // Finished { get; } : bool
        public bool Finished 
        { 
            get
            {
                if (winningTeam != null) { finished = true; }
                else { finished = false; }
                return finished;
            } 
        }
        // MatchNumber { get; set; } : int
        public int MatchNumber { get; set; }
        // Teams { get; } : Team[]
        public Team[] Teams { get { return teams; } }
        // WinningTeam { get; set; } : Team
        public Team WinningTeam { get { return winningTeam; } set { winningTeam = value; } }

        // Constructor:
        // Match(int number, Team team1, Team team2)
        public Match(int number, Team team1, Team team2)
        {
            MatchNumber = number;
            teams = new Team[2];
            teams[0] = team1;
            teams[1] = team2;
            winningTeam = null;
        }

        // ToString() : string
        public override string ToString()
        {
            string finishStr;
            if (finished) { finishStr = "finished"; }
            else { finishStr = "not finished"; }
            return $"{teams[0].Name}:{teams[1].Name} {finishStr}, Winner: {winningTeam}";
        }
    }
}
