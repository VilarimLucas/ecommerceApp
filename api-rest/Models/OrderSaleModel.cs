namespace api_rest.Models
{
    public class OrderSaleModel
    {
        public int Id { get; set; }
        public string CodeOrder { get; set; }
        public float Total { get; set; }
        public string ProductsQuantityOrder { get; set; }
        public bool IsPreOrder { get; set;}
        public bool IsWishList { get; set;}
        public bool IsSale { get; set; }
        public int FkUserCheckoutsId { get; set; }
        public int FkProductsId { get; set; }
        public int FkShipingsId { get; set; }
        public int FkPaymentsId { get; set; }
    }
}
