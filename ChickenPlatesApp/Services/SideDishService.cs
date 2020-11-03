﻿using ChickenPlatesApp.Models;
using ChickenPlatesApp.Models.Repositories;
using ChickenPlatesApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChickenPlatesApp.Services
{
    public class SideDishService : ISideDishService
    {
        private readonly ISideDishRepository _repo;

        public SideDishService(ISideDishRepository repo)
        {
            _repo = repo;
        }
        public SideDish Create(SideDish sideDish)
        {
            return _repo.Create(sideDish);
        }

        public void Delete(long sideDishId)
        {
            throw new NotImplementedException();
        }

        public SideDish Get(long sideDishId)
        {
            return _repo.get(sideDishId);
        }

        public List<SideDish> GetAll()
        {
            return _repo.GetAll().ToList();
        }

        public SideDish Update(SideDish sideDish)
        {
            throw new NotImplementedException();
        }
    }
}
