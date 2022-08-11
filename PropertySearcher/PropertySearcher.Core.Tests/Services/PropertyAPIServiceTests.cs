using PropertySearcher.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertySearcher.Core.Tests.Services
{
    public class PropertyAPIServiceTests
    {

        [Fact]
        public void ShouldReturnPropertryListings()
        {
            var api = new PropertyAPIService();
        }
    }
}
