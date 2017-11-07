namespace TrainingASPDotNet.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Database")
        {
        }

        public virtual DbSet<MuatNaikExcel> MuatNaikExcels { get; set; }
        public virtual DbSet<PencapaianProgram> PencapaianPrograms { get; set; }
        public virtual DbSet<PencapaianProgramExcel> PencapaianProgramExcels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MuatNaikExcel>()
                .Property(e => e.NamaAsal)
                .IsFixedLength();

            modelBuilder.Entity<MuatNaikExcel>()
                .Property(e => e.NamaBaru)
                .IsFixedLength();

            modelBuilder.Entity<MuatNaikExcel>()
                .Property(e => e.Lokasi)
                .IsFixedLength();

            modelBuilder.Entity<MuatNaikExcel>()
                .HasMany(e => e.PencapaianProgramExcels)
                .WithOptional(e => e.MuatNaikExcel)
                .HasForeignKey(e => e.IdMuatNaikExcel);

            modelBuilder.Entity<PencapaianProgram>()
                .Property(e => e.KodProgram)
                .IsUnicode(false);

            modelBuilder.Entity<PencapaianProgram>()
                .Property(e => e.JenisKemasukan)
                .IsUnicode(false);

            modelBuilder.Entity<PencapaianProgram>()
                .Property(e => e.Terhapus)
                .IsFixedLength();

            modelBuilder.Entity<PencapaianProgramExcel>()
                .Property(e => e.KodProgram)
                .IsFixedLength();

            modelBuilder.Entity<PencapaianProgramExcel>()
                .Property(e => e.TarikhProgram)
                .IsFixedLength();

            modelBuilder.Entity<PencapaianProgramExcel>()
                .Property(e => e.BilanganHari)
                .IsFixedLength();

            modelBuilder.Entity<PencapaianProgramExcel>()
                .Property(e => e.Lulus)
                .IsFixedLength();

            modelBuilder.Entity<PencapaianProgramExcel>()
                .Property(e => e.Ralat)
                .IsFixedLength();
        }
    }
}
