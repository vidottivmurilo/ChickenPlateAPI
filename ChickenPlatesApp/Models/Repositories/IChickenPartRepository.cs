using System;
using System.Collections;
using System.Collections.Generic;

namespace ChickenPlatesApp.Models.Repositories
{
    public interface IChickenPartRepository : IDisposable
    {
        ChickenPart Create(ChickenPart chickenPart);
        ChickenPart get(long chickenPartId);
        IEnumerable<ChickenPart> GetAll();
        void Delete(ChickenPart chickenPart);
        ChickenPart Update(ChickenPart chickenPart);

        int SaveChanges();

    }
}
