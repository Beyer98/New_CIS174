using CIS174_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_Project.Services
{
    public  interface IAccomplishmentService  
    {
        IEnumerable<PersonAccomplishmentViewModel> GetAccomplishments();
        PersonDetailAccomplishmentViewModel GetAccomplisment(int id);
        bool Delete(int id);
        PersonDetailAccomplishmentViewModel Edit(PersonDetailAccomplishmentViewModel model);
        AccomplishmentViewModel GetSingleAccomplishment(int id);
        AccomplishmentViewModel UpdateAccomplishmnet(AccomplishmentViewModel model);
        bool Create(PersonAccomplishmentViewModel model);
        bool CreateAccomplishment(CreateAccomplishmentViewModel model);
    }
}
