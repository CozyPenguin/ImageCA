# Install

## Released Version

Currently, there are no releases.

## Development

This guide will teach you how to build the project from source

### Requirements

To build the project, you need [Visual Studio 2019](https://visualstudio.com) with the following components:
- .NET Standard 2.1
- .NET Framework 4.7.2
- [.NET Core 3.0](https://dotnet.microsoft.com/download/dotnet-core/3.0)

Clone the project using `git clone https://github.com/CozyPenguin/ImageCA.git`.
If you want to use the development version of ImageCA, add `-b develop`.

### Only library

Open `ImageCA.sln` using Visual Studio and build the `ImageCA.csproj`. The built assembly can be found in `ImageCA\bin\Debug` or `ImageCA\bin\Release`.

### Build the Winforms

To build the Windows-Forms program, you currently need Windows. In the future, we will enable Mac and Linux builds through the [mono xwt](https://github.com/mono/xwt) project. The whole codebase for the ui will be switched.

To build the programm, open `ImageCA.sln` and build the `ImageCACore project`
