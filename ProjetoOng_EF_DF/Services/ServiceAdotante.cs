using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
