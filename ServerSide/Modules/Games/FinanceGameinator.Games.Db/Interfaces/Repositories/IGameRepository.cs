﻿using CleanHandling;
using FinanceGameinator.Games.Domain.Models;

namespace FinanceGameinator.Games.Db.Interfaces.Repositories
{
    public interface IGameRepository
    {
        Task<Result<Game, BusinessException>> FindById(Guid id);
        Task<Result<GameRegistration, BusinessException>> Register(GameRegistration registrationData);
    }
}
