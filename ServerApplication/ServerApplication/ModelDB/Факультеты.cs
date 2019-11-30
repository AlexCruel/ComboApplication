namespace ServerApplication
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Факультеты
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Факультеты()
        {
            Специальности = new HashSet<Специальности>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int КодФакульт { get; set; }

        [StringLength(50)]
        public string Факультет { get; set; }

        [StringLength(50)]
        public string Руководитель { get; set; }

        [StringLength(50)]
        public string Адрес { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Специальности> Специальности { get; set; }
    }
}
