using System.Collections.Generic;

namespace WebTavern.Models
{
    public class Initializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<TavernContext>
    {
        protected override void Seed(TavernContext context)
        {
            var drinks = new List<Drink>
            {
            new Drink{Name="Water",Rating = 5},
            new Drink{Name="Tea",Rating = 3.5},
            new Drink{Name="Coffee",Rating = 2.5},
            new Drink{Name="Wine",Rating = 5},
            new Drink{Name="Bud",Rating = 5},
            new Drink{Name="Juice",Rating = 5}
            };

            drinks.ForEach(s => context.Drinks.Add(s));
            context.SaveChanges();
        }
    }
}