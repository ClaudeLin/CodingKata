using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingKata
{
    public class DistinctApi
    {
        private IEnumerable<int> _result;

        public IEnumerable<int> GetDistinct(IEnumerable<int> source)
        {
            _result = source;


            return _result;
        }
    }
}
