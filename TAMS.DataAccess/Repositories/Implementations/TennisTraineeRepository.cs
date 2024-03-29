﻿using TAMS.DataAccess.Contexts.EF;
using TAMS.DataAccess.Repositories.Abstracts;
using TAMS.DataAccess.Repositories.Interfaces;
using TAMS.Entity.Concrete;

namespace TAMS.DataAccess.Repositories.Implementations
{
    public class TennisTraineeRepository : RepositoryBase<TennisTrainee, TamsDbContext>, ITennisTraineeRepository
    {
        public TennisTraineeRepository(TamsDbContext context) : base(context)
        {
        }
    }
}