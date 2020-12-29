using System;
using System.Collections.Generic;
using System.Text;

namespace Ssiws.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class ControllerDetailsAttribute : Attribute
    {
        public string Route { get; set; }
        public Type PrimaryKeyType { get; set; }        
        public bool GetByIdDisabled { get { return PrimaryKeyType==null; } }
        public ControllerDetailsAttribute(string route, Type primaryKeyType)
        {
            Route = route;
            PrimaryKeyType = primaryKeyType;
        }
        public ControllerDetailsAttribute(string route)
        {
            Route = route;
        }
    }
}
