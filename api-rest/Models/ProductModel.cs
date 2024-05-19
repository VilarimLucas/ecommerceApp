namespace api_rest.models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public float ProductSize { get; set; }
        public string ProductColor { get; set; }
        public string ProductDetails { get; set; }
        public float ProductPrice { get; set;}
        public string ProductImage { get; set;}
    }
}
