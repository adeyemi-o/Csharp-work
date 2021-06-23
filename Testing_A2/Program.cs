using System;
using System.Collections.Generic;
using JoshuaH_301186067_A2;

namespace Testing_A2
{
    class Program
    {
        static Random random = new Random(1);
        static void Main(string[] args)
        {
            TeamRepository.Load();
            #region AdditionalTeams
            Team team1 = new Team("Team 100");
            Team team2 = new Team("Team 101");
            TeamRepository.AddTeam(team1);
            TeamRepository.AddTeam(team2);


            Player player1 = new Player("player", new DateTime(2001, 1, 1));
            Player player2 = new Player("player", new DateTime(2002, 2, 2));
            Player player3 = new Player("player3", new DateTime(2003, 3, 3));
            Player player4 = new Player("player4", new DateTime(2004, 4, 4));
            Player player5 = new Player("player5", new DateTime(2005, 5, 5));
            Player player6 = new Player("player6", new DateTime(2006, 6, 6), team1);
            Player player7 = new Player("player7", new DateTime(2007, 7, 7), team1);
            Player player8 = new Player("player8", new DateTime(2008, 8, 8), team2);

            team1.AddPlayer(player1);
            team1.AddPlayer(player2);
            team1.AddPlayer(player3);
            team2.AddPlayer(player4);
            team2.AddPlayer(player5);

            Player foundPlayer = TeamRepository.Teams[1].FindPlayer(TeamRepository.Teams[1].Players[0].Id);
            if (foundPlayer != null)
            {
                Console.WriteLine($"Player with id {foundPlayer.Id} is {foundPlayer}");

            }
            else
            {
                Console.WriteLine("Player is not found");
            }
            foundPlayer = team1.FindPlayer(200);
            if (foundPlayer != null)
            {
                Console.WriteLine($"Player with id 200 is {foundPlayer}");

            }
            else
            {
                Console.WriteLine("Player with id 200 is not found");
            }

            IEnumerable<Player> playersWithPlayerName = team1.GetPlayers("player");
            Console.WriteLine("Players with name: player");
            foreach (var item in playersWithPlayerName)
            {
                Console.WriteLine(item);
            }
            #endregion



            foreach (Team item in TeamRepository.Teams)
            {
                Console.WriteLine(item);
            }

            RounRobinTournament rrTournament1 = new RounRobinTournament("rrTournament1");
            RounRobinTournament rrTournament2 = new RounRobinTournament("rrTournament2");
            KnockoutTournament knTournament1 = new KnockoutTournament("knTurnament1");
            KnockoutTournament knTournament2 = new KnockoutTournament("knTurnament1");

            AddTeamsToTournament(rrTournament1, 0, 5);
            rrTournament1.SetMatches();
            Console.WriteLine(rrTournament1);
            Console.WriteLine();

            Match foundMatch = rrTournament1.FindMach(TeamRepository.Teams[1],
                                                      TeamRepository.Teams[0]);
            if (foundMatch != null)
            {
                Console.WriteLine($"Match found: {foundMatch}");
            }
            else
            {
                Console.WriteLine("Match not found");
            }

            AddWinner(rrTournament1, TeamRepository.Teams[1], TeamRepository.Teams[5]);
            AddWinner(rrTournament1, TeamRepository.Teams[4], TeamRepository.Teams[3]);
            Console.WriteLine(rrTournament1);
            Console.WriteLine();

            AddTeamsToTournament(rrTournament2, 5, 9);
            rrTournament2.SetMatches();
            Console.WriteLine(rrTournament2);
            Console.WriteLine();

            AddTeamsToTournament(knTournament1, 0, 5);
            knTournament1.SetMatches();
            Console.WriteLine(knTournament1);
            Console.WriteLine();
            AddWinner(knTournament1, knTournament1.Matches[1].Teams[0], knTournament1.Matches[1].Teams[1]);
            AddWinner(knTournament1, knTournament1.Matches[2].Teams[1], knTournament1.Matches[2].Teams[0]);
            Console.WriteLine("After all matches results are entered");
            Console.WriteLine(knTournament1);
            Console.WriteLine();


            AddTeamsToTournament(knTournament2, 0, 6);
            knTournament2.SetMatches();
            Console.WriteLine(knTournament2);
            Console.WriteLine();
            AddWinner(knTournament2, knTournament2.Matches[0].Teams[1], knTournament2.Matches[0].Teams[0]);
            AddWinner(knTournament2, knTournament2.Matches[1].Teams[0], knTournament2.Matches[1].Teams[1]);
            AddWinner(knTournament2, knTournament2.Matches[2].Teams[1], knTournament2.Matches[2].Teams[0]);
            Console.WriteLine("After all results of round 1 are entered");
            Console.WriteLine(knTournament2);
            Console.WriteLine();
            AddWinner(knTournament2, knTournament2.Matches[3].Teams[1], knTournament2.Matches[3].Teams[0]);
            AddWinner(knTournament2, knTournament2.Matches[4].Teams[0], knTournament2.Matches[4].Teams[1]);
            Console.WriteLine("After all results of round 2 are entered");
            Console.WriteLine(knTournament2);
            Console.WriteLine();
        }

        private static void AddWinner(Tournament tournament, Team winner, Team looser)
        {
            tournament.AddWinner(winner, looser);
        }

        static void AddTeamsToTournament(Tournament aTurnament, int startIndex, int endIndex)
        {
            int numberOfTeams = TeamRepository.Teams.Count;

            Console.WriteLine($"Adding teams from index {startIndex} to {endIndex}");

            for (int i = startIndex; i <= endIndex; i++)
            {
                aTurnament.AddTeam(TeamRepository.Teams[i]);
            }

        }

    }
}
