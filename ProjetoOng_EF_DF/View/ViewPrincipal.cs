using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjetoOng_EF_DF.View
{
  internal class ViewPrincipal
    {
        ViewAdotante va = new ViewAdotante();
        ViewPet vp = new ViewPet();
        public void Menu()
        {
            int opc;
            do
            {
                Console.Clear();
                Console.WriteLine("\t<<< MENU >>>");
                Console.WriteLine("\t 0-Sair do Menu");
                Console.WriteLine("\t 1-Menu Adotante");
                Console.WriteLine("\t 2-Menu Pet");
                Console.Write("\t Escolha uma opção: ");
                opc = int.Parse(Console.ReadLine());


                switch (opc)
                {
                    case 0:
                        Console.Write("Saindo . ");
                        Thread.Sleep(200);
                        Console.Write(" .");
                        Thread.Sleep(200);
                        Console.Write(" .");
                        Thread.Sleep(200);
                        Environment.Exit(0);
                        break;
                    case 1:
                        Console.Write("Encaminhando para o menu adotante . ");
                        Thread.Sleep(350);
                        Console.Write(" .");
                        Thread.Sleep(350);
                        Console.Write(" .");
                        Thread.Sleep(350);
                     
                        va.MenuAdotante();
                        
                        break;
                    case 2:
                        Console.Write("Encaminhando para o menu pet . ");
                        Thread.Sleep(350);
                        Console.Write(" .");
                        Thread.Sleep(350);
                        Console.Write(" .");
                        Thread.Sleep(350);
                        vp.MenuPet();
                        break;
                    default:
                        Console.Write("Opção Inválida!");
                        break;

                }
            } while (opc != 0);
        } //4 opções -> sair/menu adotante/ menu adotado/adoção
    }
}
