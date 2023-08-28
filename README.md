# OCPI.Net

![Tests](https://github.com/BitzArt/OCPI.Net/actions/workflows/Tests.yml/badge.svg)

[OCPI (Open Charge Point Interface)](https://github.com/ocpi/ocpi) implementation for .Net, built with C#

Supported OCPI versions: `2.0`, `2.1.1`, `2.2`, `2.2.1`

Package documentation is expected later.

For now, you can refer to this [sample project](sample/OCPI.Net.Sample)

## Installation

To use in your project, add the nuget package:
```
dotnet add package OCPI.Net
```
for now, see [sample project](sample/OCPI.Net.Sample) for further guidance.

## Main features

- ### OCPI Contracts and Validation
  This NuGet package provides a comprehensive collection of contract models required for seamless protocol implementation. The package also includes validators specifically designed to validate OCPI contract models, ensuring their accuracy and compliance with the protocol's specifications.

- ### Unrestricted Domain Flexibility:
  While the NuGet package equips you with contract models and validation tools for seamless OCPI protocol implementation, it also allows flexibility within your domain logic. Instead of constricting your application's domain logic, the package empowers you to integrate your specific requirements without limitations. This adaptable approach ensures your implementation perfectly aligns with your business needs and unique use cases, while still maintaining compliance with the OCPI protocol.

- ### Asp.Net Core Integration, OCPI Versioning
  The package contains all necessary functionality to easily implement OCPI using Asp.Net Core. Make sure your OCPI controllers inherit from the `OcpiContrtoller` class. You can apply `OcpiEndpoint` attribute to those controllers that implement OCPI modules, and the package will perform an automated scan of the codebase and fetch necessary data for your OCPI Versions Module.
  
  Explore [this sample project](sample/OCPI.Net.Sample) to see OCPI.Net in action. This project showcases how OCPI.Net integrates seamlessly within an Asp.Net Core application.

- ### OCPI Errors
  When working with OCPI, errors can arise. To assist you in managing these errors, we offer predefined OCPI Exceptions. These exceptions make it simple for you to communicate specific errors in line with the protocol. You also have the option to design custom exceptions. This allows you to address distinct scenarios or needs in your OCPI implementation.

## Extra

Any contributions, suggestions and feature requests are welcome.

