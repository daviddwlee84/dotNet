# dotNet

Notes of the .NET framework and C#

## Installation

* [Download .NET Core (Linux, macOS, and Windows)](https://dotnet.microsoft.com/download/dotnet-core)

### Install on Ubuntu

[Install .NET on Ubuntu - .NET | Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/core/install/linux-ubuntu#1804-)

```sh
# Add the Microsoft package signing key to your list of trusted keys and add the package repository
wget https://packages.microsoft.com/config/ubuntu/18.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb

# Install the SDK
sudo apt-get update; \
  sudo apt-get install -y apt-transport-https && \
  sudo apt-get update && \
  sudo apt-get install -y dotnet-sdk-5.0

# Install the runtime
sudo apt-get update; \
  sudo apt-get install -y apt-transport-https && \
  sudo apt-get update && \
  sudo apt-get install -y aspnetcore-runtime-5.0
```

## C# Basics

> I will do this without Visual Studio.
> Make sure you have your dotNet framework installed correctly.
> and be able to use `dotnet` command and `csc.exe` to compile C# files.

* [Hello World](Basics/HelloWorldWithoutVisualStudio)
* [Create DLL and Invoke](Basics/CompileIntoDLLWithoutVisualStudio)

## Note

### `.gitignore` for .Net

> [gitignore.io - Create Useful .gitignore Files For Your Project](https://www.toptal.com/developers/gitignore)

* [Easy to create .gitignore for the dotnet developers - DEV](https://dev.to/rafalpienkowski/easy-to-create-gitignore-for-the-dotnet-developers-1h42)
  * `dotnet new gitignore`
* [core/.gitignore at master · dotnet/core](https://github.com/dotnet/core/blob/master/.gitignore)

### VSCode

* Extension
  * [C# - Visual Studio Marketplace](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)
* Development
  * [Download .NET SDK for Visual Studio Code](https://dotnet.microsoft.com/en-us/download/dotnet/sdk-for-vs-code?utm_source=vs-code&amp;utm_medium=referral&amp;utm_campaign=sdk-install)
  * [Create a .NET console application using Visual Studio Code - .NET | Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code?WT.mc_id=dotnet-35129-website&pivots=dotnet-6-0)
  * [Debug a .NET console application using Visual Studio Code - .NET | Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/core/tutorials/debugging-with-visual-studio-code?pivots=dotnet-6-0)
    * [omnisharp-vscode/debugger-launchjson.md at master · OmniSharp/omnisharp-vscode](https://github.com/OmniSharp/omnisharp-vscode/blob/master/debugger-launchjson.md)
  * [Create a .NET class library using Visual Studio Code - .NET | Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/core/tutorials/library-with-visual-studio-code?pivots=dotnet-6-0) (TODO)

## Resources

* [dotnet/core: Home repository for .NET Core](https://github.com/dotnet/core)

### Libraries

Machine Learning

* [dotnet/machinelearning: ML.NET is an open source and cross-platform machine learning framework for .NET.](https://github.com/dotnet/machinelearning)
  * [rxFastTrees function (MicrosoftML) | Microsoft Docs](https://docs.microsoft.com/en-us/machine-learning-server/r-reference/microsoftml/rxfasttrees)
* [Microsoft.Recognizers.Text](https://github.com/Microsoft/Recognizers-Text/tree/master/.NET)

Cloud

* [googleapis/google-cloud-dotnet: Google Cloud Client Libraries for .NET](https://github.com/googleapis/google-cloud-dotnet)

Application

* [dotnet/aspnetcore: ASP.NET Core is a cross-platform .NET framework for building modern cloud-based web applications on Windows, Mac, or Linux.](https://github.com/dotnet/aspnetcore)
* [dotnet/maui: .NET MAUI is the .NET Multi-platform App UI, a framework for building native device applications spanning mobile, tablet, and desktop.](https://github.com/dotnet/maui)
* [dotnet-architecture/eShopOnContainers: Cross-platform .NET sample microservices and container based application that runs on Linux Windows and macOS. Powered by .NET Core 3.0, Docker Containers and Azure Kubernetes Services. Supports Visual Studio, VS for Mac and CLI based environments with Docker CLI, dotnet CLI, VS Code or any other code editor.](https://github.com/dotnet-architecture/eShopOnContainers)

API

* [gRPC](https://github.com/grpc/grpc/tree/master/src/csharp)

### Online Compiler

* [C# Online Compiler | .NET Fiddle](https://dotnetfiddle.net/)

---

* [.NET SDKs downloads for Visual Studio](https://dotnet.microsoft.com/en-us/download/visual-studio-sdks)
* [dotnet/sdk: Core functionality needed to create .NET Core projects, that is shared between Visual Studio and CLI](https://github.com/dotnet/sdk)

Call C# dll

[How to use a C# dll in python project | Using Function from C# dll | Dynamic Link Library | Python - YouTube](https://www.youtube.com/watch?v=lnsTJRY1jPU)

[pythonnet/pythonnet: Python for .NET is a package that gives Python programmers nearly seamless integration with the .NET Common Language Runtime (CLR) and provides a powerful application scripting tool for .NET developers.](https://github.com/pythonnet/pythonnet)

Call C? dll

[Calling a DLL from a script tool—ArcMap | Documentation](https://desktop.arcgis.com/en/arcmap/latest/analyze/creating-tools/calling-a-dll-from-a-script-tool.htm)
[How can I use a DLL file from Python? - Stack Overflow](https://stackoverflow.com/questions/252417/how-can-i-use-a-dll-file-from-python)
[ctypes — A foreign function library for Python — Python 3.10.4 documentation](https://docs.python.org/3/library/ctypes.html)
