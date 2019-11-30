namespace ServerApplication
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Журнал преподавателя")]
    public partial class Журнал_преподавателя
    {
        [Key]
        public int НомерЗаписи { get; set; }

        public int Семестр { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Дата { get; set; }

        public int? КодГруппы { get; set; }

        public int? КодПрепод { get; set; }

        public int? КодСтуд { get; set; }

        public int? КодДисц { get; set; }

        public int? КодФК { get; set; }

        public double? Отметка { get; set; }

        public virtual Дисциплины Дисциплины { get; set; }

        public virtual Преподаватели Преподаватели { get; set; }

        public virtual Студенты Студенты { get; set; }

        public virtual Форма_контроля Форма_контроля { get; set; }
    }
}
