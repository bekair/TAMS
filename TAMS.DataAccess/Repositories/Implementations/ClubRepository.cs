﻿using TAMS.DataAccess.Contexts.EF;
using TAMS.DataAccess.Repositories.Abstracts;
using TAMS.DataAccess.Repositories.Interfaces;
using TAMS.Entity.Concrete;

namespace TAMS.DataAccess.Repositories.Implementations
{
    public class ClubRepository : RepositoryBase<Club, TamsDbContext>, IClubRepository
    {
        public ClubRepository(TamsDbContext context) : base(context)
        {
        }
    }
}
