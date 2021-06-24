using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoshuaH_301186067_A2
{
    public class RounRobinTournament : Tournament
    {
        // Constructor:
        // RounRobinTournament(string name)
        public RounRobinTournament(string name) : base(name) { }

        // Methods:
        // SetMatches() : void
        /* This method will create all matches that will be played in the round-robin
            tournament. In round-robin tournament every team plays all other teams once. */
        public override void SetMatches()
        {
            // ROUND ROBIN STYLE
            // Here we need to set the matches so that 
            // every team in the Tournament faces off 
            // against every other team in that tournament.
            // Example Output: 3 team tournament.
            // Created Matches should be:
            // Team1 vs Team2, Team1 vs Team3, Team2 vs Team3
            // TODO
        }
    }
}
