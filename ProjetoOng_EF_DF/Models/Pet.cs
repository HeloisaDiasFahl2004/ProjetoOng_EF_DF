namespace ProjetoOng_EF_DF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pet")]
    public partial class Pet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pet()
        {
            Adotante = new HashSet<Adotante>();
        }

        [Key]
        public int CHIP { get; set; }

        [Required]
        [StringLength(30)]
        public string Familia { get; set; }

        [Required]
        [StringLength(20)]
        public string Raca { get; set; }

        [Required]
        [StringLength(1)]
        public string Sexo { get; set; }

        [StringLength(50)]
        public string Nome { get; set; }

        [Required]
        [StringLength(1)]
        public string Situacao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Adotante> Adotante { get; set; }

        public override string ToString()
        {
            return "\nChip Pet: " + this.CHIP + "\nFamília: " + this.Familia + "\nRaça: " + this.Raca +
                "\nSexo: " + this.Sexo + "\nSituação: " + this.Situacao + "\nNome: " + this.Nome;
        }
    }
}
