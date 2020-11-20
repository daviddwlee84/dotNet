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

## Note

### `.gitignore` for .Net

> [gitignore.io - Create Useful .gitignore Files For Your Project](https://www.toptal.com/developers/gitignore)

* [Easy to create .gitignore for the dotnet developers - DEV](https://dev.to/rafalpienkowski/easy-to-create-gitignore-for-the-dotnet-developers-1h42)
  * `dotnet new gitignore`
* [core/.gitignore at master · dotnet/core](https://github.com/dotnet/core/blob/master/.gitignore)

### VSCode

* [C# - Visual Studio Marketplace](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)

## Resources

* [dotnet/core: Home repository for .NET Core](https://github.com/dotnet/core)

### Libraries

* [dotnet/aspnetcore: ASP.NET Core is a cross-platform .NET framework for building modern cloud-based web applications on Windows, Mac, or Linux.](https://github.com/dotnet/aspnetcore)

Machine Learning

* [dotnet/machinelearning: ML.NET is an open source and cross-platform machine learning framework for .NET.](https://github.com/dotnet/machinelearning)
  * [rxFastTrees function (MicrosoftML) | Microsoft Docs](https://docs.microsoft.com/en-us/machine-learning-server/r-reference/microsoftml/rxfasttrees)

Cloud

* [googleapis/google-cloud-dotnet: Google Cloud Client Libraries for .NET](https://github.com/googleapis/google-cloud-dotnet)

Application

* [dotnet/maui: .NET MAUI is the .NET Multi-platform App UI, a framework for building native device applications spanning mobile, tablet, and desktop.](https://github.com/dotnet/maui)
