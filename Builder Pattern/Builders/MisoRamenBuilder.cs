using Builder_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.Builders
{
    internal class MisoRamenBuilder : IRamenBuilder
    {
        private RamenBowl ramen = new RamenBowl();

        public void SetBroth()
        {
            ramen.Broth = BrothType.Miso;
        }

        public void SetNoodles()
        {
            ramen.Noodles = NoodleType.Udon;
        }

        public void AddTopping()
        {
            ramen.Toppings.Add(Topping.GreenOnions);
        }

        public void AddExtra()
        {
            ramen.Extras.Add(Extra.Corn);
        }

        public RamenBowl GetRamen()
        {
            return ramen;
        }
    }
}
