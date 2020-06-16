using System.Collections.Generic;

namespace Reflexion
{
    public interface IModel
    {
        IEnumerable<string> GetPropertiesName();
    }
}