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
  This NuGet package provides a comprehensive collection of contract models required for seamless protocol implementation. Additionally, the package includes validators specifically designed to validate OCPI contract models, ensuring their accuracy and compliance with the protocol's specifications.

- ### Versioning
  This feature allows an easy integration with Asp.Net Core controllers. Apply `OcpiEndpoint` attribute to controllers, and the package will perform an automated scan of the codebase and fetch necessary data for your OCPI Versions Module.

- ### OCPI Errors
  When using OCPI, there might be certain situations where something goes wrong or an error occurs. To help developers handle these errors effectively, there are predefined OCPI Exceptions available. By throwing (or raising) one of these predefined exceptions, developers can easily communicate the specific error that happened in accordance with the protocol.

  In addition to the predefined exceptions, developers also have the flexibility to create their own custom exceptions. This means they can define their own specific types of errors to handle unique situations or requirements in their OCPI implementation.

## Extra

Any contributions, suggestions and feature requests are welcome.

