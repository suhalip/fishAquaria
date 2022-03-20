using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquaria
{
    internal class FishList
    {
        List<Fish> fishList;
        public FishList()
        {
            fishList = new List<Fish>();
        }
        public void AddFish(Fish fishType)
        {
            fishList.Add(fishType);
        }

        public void RemoveFish(Fish fishType)
        {
            fishList.Remove(fishType);
        }
    }
}
