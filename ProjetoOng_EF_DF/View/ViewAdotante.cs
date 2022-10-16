using ProjetoOng_EF_DF.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOng_EF_DF.View
{
   internal class ViewAdotante
    {
        ControllerAdotante ca=new ControllerAdotante();
        public void MenuAdotante()
        {
            int opc;
            do
            {
                Console.Clear();
                Console.WriteLine("\t<<< MENU ADOTANTE >>>");
                Console.WriteLine("\t 0-Retornar ao menu principal");
                Console.WriteLine("\t 1-Cadastrar Adotante");//ok
                Console.WriteLine("\t 2-Editar Adotante");//
                Console.WriteLine("\t 3-Deletar Adotante");
                Console.WriteLine("\t 4-Exibir todos Adotantes");// ok
                Console.Write("\t Escolha uma opção: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 0:
                        ViewPrincipal vipr=new ViewPrincipal();
                        vipr.Menu();
                        break;
                    case 1:
                        Console.WriteLine(">>> INICIO CADASTRAMENTO <<< ");
                        ca.Insert();
                        Console.WriteLine(">>> FIM CADASTRAMENTO <<< ");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine(">>> INICIO ATUALIZAÇÃO <<< ");
                        ca.Update();
                        Console.WriteLine(">>> FIM ATUALIZAÇÃO <<< ");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine(">>> INICIO DELEÇÃO <<< ");
                        ca.Delet();
                        Console.WriteLine(">>> FIM DELEÇÃO <<< ");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine(">>> INICIO IMPRESSÃO <<< ");
                        ca.Select();
                        Console.WriteLine("\n>>> FIM IMPRESSÃO <<< ");
                        Console.ReadKey();
                        break;
                   
                }
            } while (opc != 0);

        }
    }
}
