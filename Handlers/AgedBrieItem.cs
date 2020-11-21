namespace csharp.Handlers
{
    public class AgedBrieItem : Handler<Item>
    {
        public override void Handle(Item request)
        {
            if (request.Name == "Aged Brie")
            {
                request.SellIn--;

                request.Quality++;

                if (request.Quality > 50)
                    request.Quality = 50;
            }

            base.Handle(request);
        }
    }
}
