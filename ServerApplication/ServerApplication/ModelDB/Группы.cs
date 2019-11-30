namespace ServerApplication
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Группы
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Группы()
        {
            Студенты = new HashSet<Студенты>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int КодГруппы { get; set; }

        public int? КодСпец { get; set; }

        [StringLength(15)]
        public string Группа { get; set; }

        [StringLength(50)]
        public string Староста { get; set; }

        [StringLength(50)]
        public string Куратор { get; set; }

        public int? КодФО { get; set; }

        public virtual Специальности Специальности { get; set; }

        public virtual Форма_обучения Форма_обучения { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Студенты> Студенты { get; set; }
    }
}
