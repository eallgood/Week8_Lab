﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8_Lab.Models.View;

namespace Week8_Lab.Services
{
    public interface IPetService
    {
        PetViewModel GetPet(int id);

        IEnumerable<PetViewModel> GetPetsForUser(int userId);

        void CreatePet(PetViewModel pet);

        void UpdatePet(PetViewModel user);

        void DeletePet(int id);

        void MarkCheckupFlag(PetViewModel petViewModel);
    }
}
