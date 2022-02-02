using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GRHGRASP.model;
using GRHGRASP.repository;
namespace GRHGRASP.controllers
{
    class UserSalaireRepoController : UserSalaireRepo
    {
        public string afficheSalaire(EmployeeModel employee)
        {
            return "la salaire nette de "+employee.Nom+" est : "+employee.salaire.Nette;
        }
    }
}
