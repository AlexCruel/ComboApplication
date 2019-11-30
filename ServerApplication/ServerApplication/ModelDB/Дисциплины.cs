namespace ServerApplication
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Дисциплины
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Дисциплины()
        {
            Журнал_преподавателя = new HashSet<Журнал_преподавателя>();
            Экзамен = new HashSet<Экзамен>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int КодДисц { get; set; }

        [StringLength(50)]
        public string НазваниеДисц { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Журнал_преподавателя> Журнал_преподавателя { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Экзамен> Экзамен { get; set; }
    }
}
