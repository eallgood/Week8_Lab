using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8_Lab.Data.Entities;

namespace Week8_Lab.Repositories
{
    public interface IPetRepo
    {
        Pet GetPet(int id);

        IEnumerable<Pet> GetPetsForUser(int userId);

        void SavePet(Pet pet);

        void UpdatePet(Pet user);

        void DeletePet(int id);
    }
}
