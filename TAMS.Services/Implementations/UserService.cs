﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TAMS.Common.DTOs.ResponseDTOs;
using TAMS.DataAccess.UnitOfWork.Interfaces;
using TAMS.Services.Interfaces;

namespace TAMS.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ICollection<RegisterUserDTO>> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<int> GetIdByUserNameAsync(string userName)
        {
            throw new NotImplementedException();
        }

        public async Task<RegisterUserDTO> GetUserByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<RegisterResultDTO> RegisterUserAsync(string email, string userName, string password)
        {
            return null;
            //return await _unitOfWork.Users.RegisterUserAsync(email, userName, password);
        }
    }
}
