using ProjetoOng_EF_DF.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOng_EF_DF.View
{
    internal class ViewPet
    {
        ControllerPet cp = new ControllerPet();
        public void MenuPet()
        {
            int opc;
            do
            {
                Console.Clear();
                Console.WriteLine("\t<<< MENU PET >>>");
                Console.WriteLine("\t 0-Retornar ao menu principal");
                Console.WriteLine("\t 1-Cadastrar Pet");//ok
                Console.WriteLine("\t 2-Editar Pet");//ok
                Console.WriteLine("\t 3-Deletar Pet");
                Console.WriteLine("\t 4-Exibir todos os Pet");//ok
                Console.WriteLine("\t 5-Exibir Pet disponiveís para adoção");//ok
                Console.Write("\t Escolha uma opção: ");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 0:
                        ViewPrincipal v = new ViewPrincipal();
                        v.Menu();
                        break;
                    case 1:
                        Console.WriteLine(">>> INICIO CADASTRAMENTO <<< ");
                        cp.Insert();
                        Console.WriteLine(">>> FIM CADASTRAMENTO <<< ");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine(">>> INICIO ATUALIZAÇÃO <<< ");
                        cp.Update();
                        Console.WriteLine(">>> FIM ATUALIZAÇÃO <<< ");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine(">>> INICIO DELEÇÃO <<< ");
                        cp.Delet();
                        Console.WriteLine(">>> FIM DELEÇÃO <<< ");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine(">>> INICIO IMPRESSÃO <<< ");
                        cp.Select();
                        Console.WriteLine("\n>>> FIM IMPRESSÃO <<< ");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine(">>> INICIO IMPRESSÃO <<< ");
                        cp.SelectDisponiveis();
                        Console.WriteLine("\n>>> FIM IMPRESSÃO <<< ");
                        Console.ReadKey();
                        break;


                }
            } while (opc != 0);
        }
    }
}
