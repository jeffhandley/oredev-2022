## Generic Math in .NET 7

### Why couldn't we perform generic math before?

- No interfaces on numeric types
- C++/CLI incompatibility (static abstract interface members)
- Type loader performance impact at startup
- Compiler, JIT, and Crossgen2 support
- Support in both CoreCLR and Mono runtimes
- Modeling numeric types into an appropriate set of interfaces
- Multi-year effort requiring integration across the language, compiler, runtime, and libraries
    - No mechanism for shipping preview bits across those layers
    - Could certainly use a NuGet package, but not for core types the runtime itself is aware of
    - RequiresPreviewFeatures, along with the analyzer to know if in a preview scope
    - Annotating a full assembly as requiring preview features

### Language Features

- Language support for static abstract interface members
- Checked operators
    - Also blocked Int128/UInt128 because the language/runtime would need to know its checked/unchecked behavior
- Relaxed rules for shift operators
- Unsigned right shift operator
- Preview features
- Curiously recurring template pattern analyzer

### Timeline

- Design doc merged
    -
- Initial PR introducing the libraries feature
    - June 23, 2021: dotnet/runtime#54650
