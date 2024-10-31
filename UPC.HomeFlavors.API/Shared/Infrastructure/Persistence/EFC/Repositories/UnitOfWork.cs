using UPC.HomeFlavors.API.Shared.Domain.Repositories;
using UPC.HomeFlavors.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using Microsoft.EntityFrameworkCore;
using System;

namespace UPC.HomeFlavors.API.Shared.Infrastructure.Persistence.EFC.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}