using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;

namespace ChickenPlatesApp.Models.Repositories
{
    public interface ISideDishRepository : IDisposable
    {
        SideDish Create(SideDish sideDish);
        SideDish get(long sideDishId);
        IEnumerable<SideDish> GetAll();
        void Delete(SideDish sideDish);
        SideDish Update(SideDish sideDish);

        int SaveChanges();

    }
}
