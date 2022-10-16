using ProjetoOng_EF_DF.Controllers;
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
    internal class ServiceAdotante
    {
        public void Insert(Adotante adotante)
        {
            using (var context = new ModelDB())
            {
                context.Adotante.Add(adotante);
                context.SaveChanges();
                Console.WriteLine("Adotante cadastrado com sucesso!");
            }
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
        public Adotante SelectOne(Adotante adotante)
        {
            using (var context = new ModelDB())
            {
                var find = context.Adotante.FirstOrDefault(p => p.CPF == adotante.CPF);
                if (find == null)
                {
                    Console.WriteLine("\nAdotante não encontrado!");
                    Console.ReadKey();
                    return null;
                }
                Console.WriteLine("Adotante encontrado!");
                return find;
            }
        }
        public void Update(Adotante adotante)
        {
            using (var context = new ModelDB())
            {
                var find = context.Adotante.FirstOrDefault(p => p.CPF == adotante.CPF);
                if (find == null)
                {
                    Console.WriteLine("\nAdotante não encontrado!");
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine("Adotante encontrado!");
                Console.WriteLine(find.ToString());

                Console.Write("\nEscolha ua opção: 0-Cancelar 1-Nome 2-Sexo 3-Data Nascimento 4-Endereço 5-Telefone 6-Chip Pet");
                int op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        Console.WriteLine("Atualização cancelada!");
                        return;
                    case 1:
                        Console.WriteLine("Nome novo: ");
                        find.Nome = Console.ReadLine();
                        context.Entry(find).State = EntityState.Modified;
                        context.SaveChanges();
                        Console.WriteLine("Adotante atualizado com sucesso!");
                        Console.WriteLine(find.ToString());
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Sexo novo: ");
                        find.Sexo = Console.ReadLine();
                        context.Entry(find).State = EntityState.Modified;
                        context.SaveChanges();
                        Console.WriteLine("Adotante atualizado com sucesso!");
                        Console.WriteLine(find.ToString());
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Data Nasimento nova: ");
                        find.DataNascimento = DateTime.Parse(Console.ReadLine());
                        context.Entry(find).State = EntityState.Modified;
                        context.SaveChanges();
                        Console.WriteLine("Adotante atualizado com sucesso!");
                        Console.WriteLine(find.ToString());
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Endereço - Atualizar: 0-Cancelar 1-Logradouro 2-CEP 3-Coplemento 4-Número 5-Bairro 6-Cidade 7-Estado");
                        int opcao = int.Parse(Console.ReadLine());
                        switch (opcao)
                        {
                            case 0:
                                Console.WriteLine("Atualização cancelada!");
                                return;
                            case 1:
                                Console.WriteLine("Logradouro novo: ");
                                find.Logradouro = Console.ReadLine();
                                context.Entry(find).State = EntityState.Modified;
                                context.SaveChanges();
                                Console.WriteLine("Adotante atualizado com sucesso!");
                                Console.WriteLine(find.ToString());
                                Console.ReadKey();
                                break;
                            case 2:
                                Console.WriteLine("CEP novo: ");
                                find.CEP = Console.ReadLine();
                                context.Entry(find).State = EntityState.Modified;
                                context.SaveChanges();
                                Console.WriteLine("Adotante atualizado com sucesso!");
                                Console.WriteLine(find.ToString());
                                Console.ReadKey();
                                break;
                            case 3:
                                Console.WriteLine("Complemento novo: ");
                                find.Complemento = Console.ReadLine();
                                context.Entry(find).State = EntityState.Modified;
                                context.SaveChanges();
                                Console.WriteLine("Adotante atualizado com sucesso!");
                                Console.WriteLine(find.ToString());
                                Console.ReadKey();
                                break;
                            case 4:
                                Console.WriteLine("Número novo: ");
                                find.Numero = int.Parse(Console.ReadLine());
                                context.Entry(find).State = EntityState.Modified;
                                context.SaveChanges();
                                Console.WriteLine("Adotante atualizado com sucesso!");
                                Console.WriteLine(find.ToString());
                                Console.ReadKey();
                                break;
                            case 5:
                                Console.WriteLine("Bairro novo: ");
                                find.Bairro = Console.ReadLine();
                                context.Entry(find).State = EntityState.Modified;
                                context.SaveChanges();
                                Console.WriteLine("Adotante atualizado com sucesso!");
                                Console.WriteLine(find.ToString());
                                Console.ReadKey();
                                break;
                            case 6:
                                Console.WriteLine("Cidade nova: ");
                                find.Cidade = Console.ReadLine();
                                context.Entry(find).State = EntityState.Modified;
                                context.SaveChanges();
                                Console.WriteLine("Adotante atualizado com sucesso!");
                                Console.WriteLine(find.ToString());
                                Console.ReadKey();
                                break;
                            case 7:
                                Console.WriteLine("Estado novo: ");
                                find.Estado = Console.ReadLine();
                                context.Entry(find).State = EntityState.Modified;
                                context.SaveChanges();
                                Console.WriteLine("Adotante atualizado com sucesso!");
                                Console.WriteLine(find.ToString());
                                Console.ReadKey();
                                break;

                        }
                        break;
                    case 5:
                        Console.WriteLine("Telefone/Celular novo: ");
                        find.Telefone = Console.ReadLine();
                        context.Entry(find).State = EntityState.Modified;
                        context.SaveChanges();
                        Console.WriteLine("Adotante atualizado com sucesso!");
                        Console.WriteLine(find.ToString());
                        Console.ReadKey();
                        break;
                    case 6:
                        bool prossiga = false;
                        ControllerPet pc = new ControllerPet();
                        Pet pet = new Pet();
                        var pe = new ModelDB();
                        do
                        {
                            pet = pc.SelectOne();
                            if (pet != null)
                            {
                                if (pet.Situacao == "D")
                                {


                                    find.ChipPet = pet.CHIP;
                                    pet.Situacao = "A";
                                    pe.Entry(pet).State = EntityState.Modified;
                                    context.Entry(find).State = EntityState.Modified;
                                    context.SaveChanges();
                                    pe.SaveChanges();
                                    Console.WriteLine("Adotante atualizado com sucesso!");
                                    Console.WriteLine(adotante.ToString());
                                    Console.ReadKey();
                                    prossiga = true;
                                    break;
                                }
                                Console.WriteLine("Esse pet já possui um lar!\nForneça um lar para outro pet...");
                            }

                        } while (prossiga == false);


                        break;
                }
            }
        }

        public void Delet(Adotante adotante)
        {
            ModelDB context = new ModelDB();
            Console.Write("\nDeseja continuar a deleção? 0-Cancelar 1-Continuar");
            int op = int.Parse(Console.ReadLine());
            if (op == 0)
            {
                Console.WriteLine("Deleção Cancelada!");
                return;
            }
            context.Entry(adotante).State = EntityState.Deleted;
            context.Adotante.Remove(adotante);
            context.SaveChanges();
            Console.WriteLine("Adotante deletado!");
        }
    }
}

