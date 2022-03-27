using Api.Domain.interfaces;
using Api.Data.Repository;
using Api.Data.Context;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Api.CrossCutting.DependencyInjection
{
  public class ConfigureRepository
  {
    public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
    {
      //conexão de banco usa-se addscoped
      serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));

      serviceCollection.AddDbContext<MyContext>(
        options => options.UseMySql("Server=localhost;Port=3306;Database=dbApi;Uid=root"));

    }

  }
}
