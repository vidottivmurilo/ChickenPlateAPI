using System;
using System.Collections.Generic;

namespace ChickenPlatesApp.Models.Repositories
{
    public interface IChickenPlateRepository : IDisposable
    {
        ChickenPlate Create(ChickenPlate chickenPlate);
        ChickenPlate get(long chickenPlateId);
        IEnumerable<ChickenPlate> GetAll();
        void Delete(ChickenPlate chickenPlate);
        ChickenPlate Update(ChickenPlate chickenPlate);

        int SaveChanges();
    }
}
