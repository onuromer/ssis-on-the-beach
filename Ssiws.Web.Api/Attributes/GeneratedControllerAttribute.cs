using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ssiws.Web.Api.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class GeneratedControllerAttribute : Attribute
    {
        public string Route { get; set; }
        public Type PrimaryKeyType { get; set; }
        public string PrimaryKeyName { get; set; }

        public GeneratedControllerAttribute(string route, Type primaryKeyType, string primaryKeyName)
        {
            Route = route;
            PrimaryKeyType = primaryKeyType;
            PrimaryKeyName = primaryKeyName;
        }

    }
}
