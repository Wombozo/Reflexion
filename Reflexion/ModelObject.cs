using System;

namespace Reflexion
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
    public class ModelObject : Attribute
    {
        public string Info { get; }

        public ModelObject(string info)
        {
            Info = info;
        }
    }
}