namespace ServerApplication
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Экзамен
    {
        [Key]
        public int НомЗапЭкз { get; set; }

        public int? Семестр { get; set; }

        public int? КодГруппы { get; set; }

        public int? КодСтуд { get; set; }

        public int? КодДисц { get; set; }

        public double? ОтмЭкз { get; set; }

        public virtual Дисциплины Дисциплины { get; set; }

        public virtual Студенты Студенты { get; set; }
    }
}
