namespace ServerApplication
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Faculty")]
    public partial class Faculty
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int КодФакульт { get; set; }

        [StringLength(50)]
        public string Факультет { get; set; }

        [StringLength(50)]
        public string Руководитель { get; set; }

        [StringLength(50)]
        public string Адрес { get; set; }
    }
}
