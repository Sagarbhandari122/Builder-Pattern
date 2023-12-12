using Builder_Pattern.Models;
using MediaBrowser.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.Builders
{
    internal class VeganRamenBuilder : IRamenBuilder
    {

        private RamenBowl ramen = new RamenBowl();

        public void SetBroth()
        {
            ramen.Broth = BrothType.Vegan;
        }

        public void SetNoodles()
        {
            ramen.Noodles = NoodleType.Soba;
        }

        public void AddTopping()
        {
            ramen.Toppings.Add(Topping.BambooShoots);
            ramen.Toppings.Add(Topping.Seaweed);
        }

        public void AddExtra()
        {
            // For VeganRamenBuilder, there are no extras
            ramen.Extras = new List<Extra>();
        }

        public RamenBowl GetRamen()
        {
            return ramen;
        }
    }
}
