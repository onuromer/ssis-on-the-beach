﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Ssiws.Core.Attributes;
using Ssiws.Web.Api.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Ssiws.Web.Api.Conventions
{
    public class GenericControllerRouteConvention : IControllerModelConvention
    {
        public void Apply(ControllerModel controller)
        {
            if (controller.ControllerType.IsGenericType)
            {
                var genericType = controller.ControllerType.GenericTypeArguments[0];
                var customNameAttribute = genericType.GetCustomAttribute<ControllerDetailsAttribute>();

                if (customNameAttribute?.Route != null)
                {
                    controller.Selectors.Add(new SelectorModel
                    {
                        AttributeRouteModel = new AttributeRouteModel(new RouteAttribute(customNameAttribute.Route)),
                    });
                }
                else
                {
                    controller.ControllerName = genericType.Name;
                }
            }
        }
    }
}
