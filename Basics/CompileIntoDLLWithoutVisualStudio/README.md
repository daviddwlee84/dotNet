# Compile C# Code Into DLL And Invoke It Without Visual Studio

## Creating DLL

* [visual studio - How to compile this C# code into a DLL? - Stack Overflow](https://stackoverflow.com/questions/7811600/how-to-compile-this-c-sharp-code-into-a-dll)
* [Consuming Unmanaged DLL Functions - .NET Framework | Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/framework/interop/consuming-unmanaged-dll-functions)
* [Compile DLL using Command Line C# Compiler](https://www.c-sharpcorner.com/uploadfile/kirtan007/compile-dll-using-command-line-C-Sharp-compiler/)

1. Find the path of `csc.exe` (In my case, `C:\Windows\Microsoft.NET\Framework64\v4.0.30319`)
2. Compile C# file using `csc.exe /target:library YourCSharpFile.cs` then this will generate `YourCSharpFile.dll`

## Invoke DLL Using Project

* [c# - How do I include DLLs in my .csproj file? - Stack Overflow](https://stackoverflow.com/questions/7822983/how-do-i-include-dlls-in-my-csproj-file)
* [Referencing a .NET DLL directly, using the .NET Core toolchain | by Toni Solarin-Sodara | Medium](https://medium.com/@tonerdo/referencing-a-net-dll-directly-using-the-net-core-toolchain-16f0af46a4dc)

1. Create new project `dotnet new console` (which I have create a folder called `InvokeDll` and `cd` into it)
2. Create a `lib` folder (but actually you can put DLL at whatever you want), and copy the `YourCSharpFile.dll` into it
3. Add the following lines into the `*.csproj` file

    ```xml
    <ItemGroup>
      <Reference Include="Whatever">
        <HintPath>lib/YourCSharpFile.dll</HintPath>
      </Reference>
    </ItemGroup>
    ```

4. You will be able to using the namespace in the DLL, and write some code
5. Compile and run using `dotnet build`, `dotnet run`

## Invoke DLL Without Using Project

```powershell
csc.exe /r:YourCSharpFile.dll .\CallDLL.cs
.\CallDLL.exe
```

---

## Compile Multiple C# together

```powershell
csc.exe /out:AllCS.exe *.cs
.\AllCS.exe
```

---

Compile C# code without it being a project or solution

* [visual studio 2013 - How to compile C# file without a project? - Stack Overflow](https://stackoverflow.com/questions/28201815/how-to-compile-c-sharp-file-without-a-project)

Compile C# Code Into DLL And Invoke It Using Solution

* [C# Creating a .DLL to hide your c# code and then use it in your c# program - YouTube](https://www.youtube.com/watch?v=tWtB1iRp8QM)
