# Demos from Øredev 2022

## Generic Math in .NET 7

[Slides](https://www.slideshare.net/jeff-handley/generic-math-in-net-7)

Using the Generic Math interfaces, you can now implement algorithms without taking direct dependencies on specific numeric types. Abstracting over "numbers" or even just "operators" or "properties" or "functions", algorithms can operate over all numeric primitives in .NET along with domain-specific units and types.

[Demo](generic-math-in-net7)

## Updates from the .NET Libraries Team

[Slides](https://www.slideshare.net/jeff-handley/updates-from-the-net-libraries-team)

### System.IO

`System.IO.DirectoryInfo.MoveTo()` now allows just changing the casing on the directory name without throwing an exception.

[Demo](updates-from-net-libraries-team/io_directoryinfo_moveto/Program.cs)

### System.IO.Compression / System.Formats.Tar

.NET 7 supports reading, writing, and updating TAR and TAR.GZ archives.

[Demo](updates-from-net-libraries-team/io_compression_tar/Program.cs)

### System.Net

.NET 7 includes support for HTTP/3 and QUIC.

[Sample Code](updates-from-net-libraries-team/net_http3_quic)

### System.Reflection

`Type.GetProperties()` now returns properties in the order they were declared consistently and reliably.

[Demo](updates-from-net-libraries-team/reflection_getproperties/Program.cs)

### System.Text.Json

Contract Customization allows you to take full control over your serialization and deserialization using code and/or custom attributes.

[Demo](updates-from-net-libraries-team/json_contract_customization)

Polymorphic serialization and deserialization are now possible and can be implemented securely and with high performance. Polymorphic type hierarchies can be expressed with attributes or configured using contract customization.

[Demo](updates-from-net-libraries-team/json_polymorphism)

### System.Text.RegularExpressions

.NET 7 introduced a NonBacktracking engine that guarantees linear execution time over untrusted patterns and/or untrusted text.

[Demo](updates-from-net-libraries-team/regex_nonbacktracking)

And .NET 7 also introduced a regular expression source generator that can be used to convert hard-coded regular expression strings into design-time generated implementations of those specific regular expressions. You can see the code, produced even with code comments describing how the pattern is executed, and you can even set breakpoints and debug into it.

[Demo](updates-from-net-libraries-team/regex_sourcegenerator)
