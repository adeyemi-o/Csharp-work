using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoshuaH_301186067_A2
{
    public class Team
    {
        // Fields:
        // players : List<Player>
        private List<Player> players;

        // Properties:
        // Id { get; } : uint
        public uint Id { get; }
        // Name { get; set; } : string
        public string Name { get; set; }
        // Players { get; set; } : List<Player>
        public List<Player> Players { 
            get { return players; } 
            private set { players = value; } 
        }
        // Region { get; set; } : Region
        public Region Region { get; set; }

        // Constructors
        // Team()
        public Team()
        {
            // initialize the list and set the team Id
            players = new List<Player>();
            Id = IdGenerator.GetId();
        }
        // Team(string name)
        public Team(string name)
        {
            players = new List<Player>();
            Id = IdGenerator.GetId();
            Name = name;
        }
        // Team(string name, Region region)
        public Team(string name, Region region)
        {
            players = new List<Player>();
            Id = IdGenerator.GetId();
            Name = name;
            Region = region;
        }

        // Methods:
        // AddPlayer(Player aPlayer) : void
        /* The method adds a player that is provided as the argument of the 
            method to the team. Every time when a new player is added to a team the team 
            repository is saved. The team repository is represented by the TeamRepository class 
            described below.*/
        public void AddPlayer(Player aPlayer)
        {
            players.Add(aPlayer);
            // Also save the team repository
        }
        // FindPlayer(uint id) : Player
        // Return a reference to the player with the provided id, or null if not found.
        public Player FindPlayer(uint id)
        {
            foreach (Player pl in players)
            {
                if (pl.Id == id)
                {
                    return pl;
                }
            }
            // No player was found with that Id, return null
            return null;
        }
        // GetPlayers(string name) : IEnumerable<Player>
        // Return all the players with the provided name
        public IEnumerable<Player> GetPlayers(string name)
        {
            foreach (Player pl in players)
            {
                if (pl.Name == name)
                {
                    yield return pl;
                }
            }
        }
        // ToString() : string
        public override string ToString()
        {
            // TODO
            return base.ToString();
        }
    }
}
