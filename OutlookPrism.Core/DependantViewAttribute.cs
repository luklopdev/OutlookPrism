using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookPrism.Core
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class DependantViewAttribute : Attribute
    {
        public string Region { get; set; } 
        public Type Type { get; set; }

        public DependantViewAttribute(string region, Type type)
        {
            if(string.IsNullOrEmpty(region))
                throw new ArgumentNullException(nameof(region));

            if(type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            Type = type;
            Region = region;
        }
    }
}
