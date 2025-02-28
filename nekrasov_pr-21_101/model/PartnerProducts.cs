namespace nekrasov_pr_21_101.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PartnerProducts
    {
        public double id { get; set; }

        public double? Продукция { get; set; }

        [Column("Наименование партнера")]
        public double? Наименование_партнера { get; set; }

        [Column("Количество продукции")]
        public double? Количество_продукции { get; set; }

        [Column("Дата продажи")]
        public DateTime? Дата_продажи { get; set; }

        public virtual Partners Partners { get; set; }

        public virtual Products Products { get; set; }
    }
}
