using System.Formats.Tar;
using System.IO.Compression;

using FileStream s = File.OpenRead("dotnet-sdk-7.0.100-linux-x64.tar.gz");
using GZipStream g = new GZipStream(s, CompressionMode.Decompress);

System.IO.Directory.CreateDirectory("extracted");

await TarFile.ExtractToDirectoryAsync(
    source: g,
    destinationDirectoryName: "extracted",
    overwriteFiles: false);
