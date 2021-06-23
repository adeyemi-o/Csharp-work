using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoshuaH_301186067_A2
{
    public class Player
    {
        // Properties:
        // Date of Birth {get; set;} : DateTime
        // Id {get;} : uint
        // Name {get; set;} : string
        public DateTime DateOfBirth { get; set; }
        public uint Id { get; }
        public string Name { get; set; }

        // Methods:
        // Player()
        public Player()
        {
            DateOfBirth = default;
            Name = "unknown";
            Id = IdGenerator.GetId();
        }
        // Player(string name, DateTime dob)
        public Player(string name, DateTime dob)
        {
            DateOfBirth = dob;
            Name = name;
            Id = IdGenerator.GetId();
        }
        // Player(string name, DateTime dob, Team team)
        public Player(string name, DateTime dob, Team team)
        {
            DateOfBirth = dob;
            Name = name;
            Id = IdGenerator.GetId();
        }
        // ToString() : string
        public override string ToString()
        {
            return $"Player Name: {Name}, ID: {Id}, DoB: {DateOfBirth}";
        }
    }
}
