namespace ServerApplication
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Форма обучения")]
    public partial class Форма_обучения
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Форма_обучения()
        {
            Группы = new HashSet<Группы>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int КодФО { get; set; }

        [StringLength(25)]
        public string ТипФО { get; set; }

        [StringLength(20)]
        public string ДниЗанятий { get; set; }

        [StringLength(20)]
        public string ВремяЗанятий { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Группы> Группы { get; set; }
    }
}
