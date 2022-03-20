using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquaria
{
    internal class Fish
    {
        String name;
        public Fish(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return name;
        }

        //Common
        Fish clownfish = new Fish("clownfish");
        Fish gobby = new Fish("gobby");
        Fish puffer = new Fish("puffer");
        //Uncommon
        Fish butterfly = new Fish("butterfly");
        Fish blueTang = new Fish("blueTang");
        Fish royalGamma = new Fish("royalGamma");
        //Rare
        Fish cardinal = new Fish("cardinal");
        Fish blueDotJawfish = new Fish("blueDotJawfish");
        //Epic
        Fish seahorse = new Fish("seahorse");
        Fish possumWrasse = new Fish("possumWrasse");
        //Legendary
        Fish lionfish = new Fish("lionfish");
        Fish mandarinDragonet = new Fish("mandarinDragonet");
    }
}
