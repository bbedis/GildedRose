using System;
using System.Collections.Generic;

namespace csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            IList<Item> Items = new List<Item>{
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Item {Name = "Aged Brie", SellIn = 10, Quality = 30},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Item {Name = "Sulfuras", SellIn = 30, Quality = 80},
                //new Item {Name = "Sulfuras", SellIn = -1, Quality = 80},
                new Item
                {
                    Name = "Backstage passes",
                    SellIn = 25,
                    Quality = 1
                },
                new Item
                {
                    Name = "Backstage passes",
                    SellIn = 10,
                    Quality = 25
                },
                new Item
                {
                    Name = "Backstage passes",
                    SellIn = 5,
                    Quality = 49
                },
                // this conjured item does not work properly yet
                new Item {Name = "Conjured", SellIn = 4, Quality = 20}
            };

            var app = new GildedRose(Items);


            for (var i = 0; i < 31; i++)
            {
                app.UpdateQuality();
                Console.WriteLine("-------- day " + (i+1) + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++)
                {
                    System.Console.WriteLine(Items[j]);
                }
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
