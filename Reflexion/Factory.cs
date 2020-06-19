using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Reflexion
{
    public static class Factory
    {
        public static object Create(string className, object[] props)
        {
            var assembly = typeof(ModelObject).Assembly;
            var types = assembly.GetTypes();
            Type type;
            type = types.First(t => t.Name == className);
            var instance = Activator.CreateInstance(type);
            var propertiesName = GetPropertiesFromInstance(instance);
            var propertiesInfo = propertiesName.Select(type.GetProperty);
            var i = 0;
            foreach (var propertyInfo in propertiesInfo)
            {
                propertyInfo.SetValue(instance, props[i]);
                i++;
            }

            return instance;
        }

        public static IEnumerable<string> GetPropertiesFromInstance(object instance)
        {
            return instance switch
            {
                Book instanceBook => instanceBook.GetPropertiesName(),
                Person instancePerson => instancePerson.GetPropertiesName(),
                _ => throw new NotSupportedException()
            };
        }
    }
}