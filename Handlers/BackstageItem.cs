namespace csharp.Handlers
{
    public class BackstageItem : Handler<Item>
    {
        public override void Handle(Item request)
        {
            if (request.Name == "Backstage passes")
            {
                request.SellIn--;

                if (request.SellIn > 10)
                    request.Quality++;
                else if (request.SellIn <= 10 && request.SellIn > 5)
                    request.Quality = request.Quality + 2;
                else if (request.SellIn <= 5)
                    request.Quality = request.Quality + 3;

                // Quality drops to 0 after the concert
                if (request.SellIn < 0)
                    request.Quality = 0;

                if (request.Quality > 50)
                    request.Quality = 50;
            }

            base.Handle(request);
        }
    }
}
