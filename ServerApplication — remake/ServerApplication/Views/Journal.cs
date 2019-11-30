namespace ServerApplication
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Journal")]
    public partial class Journal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Семестр { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Дата { get; set; }

        [StringLength(15)]
        public string Группа { get; set; }

        [StringLength(50)]
        public string ФИО_Препод { get; set; }

        [StringLength(50)]
        public string НазваниеДисц { get; set; }

        [StringLength(50)]
        public string ФИО_Cтуд { get; set; }

        [StringLength(50)]
        public string ВидФК { get; set; }

        public int? Отметка { get; set; }
    }
}
