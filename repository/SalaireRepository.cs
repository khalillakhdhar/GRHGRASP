using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GRHGRASP.model;

namespace GRHGRASP.repository
{
    interface SalaireRepository
    {
        void createSalaire(SalaireModel salaire);
        List<SalaireModel> GetSalaireModels();
    }
}
