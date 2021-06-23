using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoshuaH_301186067_A2
{
    public static class IdGenerator
    {
        // Fields:
        // nextId : uint
        static uint nextId = 100;

        // Methods:
        // GetId() : uint
        // returns the next unsigned integer id number. The generated id
        // has a value that is equal to previously generated id incremented by 1.
        public static uint GetId()
        {
            return ++nextId;
        }
    }
}
