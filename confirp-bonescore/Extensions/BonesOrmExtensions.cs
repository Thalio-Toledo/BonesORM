using BonesCore.BonesCoreOrm;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BonesCore.Extensions;

public static class BonesOrmExtensions
{
    public static IServiceCollection AddBonesCore(this IServiceCollection services, IConfiguration configuration) => services.AddTransient<BonesORM>();
}