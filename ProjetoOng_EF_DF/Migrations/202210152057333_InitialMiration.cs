namespace ProjetoOng_EF_DF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMiration : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Adotante",
            //    c => new
            //        {
            //            CPF = c.String(nullable: false, maxLength: 11, unicode: false),
            //            Nome = c.String(nullable: false, maxLength: 50, unicode: false),
            //            Sexo = c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false),
            //            DataNascimento = c.DateTime(nullable: false, storeType: "date"),
            //            Telefone = c.String(nullable: false, maxLength: 11, unicode: false),
            //            Logradouro = c.String(nullable: false, maxLength: 50, unicode: false),
            //            CEP = c.String(nullable: false, maxLength: 8, unicode: false),
            //            Complemento = c.String(maxLength: 20, unicode: false),
            //            Numero = c.Int(nullable: false),
            //            Bairro = c.String(nullable: false, maxLength: 30, unicode: false),
            //            Cidade = c.String(nullable: false, maxLength: 30, unicode: false),
            //            Estado = c.String(nullable: false, maxLength: 2, fixedLength: true, unicode: false),
            //            ChipPet = c.Int(nullable: false),
            //            DataAdocao = c.DateTime(nullable: false, storeType: "date"),
            //        })
            //    .PrimaryKey(t => t.CPF)
            //    .ForeignKey("dbo.Pet", t => t.ChipPet)
            //    .Index(t => t.ChipPet);
            
            //CreateTable(
            //    "dbo.Pet",
            //    c => new
            //        {
            //            CHIP = c.Int(nullable: false, identity: true),
            //            Familia = c.String(nullable: false, maxLength: 30, unicode: false),
            //            Raca = c.String(nullable: false, maxLength: 20, unicode: false),
            //            Sexo = c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false),
            //            Nome = c.String(maxLength: 50, unicode: false),
            //            Situacao = c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false),
            //        })
            //    .PrimaryKey(t => t.CHIP);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Adotante", "ChipPet", "dbo.Pet");
            DropIndex("dbo.Adotante", new[] { "ChipPet" });
            DropTable("dbo.Pet");
            DropTable("dbo.Adotante");
        }
    }
}
