using ProjetoOng_EF_DF.Repository;
using ProjetoOng_EF_DF.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOng_EF_DF.Controllers
{
    internal class ControllerAdotante:IAdotanteRepository
    {
        public void Insert()
        {
            Adotante adotante = new Adotante();

            bool prossiga = false;
            ControllerPet pc = new ControllerPet();
            Pet pet = new Pet();
            var pe = new ModelDB();
            do
            {
              pet= pc.SelectOne();
                if (pet != null)
                {
                    if (pet.Situacao == "D")
                    {


                        adotante.ChipPet = pet.CHIP;

                        prossiga = true;
                        break;
                    }
                    Console.WriteLine("Esse pet já possui um lar!\nForneça um lar para outro pet...");
                }

            } while (prossiga == false);

            Console.WriteLine("Nome: ");
            adotante.Nome = Console.ReadLine().ToUpper();
            Console.WriteLine("CPF: ");
            adotante.CPF = Console.ReadLine().ToUpper();
            Console.WriteLine("Sexo: ");
            adotante.Sexo = Console.ReadLine().ToUpper();
            Console.WriteLine("Telefone: ");
            adotante.Telefone = Console.ReadLine(); 
            Console.WriteLine("Logradouro: ");
            adotante.Logradouro = Console.ReadLine().ToUpper();
            Console.WriteLine("Número:  ");
            adotante.Numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Bairro:  ");
            adotante.Bairro =Console.ReadLine();
            Console.WriteLine("CEP:  ");
            adotante.CEP= Console.ReadLine();
            Console.WriteLine("Cidade: ");
            adotante.Cidade = Console.ReadLine().ToUpper();
            Console.WriteLine("Estado:: ");
            adotante.Estado = Console.ReadLine().ToUpper();
            Console.WriteLine("Complemento: ");
            adotante.Complemento = Console.ReadLine().ToUpper();
            adotante.DataAdocao = System.DateTime.Now;

            new ServiceAdotante().Insert(adotante);
            pet.Situacao = "A";
            pe.Entry(pet).State = EntityState.Modified;
            pe.SaveChanges();
        }
        public void Select()
        {
            var context = new ModelDB();
            var a = context.Adotante.ToList();
            foreach (var item in a)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public void SelectOne()
        {

        }
        public void Update()
        {

        }
    }
}
