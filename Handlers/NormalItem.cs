namespace csharp.Handlers
{
    public class NormalItem : Handler<Item>
    {
        public override void Handle(Item request)
        {
            if (request.Name != "Aged Brie"
                    && request.Name != "Backstage passes"
                    && request.Name != "Sulfuras"
                    && !request.Name.Contains("Conjured"))
            {
                request.SellIn--;

                if (!dic.TryGetValue(request, out var quality))
                    quality = 1;

                if (request.SellIn < 0)
                    quality = 2 * quality;

                request.Quality -= quality;

                if (request.Quality < 0)
                    request.Quality = 0;

                dic[request] = quality;
            }

            base.Handle(request);
        }
    }
}
