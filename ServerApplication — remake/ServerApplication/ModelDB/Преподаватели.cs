namespace ServerApplication
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Преподаватели
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Преподаватели()
        {
            Журнал_преподавателя = new HashSet<Журнал_преподавателя>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int КодПрепод { get; set; }

        [StringLength(50)]
        public string ФИО_Препод { get; set; }

        [StringLength(50)]
        public string УчёнаяСтепень { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Журнал_преподавателя> Журнал_преподавателя { get; set; }
    }
}
