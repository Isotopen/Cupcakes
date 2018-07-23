using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using eatacupcake13.Models;

namespace eatacupcake13
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            IList<Entry> entries = new List<Entry>();

            entries.Add(new Entry()
            {
                Name = "Banana Split",
                DateAdded = DateTime.Now,
                SeasonType = "All seasons",
                Seasonal = true,
                Notes = "Bananatastic cupcake frosted with a smooth butter cream frosting, garnished with chocolate drizzle, strawberry drizzle, caramel drizzle, a banana chip and a cherry on top. Nuts are optional. *This item also comes in a deluxe version."
            });

            entries.Add(new Entry()
            {
                Name = "Caramel Frappe",
                DateAdded = DateTime.Now,
                SeasonType = "All seasons",
                Seasonal = true,
                Notes = "Coffee anyone?"
            });

            entries.Add(new Entry()
            {
                Name = "Chocolate Almond Chunk",
                DateAdded = DateTime.Now,
                SeasonType = "All seasons",
                Seasonal = true,
                Notes = "Almond cocoa cupcake, with chunks of chocolate and almond silvers in the cupcake, topped with a creamy almond cocoa frosting and chocolate chunks."
            });

            entries.Add(new Entry()
            {
                Name = "Chocolate Coma",
                DateAdded = DateTime.Now,
                SeasonType = "All seasons",
                Seasonal = true,
                Notes = "Chocolate cupcake frosted with bittersweet chocolate frosting, topped with chocolate drizzle and chocolate jimmies."
            });

            entries.Add(new Entry()
            {
                Name = "Chocolate Salted Caramel",
                DateAdded = DateTime.Now,
                SeasonType = "All seasons",
                Seasonal = true,
                Notes = "Tastes like a carnival"
            });

            entries.Add(new Entry()
            {
                Name = "Lemon Drop",
                DateAdded = DateTime.Now,
                SeasonType = "All seasons",
                Seasonal = true,
                Notes = "Lemon drops falling on my cupcakes"
            });

            entries.Add(new Entry()
            {
                Name = "Maple Bacon",
                DateAdded = DateTime.Now,
                SeasonType = "All seasons",
                Seasonal = true,
                Notes = "Tastes like breakfast!"
            });

            entries.Add(new Entry()
            {
                Name = "PB Chocolate Swirl",
                DateAdded = DateTime.Now,
                SeasonType = "All seasons",
                Seasonal = true,
                Notes = "Do you love peanut butter? Well this peanut butter chocolate cupcake is right up your alley. It's frosted with a chocolate peanut butter icing and decorated with peanut butter chips."
            });

            entries.Add(new Entry()
            {
                Name = "Strawberry Cream",
                DateAdded = DateTime.Now,
                SeasonType = "Spring",
                Seasonal = true,
                Notes = "Strawberry cream cupcake"
            });

            entries.Add(new Entry()
            {
                Name = "Strawberry Margarita",
                DateAdded = DateTime.Now,
                SeasonType = "All seasons",
                Seasonal = true,
                Notes = "Strawberry margarita cupcake is available in regular or virgin flavors"
            });

            entries.Add(new Entry()
            {
                Name = "Sugar Cookie",
                DateAdded = DateTime.Now,
                SeasonType = "All seasons",
                Seasonal = true,
                Notes = "Sugar cookie"
            });

            entries.Add(new Entry()
            {
                Name = "Vanillicious",
                DateAdded = DateTime.Now,
                SeasonType = "All seasons",
                Seasonal = true,
                Notes = "Soft vanilla cupcake, frosted with a vanilla buttercream is the treat for you."
            });

            entries.Add(new Entry()
            {
                Name = "Caramel Apple",
                DateAdded = DateTime.Now,
                SeasonType = "Fall",
                Seasonal = true,
                Notes = "Soft vanilla cupcake, frosted with a vanilla buttercream is the treat for you."
            });

            entries.Add(new Entry()
            {
                Name = "Chunkin' Punkin'",
                DateAdded = DateTime.Now,
                SeasonType = "Fall",
                Seasonal = true,
                Notes = "Soft vanilla cupcake, frosted with a vanilla buttercream is the treat for you."
            });

            entries.Add(new Entry()
            {
                Name = "S'mores",
                DateAdded = DateTime.Now,
                SeasonType = "Fall",
                Seasonal = true,
                Notes = "Soft vanilla cupcake, frosted with a vanilla buttercream is the treat for you."
            });

            entries.Add(new Entry()
            {
                Name = "Crushed Velvet",
                DateAdded = DateTime.Now,
                SeasonType = "Winter",
                Seasonal = true,
                Notes = "Soft vanilla cupcake, frosted with a vanilla buttercream is the treat for you."
            });

            entries.Add(new Entry()
            {
                Name = "Hot Chocolate",
                DateAdded = DateTime.Now,
                SeasonType = "Winter",
                Seasonal = true,
                Notes = "Soft vanilla cupcake, frosted with a vanilla buttercream is the treat for you."
            });

            context.Entries.AddRange(entries);

            context.SaveChanges();

            base.Seed(context);
        }
    }
}