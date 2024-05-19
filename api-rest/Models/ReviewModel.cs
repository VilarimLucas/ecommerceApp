namespace api_rest.models
{
    public class ReviewModel
    {
        public int Id { get; set; }
        public float Rating { get; set; }
        public string ReviewDescription { get; set; }
        public DateTime ReviewDate { get; set;}
        public int FkProductsId { get; set;}
        public int FkUserCheckoutsId { get;}
    }
}
