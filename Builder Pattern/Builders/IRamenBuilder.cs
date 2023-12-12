using Builder_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.Builders
{
    /// <summary>
    /// This is an interface represeting the steps to build the ramen bowl
    /// </summary>
    public interface IRamenBuilder
    {
        // TODO#1: Add methods for following steps
        // - Setting broth
        void SetBroth();
        // - Setting noodles
        void SetNoodles();
        // - Adding toppings
        void AddTopping();
        // - Adding Extras
        void AddExtra();
        /// <summary>
        /// Returns the value of build RamenBowl
        /// </summary>
        /// <returns></returns>
        RamenBowl GetRamen();
    }
}
