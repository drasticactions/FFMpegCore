﻿using System.Threading;
using System.Threading.Tasks;

namespace FFMpegCore.Pipes
{
    /// <summary>
    /// Implementation of <see cref="IPipeDataWriter"/> used for stream redirection
    /// </summary>
    public class StreamPipeDataWriter : IPipeDataWriter
    {
        public System.IO.Stream Source { get; }
        public int BlockSize { get; } = 4096;
        public string StreamFormat { get; } = string.Empty;

        public StreamPipeDataWriter(System.IO.Stream source)
        {
            Source = source;
        }

        public Task CopyAsync(System.IO.Stream outputStream, CancellationToken cancellationToken) => Source.CopyToAsync(outputStream, BlockSize, cancellationToken);

        public string GetFormat() => StreamFormat;
    }
}
