namespace ServerApplication
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Специальности
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Специальности()
        {
            Группы = new HashSet<Группы>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int КодСпец { get; set; }

        public int? КодФакульт { get; set; }

        [StringLength(100)]
        public string НазвСпец { get; set; }

        [StringLength(30)]
        public string СокрНазвСпец { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Группы> Группы { get; set; }

        public virtual Факультеты Факультеты { get; set; }
    }
}
