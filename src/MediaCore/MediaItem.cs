using System;

namespace MediaCore
{
    public interface IMediaItem
    {
        int Id { get; set; }
        string Name { get; set; }
        DateTime Created { get; set; }
        DateTime Modified { get; set; }
        MediaType[] MediaType { get; set; }
        Genre[] Genre { get; set; }

    }
}
