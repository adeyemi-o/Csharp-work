using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace JoshuaH_301186067_A2
{
    public static class TeamRepository
    {
        // Fields:
        // path : string
        private const string PATH = "..\\data\\teams.json";
        // teams : List<Team>
        private static List<Team> teams = new List<Team>();

        // Properties:
        // Teams { get; } : List<Team>
        public static List<Team> Teams { get { return teams; } }

        // Methods:
        // AddTeam(Team team) : void
        /* This method adds a team that is provided as the argument to the 
            repository. Every time a team is added to the repository the 
            repository is saved as a JSON file. */
        public static void AddTeam(Team team)
        {
            teams.Add(team);
            Save();
        }
        // Load() : void
        /* This method loads the teams into the repository from a JSON file 
            specified by PATH field. */
        public static void Load()
        {
            string jsonString = File.ReadAllText(PATH);
            teams = JsonSerializer.Deserialize<List<Team>>(jsonString);
        }
        // Save() : void
        /* This method saves the teams in the repository to a JSON file specified by 
            PATH field. The file is in JSON format. */
        public static void Save()
        {
            string jsonString = JsonSerializer.Serialize(teams);
            File.WriteAllText(PATH, jsonString); // This overwrites the json file with the current value of teams.
        }
    }
}
