using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.Controllers;
using Ssiws.Web.Api.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
using Ssiws.Core.Attributes;

namespace Ssiws.Web.Api.Middleware
{
    public class GenericTypeControllerFeatureProvider : IApplicationFeatureProvider<ControllerFeature>
    {
        public void PopulateFeature(IEnumerable<ApplicationPart> parts, ControllerFeature feature)
        {
            var entitiesAssembly = typeof(Core.Entities.Base).Assembly;
            var candidates = entitiesAssembly.GetExportedTypes().Where(x => x.GetCustomAttributes<ControllerDetailsAttribute>().Any());
            

            foreach (var candidate in candidates)
            {
                var attr = candidate.GetCustomAttributes<ControllerDetailsAttribute>().First();
                if (attr.GetByIdDisabled)
                {
                    feature.Controllers.Add(typeof(ReadonlyController<>).MakeGenericType(candidate).GetTypeInfo());

                }
                else
                {
                    feature.Controllers.Add(typeof(CRUDController<,>).MakeGenericType(candidate, attr.PrimaryKeyType).GetTypeInfo());
                }
            }                       
        }
    }
}
