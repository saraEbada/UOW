namespace UOW.Core.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IProjectRepository Projects { get; }
    Task<int> CompletedAsync();
}