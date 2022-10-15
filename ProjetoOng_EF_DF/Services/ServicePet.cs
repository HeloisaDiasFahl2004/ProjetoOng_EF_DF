using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOng_EF_DF.Services
{
    internal class ServicePet
    {
        public void Insert(Pet pet)
        {
            using (var context = new ModelDB())
            {
                context.Pet.Add(pet);
                context.SaveChanges();
                Console.WriteLine("Pet cadastrado com sucesso!");
            }
        }
        public void Select()
        {
            var context = new ModelDB();
            var p = context.Pet.ToList();
            foreach(var item in p)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public void SelectDisponiveis()
        {
            var context = new ModelDB();
            var p = context.Pet.ToList();
            foreach (var item in p)
            {
                p.Where(x => x.Situacao == "D").ToList().ForEach(x => Console.WriteLine(x));
            }
        }
    }
}
