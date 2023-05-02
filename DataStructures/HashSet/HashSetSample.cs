using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.HashSet
{
    public class HashSetSample
    {
        public HashSetSample() { }
        public HashSet<int> CreateHashSet(int[] nums)
        {
            HashSet<int> myHash = new HashSet<int>(nums.Length);
            return myHash;
        }
        
    }
}
