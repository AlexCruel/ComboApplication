namespace ServerApplication
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelDB : DbContext
    {
        public ModelDB()
            : base("name=ModelDB")
        {
        }

        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Группы> Группы { get; set; }
        public virtual DbSet<Дисциплины> Дисциплины { get; set; }
        public virtual DbSet<Журнал_преподавателя> Журнал_преподавателя { get; set; }
        public virtual DbSet<Преподаватели> Преподаватели { get; set; }
        public virtual DbSet<Специальности> Специальности { get; set; }
        public virtual DbSet<Студенты> Студенты { get; set; }
        public virtual DbSet<Факультеты> Факультеты { get; set; }
        public virtual DbSet<Форма_контроля> Форма_контроля { get; set; }
        public virtual DbSet<Форма_обучения> Форма_обучения { get; set; }
        public virtual DbSet<Экзамен> Экзамен { get; set; }
        public virtual DbSet<Faculty> Faculty { get; set; }
        public virtual DbSet<Journal> Journal { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
