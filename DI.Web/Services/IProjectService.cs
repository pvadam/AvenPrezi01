using DI.Web.Models;

namespace DI.Web.Services
{
    public interface IProjectService
    {
        string Name { get; }
        Organization GetOrganization();
    }
}