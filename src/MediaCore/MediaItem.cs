using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaCore
{
    public interface IMediaItem
    {
        string Name { get; set; }
        DateTime Created { get; set; }
        DateTime Modified { get; set; }
        MediaType MediaCategory { get; set; }

    }
}
