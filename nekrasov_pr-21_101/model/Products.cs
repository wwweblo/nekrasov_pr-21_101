namespace nekrasov_pr_21_101.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            PartnerProducts = new HashSet<PartnerProducts>();
        }

        [Column("Тип продукции")]
        [StringLength(255)]
        public string Тип_продукции { get; set; }

        [Column("Наименование продукции")]
        [StringLength(255)]
        public string Наименование_продукции { get; set; }

        public double? Артикул { get; set; }

        [Column("Минимальная стоимость для партнера")]
        public double? Минимальная_стоимость_для_партнера { get; set; }

        public double id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartnerProducts> PartnerProducts { get; set; }

        public virtual ProductTypes ProductTypes { get; set; }
    }
}
