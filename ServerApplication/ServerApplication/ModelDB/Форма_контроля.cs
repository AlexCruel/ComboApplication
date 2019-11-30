namespace ServerApplication
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Форма контроля")]
    public partial class Форма_контроля
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Форма_контроля()
        {
            Журнал_преподавателя = new HashSet<Журнал_преподавателя>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int КодФК { get; set; }

        [StringLength(50)]
        public string ВидФК { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Журнал_преподавателя> Журнал_преподавателя { get; set; }
    }
}
