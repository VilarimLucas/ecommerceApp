namespace api_rest.models
{
    public class ShipingModel
    {
        public int Id { get; set; }
        public string ShopingType { get; set; }
        public float FlatRate { get; set; }
        public string ShipingState { get; set;}
        public string ShipingCountry { get; set; }
    }
}
