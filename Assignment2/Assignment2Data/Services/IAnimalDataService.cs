using System;
using System.Collections.Generic;
using System.Text;
using Assignment2Data.Animal;

namespace Assignment2Data.Services
{
    public interface IAnimalDataService
    {
        void Initialise();
        IList<Animals> SelectAll();
        Animals SelectByID(int id);
        Animals Insert(Animals obj);
        void Update(Animals obj);
        bool Delete(int id);

    }
}
