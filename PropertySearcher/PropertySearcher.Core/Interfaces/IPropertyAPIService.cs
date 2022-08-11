using PropertySearcher.Core.DataModels;
using PropertySearcher.Core.InputParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertySearcher.Core.Interfaces
{
    internal interface IPropertyAPIService
    {
        List<PropertyListing> SearchPropertyListings(PropertyListings inputParameters);
    }
}
