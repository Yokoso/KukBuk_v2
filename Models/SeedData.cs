using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace KukBuk.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new KukBukContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<KukBukContext>>()))
            {
                // Look for any movies.
                if (context.Recipe.Any())
                {
                    return;   // DB has been seeded
                }

                context.Recipe.AddRange(
                    new Recipe
                    {
                        Title = "Lasagne",
                        Cuisine = "Italian",
                        UploadDate = DateTime.Parse("2022-4-12"),
                        Description = "Rodzaj makaronu w kształcie dużego, prostokątnego placka. Tym słowem określa się również potrawę przygotowaną z ułożonych w stos warstw makaronu poprzekładanych mięsem, warzywami, serem oraz sosem, a czasami posypaną stopionym tartym serem żółtym.",
                        PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/f/fe/Lasagna_with_salad%2C_May_2011.jpg"
                    },

                    new Recipe
                    {
                        Title = "Pizza",
                        Cuisine = "Italian",
                        UploadDate = DateTime.Parse("2022-4-12"),
                        Description = "Potrawa kuchni włoskiej, obecnie szeroko rozpowszechniona na całym świecie. Jest to płaski placek z ciasta drożdżowego (focaccia), z sosem pomidorowym, posypany tartym serem (najczęściej jest to mozzarella) i ziołami, pieczony w bardzo mocno nagrzanym piecu.",
                        PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c0/Pizza_with_tomatoes.jpg/1280px-Pizza_with_tomatoes.jpg"
                    },

                    new Recipe
                    {
                        Title = "Kebab",
                        Cuisine = "Turkish",
                        UploadDate = DateTime.Parse("2022-4-12"),
                        Description = "Turecka potrawa[1]. Określenie obejmuje ponad dwadzieścia odmian tej potrawy (m.in. İskender kebabı, Adana kebabı czy şiş kebabı) i nie jest jednoznaczne. ",
                        PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f9/D%C3%B6ner_kebab.jpg/1024px-D%C3%B6ner_kebab.jpg"
                    },

                    new Recipe
                    {
                        Title = "Spaghetti",
                        Cuisine = "Italian",
                        UploadDate = DateTime.Parse("2022-4-12"),
                        Description = "rodzaj długiego, cienkiego makaronu, podstawa dań tradycyjnej kuchni włoskiej. W języku polskim słowo to bywa również używane w odniesieniu do potraw z tego makaronu.",
                        PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/b/bb/%D0%A1%D0%BF%D0%B0%D0%B3%D0%B5%D1%82%D1%82%D0%B8_%D1%81_%D0%B3%D0%B0%D1%80%D0%BD%D0%B8%D1%80%D0%BE%D0%BC.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}