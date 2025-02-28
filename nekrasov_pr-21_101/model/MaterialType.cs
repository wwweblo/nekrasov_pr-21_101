namespace nekrasov_pr_21_101.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaterialType")]
    public partial class MaterialType
    {
        public double id { get; set; }

        [Column("Процент брака материала ")]
        public double? Процент_брака_материала_ { get; set; }
    }
}
