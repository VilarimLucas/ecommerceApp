using api_rest.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api_rest.Data.Map
{
    public class ProductMap : IEntityTypeConfiguration<ProductModel>
    {
        public void Configure(EntityTypeBuilder<ProductModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ProductName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.ProductDescription).IsRequired().HasColumnType("TEXT");
            builder.Property(x => x.ProductSize).IsRequired();
            builder.Property(x => x.ProductColor).IsRequired().HasMaxLength(20);
            builder.Property(x => x.ProductDetails).IsRequired().HasColumnType("TEXT");
            builder.Property(x => x.ProductPrice).IsRequired();
        }
    }
}
