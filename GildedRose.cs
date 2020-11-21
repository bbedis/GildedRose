using System;
using System.Collections.Generic;
using csharp.Handlers;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        IHandler<Item> handler;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;

            handler = new NormalItem();
            
            handler.SetNext(new BackstageItem())
                .SetNext(new AgedBrieItem())
                .SetNext(new SulfurasItem())
                .SetNext(new ConjuredItem());
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                handler.Handle(Items[i]);

                //Items[i].SellIn--;
                //if (Items[i].Name != "Aged Brie" 
                //    && Items[i].Name != "Backstage passes" 
                //    && Items[i].Name != "Sulfuras" 
                //    && Items[i].Name != "Conjured")
                //{
                //    if (Items[i].SellIn < 0)
                //        Items[i].Quality = Items[i].Quality - 2;
                //    else
                //    {
                //        if (Items[i].Quality > 0)
                //        {
                //            Items[i].Quality--;
                //        }
                //    }
                //}
                //else
                //{
                //    if (Items[i].Name == "Aged Brie")
                //    {
                //        if (Items[i].Quality < 50) Items[i].Quality++;
                //    }
                //    else if (Items[i].Name == "Sulfuras") { } // legendary item
                //    else if (Items[i].Name == "Backstage passes")
                //    {
                //        if (Items[i].SellIn > 10)
                //            Items[i].Quality++;
                //        else if (Items[i].SellIn <= 10 && Items[i].SellIn > 5)
                //            Items[i].Quality = Items[i].Quality + 2;
                //        else if (Items[i].SellIn <= 5)
                //            Items[i].Quality = Items[i].Quality + 3;

                //        // Quality drops to 0 after the concert
                //        if (Items[i].SellIn <= 0)
                //            Items[i].Quality = 0;
                //    }
                //    else if (Items[i].Name == "Conjured")
                //    {
                //        if (Items[i].SellIn < 0)
                //            Items[i].Quality = Items[i].Quality - 4;
                //        else
                //            Items[i].Quality = Items[i].Quality - 2;
                //    }
                //}

                //if (Items[i].Quality < 0)
                //    Items[i].Quality = 0;

                //if (Items[i].Name != "Sulfuras" && Items[i].Quality > 50)
                //    Items[i].Quality = 50;

            }
        }
    }
}
