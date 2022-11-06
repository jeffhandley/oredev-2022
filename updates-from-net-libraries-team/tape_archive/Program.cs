using System.Formats.Tar;
using System.IO.Compression;

using FileStream inputStream = File.OpenRead("sample.tar.gz");

using GZipStream tarContents = new GZipStream(
    inputStream,
    CompressionMode.Decompress);

await TarFile.ExtractToDirectoryAsync(
    source: tarContents,
    destinationDirectoryName: "~/oredev-2022/sample-tar",
    overwriteFiles: false);
