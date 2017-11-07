namespace TrainingASPDotNet.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PencapaianProgram")]
    public partial class PencapaianProgram
    {
        internal object data;

        public int Id { get; set; }

        [StringLength(500)]
        public string KodProgram { get; set; }

        public DateTime? TarikhProgram { get; set; }

        public int? BilanganHari { get; set; }

        public bool? Lulus { get; set; }

        [StringLength(50)]
        public string JenisKemasukan { get; set; }

        [Required]
        [StringLength(10)]
        public string Terhapus { get; set; }

       
    }
}
