using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOng_EF_DF.Repository
{
    internal interface IAdotanteRepository
    {
        void Insert();
        void Select();
        Adotante SelectOne();
        void Update();
        void Delet();
    }
}
