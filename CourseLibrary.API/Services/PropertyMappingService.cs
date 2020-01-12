using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibrary.API.Services
{
    public class PropertyMappingService
    {
        private Dictionary<string, PropertyMappingValue> _authorPropertyMapping =
          new Dictionary<string, PropertyMappingValue>(StringComparer.OrdinalIgnoreCase)
          {
               { "Id", new PropertyMappingValue(new List<string>() { "Id" } ) },
               { "MainCategory", new PropertyMappingValue(new List<string>() { "MainCategory" } )},
               { "Age", new PropertyMappingValue(new List<string>() { "DateOfBirth" } , true) },
               { "Name", new PropertyMappingValue(new List<string>() { "FirstName", "LastName" }) }
          };
    }
}
