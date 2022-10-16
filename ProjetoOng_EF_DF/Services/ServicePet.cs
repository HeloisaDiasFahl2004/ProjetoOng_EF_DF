using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
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
                Console.ReadKey();
            }
        }
        public void Select()
        {
            var context = new ModelDB();
            var p = context.Pet.ToList();
            foreach (var item in p)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public Pet SelectOne(Pet pet)
        {
            using (var context = new ModelDB())
            {
                var find = context.Pet.FirstOrDefault(p => p.CHIP == pet.CHIP);
                if (find == null)
                {
                    Console.WriteLine("\nPet não encontrado!");
                    Console.ReadKey();
                  return null;
                }
                return find;
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
        public void Update(Pet pet)
        {
            using (var context = new ModelDB())
            {
                var find = context.Pet.FirstOrDefault(p => p.CHIP == pet.CHIP);
                if (find == null)
                {
                    Console.WriteLine("\nPet não encontrado!");
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine("Pet encontrado!");
                Console.WriteLine(find.ToString());

                Console.Write("\nEscolha ua opção: 0-Cancelar 1-Raça 2-Família 3-Sexo 4-Nome");
                int op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        Console.WriteLine("Atualização cancelada!");
                        return;
                    case 1:
                        Console.WriteLine("Raça nova: ");
                        find.Raca = Console.ReadLine();
                        context.Entry(find).State = EntityState.Modified;
                        context.SaveChanges();
                        Console.WriteLine("Pet atualizado com sucesso!");
                        Console.WriteLine(find.ToString());
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Família nova: ");
                        find.Familia = Console.ReadLine();
                        context.Entry(find).State = EntityState.Modified;
                        context.SaveChanges();
                        Console.WriteLine("Pet atualizado com sucesso!");
                        Console.WriteLine(find.ToString());
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Sexo novo: ");
                        find.Sexo = Console.ReadLine();
                        context.Entry(find).State = EntityState.Modified;
                        context.SaveChanges();
                        Console.WriteLine("Pet atualizado com sucesso!");
                        Console.WriteLine(find.ToString());
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Nome novo: ");
                        find.Nome = Console.ReadLine();
                        context.Entry(find).State = EntityState.Modified;
                        context.SaveChanges();
                        Console.WriteLine("Pet atualizado com sucesso!");
                        Console.WriteLine(find.ToString());
                        Console.ReadKey();
                        break;
                }
            }
        }
        public void Delet(Pet pet)
        {
            using (var context = new ModelDB())
            {
                var find = context.Pet.FirstOrDefault(p => p.CHIP == pet.CHIP);
                if (find == null)
                {
                    Console.WriteLine("\nPet não encontrado!");
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine("Pet encontrado!");
                Console.WriteLine(find.ToString());

                Console.Write("\nDeseja continuar a deleção? 0-Cancelar 1-Continuar");
                int op = int.Parse(Console.ReadLine());
                if (op == 0)
                {
                    Console.WriteLine("Deleção Cancelada!");
                    return;
                }
                context.Entry(find).State = EntityState.Deleted;
                context.Pet.Remove(find);
                context.SaveChanges();
                Console.WriteLine("Pet deletado!");
            }
        }
    }
}
