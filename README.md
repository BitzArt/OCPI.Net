# OCPI.Net

![Tests](https://github.com/BitzArt/OCPI.Net/actions/workflows/Tests.yml/badge.svg)

[OCPI](https://github.com/ocpi/ocpi) implementation for .Net

Supported OCPI versions: `2.0`, `2.1.1`, `2.2`, `2.2.1`

Package documentation is expected later.

For now, you can refer to this [sample project](sample/OCPI.Net.Sample)

## Installation

To use in your project, add the nuget package:
```
dotnet add package OCPI.Net
```

## Main features

- ### OCPI Contracts + Validation
  OCPI JSON Contracts + Validation
  
  (not all validators are implemented yet, Work In Progress)

- ### Versioning
  Mark Controllers with `OcpiEndpoint` attribute to get automated OCPI version fetching.

- ### OCPI Errors
  Throw predefined OCPI Exceptions to get OCPI error results, or create your own custom exceptions.

## Extra

The package is under development, consider current functionality subject to changes.

Any contributions, suggestions and feature requests are welcome.

