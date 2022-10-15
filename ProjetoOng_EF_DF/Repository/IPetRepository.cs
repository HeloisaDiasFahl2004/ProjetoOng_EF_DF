using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOng_EF_DF.Repository
{
    internal interface IPetRepository
    {
        void Insert();
        void Select();
        void SelectDisponiveis();
        void Update();
        void Delet();
    }
}
