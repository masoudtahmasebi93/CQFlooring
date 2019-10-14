using ACoreX.Data.Abstractions;
using ACoreX.Data.Dapper;
using ACoreX.Injector.Abstractions;
using CQFlooring.CRM.Abstractions;
using System;

namespace CQFlooring.CRM.Module
{

    public class Module : IModule
    {
        public void Register(IContainerBuilder builder)
        {
            builder.AddScope<IProductContext, ProductContext>();
            builder.AddScope<IData, DapperData>(new DapperData("Server=192.168.105.55\\exp17;Database=CRM; User Id = ma; Password = 123;"));
        }
    }
}
