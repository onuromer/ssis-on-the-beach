using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ssiws.Web.Api.Middleware
{
    public class SwaggerDocumentFilter : IDocumentFilter
    {
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            OpenApiPaths pp = new OpenApiPaths();
            foreach (var item in swaggerDoc.Paths.OrderBy(pair => pair.Key).ToDictionary(pair => pair.Key, pair => pair.Value).Where(pair=>!pair.Key.Contains("Generic")))
            {
                pp.Add(item.Key, item.Value);
            }
            swaggerDoc.Paths = pp;
        }
    }
}
