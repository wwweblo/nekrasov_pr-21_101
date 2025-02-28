namespace nekrasov_pr_21_101.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Partners
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Partners()
        {
            PartnerProducts = new HashSet<PartnerProducts>();
        }

        public double id { get; set; }

        [Column("Тип партнера")]
        public double? Тип_партнера { get; set; }

        [Column("Наименование партнера")]
        [StringLength(255)]
        public string Наименование_партнера { get; set; }

        public double? name { get; set; }

        public double? surname { get; set; }

        public double? middlename { get; set; }

        [Column("Электронная почта партнера")]
        [StringLength(255)]
        public string Электронная_почта_партнера { get; set; }

        [Column("Телефон партнера")]
        [StringLength(255)]
        public string Телефон_партнера { get; set; }

        [Column("Юридический адрес партнера")]
        [StringLength(255)]
        public string Юридический_адрес_партнера { get; set; }

        public double? ИНН { get; set; }

        public double? Рейтинг { get; set; }

        public virtual Middlename Middlename1 { get; set; }

        public virtual Name Name1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartnerProducts> PartnerProducts { get; set; }

        public virtual PartnerType PartnerType { get; set; }

        public virtual Surname Surname1 { get; set; }
    }
}
