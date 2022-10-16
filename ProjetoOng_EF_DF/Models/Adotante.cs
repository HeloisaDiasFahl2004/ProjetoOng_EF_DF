namespace ProjetoOng_EF_DF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Adotante")]
    public partial class Adotante
    {
        [Required]
        [StringLength(50)]
        public string Nome { get; set; }

        [Key]
        [StringLength(11)]
        public string CPF { get; set; }

        [Required]
        [StringLength(1)]
        public string Sexo { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataNascimento { get; set; }

        [Required]
        [StringLength(11)]
        public string Telefone { get; set; }

        [Required]
        [StringLength(50)]
        public string Logradouro { get; set; }

        [Required]
        [StringLength(8)]
        public string CEP { get; set; }

        [StringLength(20)]
        public string Complemento { get; set; }

        public int Numero { get; set; }

        [Required]
        [StringLength(30)]
        public string Bairro { get; set; }

        [Required]
        [StringLength(30)]
        public string Cidade { get; set; }

        [Required]
        [StringLength(2)]
        public string Estado { get; set; }

        [ForeignKey("Pet")]
        public int ChipPet { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataAdocao { get; set; }

        public virtual Pet Pet { get; set; }
      

        public override string ToString()
        {
            return "\nNome: " + this.Nome + "\nCPF: " + this.CPF + "\nChip Pet: " + this.ChipPet + "\nData Adoção: " +this.DataAdocao
                + "\n >>> Outras informações sobre o adotante <<< \n -Endereço " + "\nLogradouro: "+this.Logradouro + "\t" + "Número: "+this.Numero + "\nBairro: " +this.Bairro 
                + "\nComplemento: "+ this.Complemento+"\nCidade: "+this.Cidade+"\nEstado: "+this.Estado+"\nCEP: "+this.CEP+
                "\nTelefone/Celular: "+this.Telefone+"\nData Nascimento: "+this.DataNascimento;
             
        }

    }
}
