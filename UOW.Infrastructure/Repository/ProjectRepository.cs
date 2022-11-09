using Microsoft.Extensions.Logging;
using UOW.Core.Entities;
using UOW.Core.Interfaces;

namespace UOW.Infrastructure.Repository;

public class ProjectRepository : GenericRepository<Project>, IProjectRepository
{
    public ProjectRepository(PMSDbContext context, ILogger logger) : base(context, logger)
    {
    }
}