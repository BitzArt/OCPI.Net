# OCPI.Net

![Tests](https://github.com/BitzArt/OCPI.Net/actions/workflows/Tests.yml/badge.svg)

[OCPI (Open Charge Point Interface)](https://github.com/ocpi/ocpi) implementation for .Net, built with C#

Currently supported OCPI versions: `2.2.1`

Planned versions to support: `2.0`, `2.1.1`, `2.2`

See [documentation](docs/Contents.md) for more details.

## Main features

- ### OCPI Contracts and Validation
  This NuGet package provides a comprehensive collection of contract models required for seamless protocol implementation. The package also includes validators specifically designed to validate OCPI contract models, ensuring their accuracy and compliance with the protocol's specifications.

- ### Unrestricted Domain Flexibility:
  While the NuGet package equips you with contract models and validation tools for seamless OCPI protocol implementation, it also allows flexibility within your domain logic. Instead of constricting your application's domain logic, the package empowers you to integrate your specific requirements without limitations. This adaptable approach ensures your implementation perfectly aligns with your business needs and unique use cases, while still maintaining compliance with the OCPI protocol.

- ### Asp.Net Core Integration, OCPI Versioning
  The package contains all necessary functionality to easily implement OCPI using Asp.Net Core. Make sure your OCPI controllers inherit from the `OcpiContrtoller` class. You can apply `OcpiEndpoint` attribute to those controllers that implement OCPI modules, and the package will perform an automated scan of the codebase and fetch necessary data for your OCPI Versions Module.
  
  Explore [this sample project](sample/OCPI.Net.Sample) to see OCPI.Net in action. This project showcases how OCPI.Net integrates seamlessly within an Asp.Net Core application.

- ### OCPI Exceptions
  The package contains a collection of predefined OCPI exceptions that you can use to handle errors that may arise during implementation. These exceptions are designed to provide a clear and comprehensive error message, as well as a detailed description of the error's origin.

## License

This project is licensed under the MIT License - see [LICENSE](LICENSE) for details


