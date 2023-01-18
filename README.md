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

- ### OCPI Contracts
  This package contains OCPI JSON ViewModels (a.k.a. DTOs)

- ### 🚧 OCPI Endpoints (Work in Progress)
  Create OCPI Endpoints. Built-in routing and versioning.
  Functionality based on Asp.Net Core Minimal APIs.

- ### 🚧 Validation (Work in Progress)
  ViewModel validation utilizing FluentValidation.

- ### OCPI Errors
  Throw predefined OCPI Exceptions to get OCPI error results, or create your own custom exceptions.

## Extra

The package is under heavy development, consider current functionality ALPHA and subject to changes.
Any contributions, suggestions and feature requests are welcome.

