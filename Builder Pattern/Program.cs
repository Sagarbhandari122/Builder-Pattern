﻿using Builder_Pattern.Builders;
using Builder_Pattern.Models;
using System;
using Builder_Pattern;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Builder_Pattern
{
    internal class Program
    {
        /// <summary>
        /// For this assignment we are going to build "Ramen Bowl Builder" that could be used to
        /// help kitchen staff assemble bowls o ramen according to customer's preference.
        /// 
        /// Instructions
        /// 
        /// In Builders folder, add new classes that inherit IRamenBuilder for following ramen recepies
        /// - MisoRamenBuilder
        ///     Recepie: 
        ///     - Broth: Miso
        ///     - Noodles: Udon
        ///     - Toppings: Green Onions
        ///     - Extras: Corn
        ///     
        /// - SpicyRamenBuilder
        ///     Recepie: 
        ///     - Broth: SpicyTonkotsu
        ///     - Noodles: Thin
        ///     - Toppings: Gashu Pork & Green Onions
        ///     - Extras: Extra Spice
        ///     
        /// - VeganRamenBuilder
        ///     Recepie: 
        ///     - Broth: Vegan
        ///     - Noodles: Soba
        ///     - Toppings: Bambo Shoots & Seaweed
        ///     - Extras: no extras
        /// 
        /// In RamenBowl.cs add attributes for each ingredient type found in the IngredientEnums.cs file
        /// And update FinishedBowlOfRamen method to return string containing all information of selected ingredients.
        /// 
        /// NOTE: Since in this assignment we are using IRamenBuilder which is interface, remeber to create the RamenBowl object
        ///       inside each ramen type builder class => private RamenBowl ramen = new RamenBowl();
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // TODO#1: Wake up your RamenChef by initializing it
            RamenChef chef = new RamenChef();

            // TODO#2: Create new RamenBuilder's for each ramen recipe (MisoRamenBuilder, SpicyRamenBuilder, VeganRamenBuilder)
            IRamenBuilder misoRamenBuilder = new MisoRamenBuilder();
            IRamenBuilder veganRamenBuilder = new VeganRamenBuilder();
            IRamenBuilder spicyRamenBuilder = new SpicyRamenBuilder();

            // TODO#3: Use your RamenChef to prepare (build) each type of ramen (Miso, Spicy, Vegan)
            RamenBowl misoRamen = chef.PrepareRamen(misoRamenBuilder);
            RamenBowl veganRamen = chef.PrepareRamen(veganRamenBuilder);
            RamenBowl spicyRamen = chef.PrepareRamen(spicyRamenBuilder);

            // TODO#4: After the RamenChef has prepared the bowl of ramen, use FinishedBowlOfRamen to get the content of
            //         the RamenBowl and print it out using WriteLine method

            Console.WriteLine("Miso Ramen:");
            Console.WriteLine(misoRamen.FinishedBowlOfRamen());

            Console.WriteLine("\nVegan Ramen:");
            Console.WriteLine(veganRamen.FinishedBowlOfRamen());

            Console.WriteLine("\nSpicy Ramen:");
            Console.WriteLine(spicyRamen.FinishedBowlOfRamen());

        }
    }
}
