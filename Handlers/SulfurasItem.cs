namespace csharp.Handlers
{
    public class SulfurasItem : Handler<Item>
    {
        public override void Handle(Item request)
        {
            if (request.Name == "Sulfuras")
            {request.SellIn--;}

            base.Handle(request);
        }
    }
}
