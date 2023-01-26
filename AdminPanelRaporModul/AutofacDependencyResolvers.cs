using AdminPanelRaporModul.Data.Abstract;
using AdminPanelRaporModul.Data.Concrete;
using Autofac;

namespace AdminPanelRaporModul
{
    public class AutofacDependencyResolvers : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EfOrderProductListDal>().As<IOrderProductListDal>().SingleInstance();
        }

    }
}
