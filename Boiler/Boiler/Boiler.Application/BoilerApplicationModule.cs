using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace Boiler
{
    [DependsOn(typeof(BoilerCoreModule), typeof(AbpAutoMapperModule))]
    public class BoilerApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Modules.AbpAutoMapper().Configurators.Add(mapper =>
            {
                //Add your custom AutoMapper mappings here...
                //mapper.CreateMap<,>()
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
