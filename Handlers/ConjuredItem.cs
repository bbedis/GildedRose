namespace csharp.Handlers
{
    public class ConjuredItem : Handler<Item>
    {
        public override void Handle(Item request)
        {
            if (request.Name.Contains("Conjured"))
            {
                request.SellIn--;

                if (!dic.TryGetValue(request, out var quality))
                    quality = 2;

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
