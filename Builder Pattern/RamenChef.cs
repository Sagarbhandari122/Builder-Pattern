using Builder_Pattern.Builders;
using Builder_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    public class RamenChef
    {
        public RamenBowl PrepareRamen(IRamenBuilder builder)
        {
            //TODO#1: Call each builder step declared in RamenBuilder class
            builder.SetBroth(); // Example: Set the broth type
            builder.SetNoodles(); // Example: Set the noodle type
            builder.AddTopping(); // Example: Add a topping
            builder.AddExtra(); // Example: Add an extra

            return builder.GetRamen(); //TODO#2: Finaly return build bowl of ramen
        }
    }
}
