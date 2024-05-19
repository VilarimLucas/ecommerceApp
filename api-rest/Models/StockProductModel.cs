namespace api_rest.models
{
    public class StockProductModel
    {
        public int Id { get; set; }
        public int ProductQuantity { get; set; }
        public int FkProductsId { get; set; }
    }
}
