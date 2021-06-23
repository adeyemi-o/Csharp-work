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
            get { return this.players; } 
            private set { players = value; } 
        }
        // Region { get; set; } : Region
        public Region Region { get; set; }

        // Methods:
        // AddPlayer(Player aPlayer) : void
        // FindPlayer(uint id) : Player
        // GetPlayers(string name) : IEnumerable<Player>
        // Team()
        public Team()
        {
            // initialize the list and set the team Id
            this.players = new List<Player>();
            Id = IdGenerator.GetId();
        }
        // Team(string name)
        public Team(string name)
        {

        }
        // Team(string name, Region region)
        public Team(string name, Region region)
        {

        }
        // ToString() : string
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
