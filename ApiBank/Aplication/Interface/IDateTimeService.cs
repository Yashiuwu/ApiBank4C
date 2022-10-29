using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Interface
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }

    }
}
