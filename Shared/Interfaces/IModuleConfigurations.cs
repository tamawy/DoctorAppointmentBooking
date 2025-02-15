using Microsoft.Extensions.DependencyInjection;

namespace Shared.Interfaces
{
    public interface IModuleConfigurations
    {
        void RegisterModule(IServiceCollection services, IMvcBuilder mvcBuilder);
    }
}
