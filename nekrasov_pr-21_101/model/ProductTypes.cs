namespace nekrasov_pr_21_101.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProductTypes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductTypes()
        {
            Products = new HashSet<Products>();
        }

        [StringLength(255)]
        public string id { get; set; }

        [Column("Тип продукции")]
        [StringLength(255)]
        public string Тип_продукции { get; set; }

        [Column("Коэффициент типа продукции")]
        public double? Коэффициент_типа_продукции { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Products> Products { get; set; }
    }
}
