# Melissa Cloud API Dotnet

## Purpose
This code showcases the Melissa Cloud API NuGet Package using C#.

Please feel free to copy or embed this code to your own project. Happy coding!

For more details about how to use the Melissa Cloud API NuGet Package, please visit the [Melissa Docs](https://docs.melissa.com/cloud-api/cloud-api-packages/cloud-api-packages-installation.html).

For more details about Melissa Cloud APIs, please click [here](https://docs.melissa.com/cloud-api/cloud-api/cloud-api-index.html).

## Tested Environments
- Windows 10 64-bit

## Getting Started
These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. 

### Licensing
All Melissa Cloud APIs require a license in order to be accessed. This license is an encrypted series of letters, numbers, and symbols. This license can also either be a Credit license or a Subscription license. Both ways use the same service, so you do not need to change your code to move from one model to another.

To learn more about how to set up a license key with Melissa, please click [here](https://docs.melissa.com/cloud-api/cloud-api/licensing.html).

#### Install the Dotnet Core SDK
Before starting, make sure that the .NET 8.0 SDK has been correctly installed on your machine (If you have Visual Studio installed, you most likely have it already). If you are unsure, you can check by opening a command prompt window and typing the following:

`dotnet --list-sdks`

If the .NET 8.0 SDK is already installed, you should see it in the following list:

![alt text](/screenshots/dotnet_output.png)

As long as the above list contains version `8.0.xxx` (underlined in red), then you can skip to the next step. If your list does not contain version 8.0, or you get any kind of error message, then you will need to download and install the .NET 8.0 SDK from the Microsoft website.

To download, follow this link: https://dotnet.microsoft.com/en-us/download/dotnet

Select `.NET 8.0` and you will be navigated to the download page.

Click and download the `x64` SDK installer for your operating system.

(IMPORTANT: Make sure you download the SDK, NOT the runtime. the SDK contains both the runtime as well as the tools needed to build the project.)

![alt text](/screenshots/net8.png)

Once clicked, your web browser will begin downloading an installer for the SDK. Run the installer and follow all of the prompts to complete the installation (your computer may ask you to restart before you can continue). Once all of that is done, you should be able to verify that the SDK is installed with the `dotnet --list-sdks` command.

----------------------------------------

#### Download this project
```
git clone https://github.com/MelissaData/MelissaCloudAPI-Dotnet
cd MelissaCloudAPI-Dotnet
```

#### Add the package
There are three ways for you to install the Melissa Cloud API Package.

**To install the package using NuGet:**

1. Open your **Visual Studio** project
2. Go to *Tools* → *NuGet Package Manager* → *Manage NuGet Packages for Solution*
3. Search for **MelissaData.CloudAPI**
4. Click install

**To install the package using .NET CLI:**

1. Open command prompt and navigate to the root-directory of your project
2. Run the following command:
```
dotnet add package MelissaData.CloudAPI
```

**To install the package using Git:**

1. From the root-directory your project, clone the package using the command:

```
git clone https://github.com/MelissaData/MelissaCloudAPI-Nuget
```

2. Open project solution
3. Right-click the project solution in the solution explorer
4. Go to *Add* → *Existing Project* and add **MelissaCloudAPINuGet.csproj**
5. Right-click the project in the solution explorer
6. Go to *Add* → *Project Reference* and add **MelissaCloudAPINuGet**

### Import in C#

After installing, add the following statement to import the namespace at the top of your C# file:

```
using MelissaData.CloudAPI;
```

The Melissa Cloud API Dotnet should now be set up. Enjoy!

## Contact Us
For free technical support, please call us at 800-MELISSA ext. 4 (800-635-4772 ext. 4) or email us at Tech@Melissa.com.

