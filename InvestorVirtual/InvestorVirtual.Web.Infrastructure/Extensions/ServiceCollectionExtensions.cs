namespace InvestorVirtual.Web.Infrastructure.Extensions;

using System.Reflection;

using Microsoft.Extensions.DependencyInjection;

using InvestorVirtual.Data.Repository.Common;
using InvestorVirtual.Data.Repository.Contracts.Common;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection RegisterRepositoriesFromAssembly(this IServiceCollection serviceCollection, Assembly repositoryAssembly)
    {
        IEnumerable<Type> repositoryImplementationTypes = repositoryAssembly
            .GetTypes()
            .Where(t => t.BaseType != null
                && t.BaseType.IsGenericType
                && t.IsAbstract == false
                && (t.BaseType.GetGenericTypeDefinition() == typeof(BaseRepository<>)
                || t.BaseType.GetGenericTypeDefinition() == typeof(BaseSoftDeletableRepository<>)))
            .ToArray();

        foreach (Type repositoryImplementationType in repositoryImplementationTypes)
        {
            Type? interfaceType = repositoryImplementationType
                .GetInterfaces()
                .SingleOrDefault(it => !it.IsGenericType
                    && it.GetInterfaces()
                        .Any(bit => bit.IsGenericType
                            && (bit.GetGenericTypeDefinition() == typeof(IRepository<>)
                            || bit.GetGenericTypeDefinition() == typeof(ISoftDeletableRepository<>))));

            if (interfaceType != null)
            {
                serviceCollection.AddScoped(interfaceType, repositoryImplementationType);
            }
        }

        return serviceCollection;
    }
}