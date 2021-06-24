using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoshuaH_301186067_A2
{
    public class KnockoutTournament : Tournament
    {
        // Fields:
        // availableTeams : List<Team>
        private List<Team> availableTeams;
        // noOfMatches : int
        private int noOfMatches;
        // random : Random
        private Random random;

        // Constructor:
        // KnockoutTournament(string name)
        public KnockoutTournament(string name) : base(name) 
        {
            random = new Random(1); // using seed 1 as stated in the assignment instructions
        }

        // Methods:
        // AddWinner(Team winner, Team loser) : void
        /* The method will set the winner of the match with provided teams.
            The winning team is added to avalableTeams list. If all available matches
            in the tournament are finished and there are more rounds that need to 
            be played, the new round of matches is set by calling the SetMatches method. */
        public override void AddWinner(Team winner, Team loser)
        {
            Match match = FindMatch(winner, loser);
            if (match != null) // only do things if we actually find a match.
            {
                match.WinningTeam = winner;
                availableTeams.Add(winner); // add winner to availableTeams
                bool noPlayableMatches = true;
                foreach (Match m in matches) // Check to see if match is finished
                {
                    noPlayableMatches = noPlayableMatches && m.Finished; // This compares our bool with each match state. If ANY of the matches aren't finished, it comes out false.
                }
                // Now check if we need to play more matches still
                if(noPlayableMatches)
                {
                    SetMatches();
                }
            }
        }
        // SetMatches() : void
        /* The method sets the new round of matches. It randomly matches 
            the teams. If there is odd number of available teams for the round the team that is left 
            after all other available teams are matched up will automatically advance to the next 
            round. */
        public override void SetMatches()
        {
            // TODO
        }
    }
}
