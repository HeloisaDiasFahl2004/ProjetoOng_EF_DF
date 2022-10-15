using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOng_EF_DF.View
{
   internal class ViewAdotante
    {
        public void MenuAdotante()
        {
            int opc;
            do
            {
                Console.Clear();
                Console.WriteLine("\t<<< MENU ADOTANTE >>>");
                Console.WriteLine("\t 0-Retornar ao menu principal");
                Console.WriteLine("\t 1-Cadastrar Adotante");
                Console.WriteLine("\t 2-Editar Adotante");//
                Console.WriteLine("\t 3-Deletar Adotante");
                Console.WriteLine("\t 4-Exibir todos Adotantes");// ok
                Console.WriteLine("\t 5-Adotante já cadastrado");// ok
                Console.Write("\t Escolha uma opção: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 0:
                        ViewPrincipal vipr=new ViewPrincipal();
                        vipr.Menu();
                        break;
                    case 1: 
                        break;
                }
            } while (opc != 0);

        }
    }
}
