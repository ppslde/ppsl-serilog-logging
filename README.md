# ppsl-serilog-logging - .NET Serilog base logging vonfiguration 


This .NET project aims to simplify and streamline logging in your applications by integrating the powerful Serilog library. Serilog is a popular logging library for .NET, offering rich logging capabilities and flexibility.

## Features

- **Serilog Integration**: This project sets up the necessary dependencies and configurations to seamlessly integrate Serilog into your .NET applications.
- **Base Logging Configuration**: You'll find a pre-configured logging setup that serves as a solid foundation for your logging needs. This configuration can be easily extended or customized to suit your specific requirements.
- **Enhanced Logging Capabilities**: Serilog brings enhanced logging features, including structured logging, log enrichment, and the ability to log to various sinks such as files, databases, and third-party services like Elasticsearch.
- **Easy-to-Use**: With a straightforward setup process, this project ensures that you spend less time configuring logging and more time focusing on your application's core functionality.

## Getting Started

To get started with this project, follow these steps:

1. Clone the repository to your local machine.
2. Open the solution in Visual Studio or your preferred .NET IDE.
3. Review and customize the base logging configuration in the `appsettings.json` file.
4. Add any additional Serilog sinks or configurations as needed for your use case.
5. Start logging in your application using the pre-configured Serilog logger.


## Requirements

- .NET 6.0 or later.

## Dependencies

The following dependencies are included in this project:

- Serilog
- Serilog.AspNetCore
- Serilog.Settings.Configuration
- Serilog.Enrichers.Environment
- Serilog.Enrichers.Process
- Serilog.Enrichers.Thread
- Serilog.Exceptions
- Serilog.Expressions
- Serilog.Extensions.Hosting
- Serilog.Sinks.Async


## Contribution

Contributions to this project are welcome and encouraged! If you encounter any issues or have suggestions for improvements, feel free to open an issue or submit a pull request.

## License

This project is licensed under the [MIT License](LICENSE).

---

We hope this project simplifies your logging implementation and helps you gain valuable insights into your application's behavior. Happy logging!

_Your feedback and suggestions are highly appreciated. Thank you for using this project!_