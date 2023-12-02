﻿using System;
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
        // - Setting noodles
        // - Adding toppings
        // - Adding Extras

        /// <summary>
        /// Returns the value of build RamenBowl
        /// </summary>
        /// <returns></returns>
        RamenBowl GetRamen();
    }
}
