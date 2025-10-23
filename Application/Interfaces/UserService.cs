﻿using Application.DTOs;

namespace Application.Interfaces;

public interface IUserService
{
    Task<int> CreateAsync(UserDto user);
}