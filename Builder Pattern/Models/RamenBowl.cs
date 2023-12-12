using MediaBrowser.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.Models
{
    /// <summary>
    /// This class represents the final bowl of ramen
    /// It should have attributes like broth, type of noodle, toppings and extras
    /// </summary>
    public class RamenBowl
    {
        // TODO#1: Add attributes for each enum in IngredientEnums.cs file
        public BrothType Broth { get; set; }
        public NoodleType Noodles { get; set; }
        public List<Topping> Toppings { get; set; } = new List<Topping>();
        public List<Extra> Extras { get; set; } = new List<Extra>();


        // Constructor to initialize the lists
        public RamenBowl()
        {
            Toppings = new List<Topping>();
            Extras = new List<Extra>();
        }

        // TODO#2: Return description of finished bowl of ramen
        public string FinishedBowlOfRamen()
        {
            StringBuilder description = new StringBuilder();
            description.AppendLine($"Bowl of Ramen with {Broth} broth and {Noodles} noodles.");

            if (Toppings.Count > 0)
                description.AppendLine("Toppings: " + string.Join(", ", Toppings));
            else
                description.AppendLine("No toppings.");

            if (Extras.Count > 0)
                description.AppendLine("Extras: " + string.Join(", ", Extras));
            else
                description.AppendLine("No extras.");

            return description.ToString();
        }
    }

}
