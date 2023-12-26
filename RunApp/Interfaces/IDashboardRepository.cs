using System;
using RunApp.Models;

namespace RunApp.Repository
{
    public interface IDashboardRepository
    {
        Task<List<Race>> GetAllUserRaces();
        Task<List<Club>> GetAllUserClubs();
    }
}

