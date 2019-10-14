using ACoreX.Data.Abstractions;
using ACoreX.WebAPI;
using CQFlooring.CRM.Abstractions;
using Smart.Data.Abstractions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQFlooring.CRM.Module
{
    public class ProductContext : IProductContext
    {
        private IData _data;

        public ProductContext(IData data)
        {
            _data = data;

        }
        [WebApi(Route = "api/getProducts")]
        public Product getProducts()
        {
            QueryInputParamater input = new QueryInputParamater { Code = "ADM-002" };
            var test = new Smart.Data.Module.Contexts.QueryGeneratorContext(_data);
            var generation = test.Generate(input);
            //.QueryGeneratorContext(input);

            return new Product { Name = "" };

        }
    }
}
