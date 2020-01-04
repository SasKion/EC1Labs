using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace GalaxyShoes.Domain.Infrastructure
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration(): base()
        {
            ToTable("Product");
            HasKey(p => p.ProductId);
            //HasRequired(p => p.ProductCode);
        }
    }
}