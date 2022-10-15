using ProjetoOng_EF_DF.Repository;
using ProjetoOng_EF_DF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOng_EF_DF.Controllers
{
    internal class ControllerPet:IPetRepository
    {
        public void Insert()
        {
            Pet pet = new Pet();
            Console.WriteLine("Família: ");
            pet.Familia = Console.ReadLine().ToUpper();
            Console.WriteLine("Raça: ");
            pet.Raca = Console.ReadLine().ToUpper();
            Console.WriteLine("Sexo: ");
            pet.Sexo = Console.ReadLine().ToUpper();
            Console.WriteLine("Nome: ");
            pet.Nome = Console.ReadLine().ToUpper();
            Console.WriteLine("Situação: D");
            pet.Situacao = "D";
            new ServicePet().Insert(pet);
        }
        public void Select()
        {
            new ServicePet().Select();
        }
        public void SelectDisponiveis()
        {
            new ServicePet().SelectDisponiveis();
        }
        public void Update()
        {
            Pet pet = new Pet();
            Console.WriteLine("CHIP: ");
            pet.CHIP = int.Parse(Console.ReadLine());
            new ServicePet().Update(pet);
        }
        public void Delet()
        {
            Pet pet = new Pet();
            Console.WriteLine("CHIP: ");
            pet.CHIP = int.Parse(Console.ReadLine());
            new ServicePet().Delet(pet);
        }
    }
}
