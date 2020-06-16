using System;
using System.Linq;

namespace Reflexion
{
    public static class Factory
    {
        public static IModel Create(string className, object[] props)
        {
            var type = Type.GetType(nameof(Reflexion) + "." + className, true);
            var instance = (IModel) Activator.CreateInstance(type);
            var propertiesName = instance?.GetPropertiesName();
            var propertiesInfo = (propertiesName ?? throw new InvalidOperationException()).Select(type.GetProperty);
            var i = 0;
            foreach (var propertyInfo in propertiesInfo)
            {
                propertyInfo.SetValue(instance, props[i]);
                i++;
            }
            return instance;
        }
    }
}