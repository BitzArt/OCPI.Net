# OCPI.Net

![Tests](https://github.com/BitzArt/OCPI.Net/actions/workflows/Tests.yml/badge.svg)

[OCPI](https://github.com/ocpi/ocpi) implementation for .Net

Supported OCPI versions: `2.0`, `2.1.1`, `2.2`, `2.2.1`

Package documentation is a Work In Progress.

For now, you can refer to this [sample project](sample/OCPI.Net.Sample)

## Installation

To use in your project, add the nuget package:
```
dotnet add package OCPI.Net
```

## Main features

- ### OCPI Contracts
  This package contains OCPI JSON ViewModels (a.k.a. DTOs)

- ### 🚧 Validation (Work in Progress)
  Input validation utilizing FluentValidation.

- ### OCPI Errors
  Throw predefined OCPI Exceptions to get OCPI error results, or create your own custom exceptions.

- ### 🚧 Versioning (Work in Progress)
  Tag your controllers with OcpiEndpoint attribute to get automated OCPI version fetching.

## Extra

You can contact me via e-mail: u.a.durov@gmail.com, or create an Issue here on GitHub.
