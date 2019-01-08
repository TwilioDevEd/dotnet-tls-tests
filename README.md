# TLS 1.2 connectivity tests for .NET Framework and .NET Core

## Framework versions tested

- .NET Framework 3.5
- .NET Framework 4
- .NET Framework 4.5
- .NET Framework 4.5.1
- .NET Framework 4.6.1
- .NET Framework 4.7.1
- .NET Core 1.0
- .NET Core 1.1
- .NET Core 2.0
- .NET Core 2.1
- .NET Core 2.2

## Running the tests

First, make sure you have the version of the framework you wish to test installed.

1. Open the `tls_tests.sln` solution in Visual Studio 2017.
2. Right-click on the project you wish to run and choose "Set as StartUp Project
3. Start the project in Visual Studio

## Running the tests without Visual Studio

Only the .NET Core tests can be run without Visual Studio.

1. cd into the appropriate project directory (e.g. `TestCore20`, `TestCore21`, etc.)
2. Run `dotnet run` to run the project

## Running the test from your own project

The only way to be 100% sure that your application will be able to connect is to actually test from within your application code base.

First, determine what version of .NET your application targets. There are two possible paths to take depending on your version.

### .NET Framework 4.5 or lower

1. Copy the `TestFramework45\TwilioConnectivityTest45AndBelow.cs` into your project directory.
2. Add the `TwilioConnectivityTest45AndBelow.cs` you just copied to your project.
3. Find some place in your code where you'd like to run the connectivity test. (Perhaps on a button click, during a startup routine, or in a controller action.)
4. Find the project directory that is closest to the same .NET Framework version your application is targeting (`TestFramework35`, `TestFramework40`, or `TestFramework45`)
5. From the `Program.cs` file in the appropriate project, copy the code _inside_ the `Main()` function. Paste the code into the location you selected in step 3.
    - *NOTE:* For .NET Framework 3.5, you will also need to copy and add the `TestFramework35\SecurityProtocolTypeExtensions.cs` and `TestFramework35\SslProtocolsExtensions.cs` files to your project.
6. Also from the `Program.cs` file, copy the `using` statements to the top of the file where you pasted the previous code, making sure to avoid duplicate usings (e.g. you may already have `using System`).
7. Run your test!
	
### .NET Framework 4.5.1 or higher, including all versions of .NET Core

1. Copy the `TestFramework451\TwilioConnectivityTest451AndAbove.cs` into your project directory.
2. Add the `TwilioConnectivityTest451AndAbove.cs` you just copied to your project.
3. Find some place in your code where you'd like to run the connectivity test. (Perhaps on a button click, during a startup routine, or in a controller action.)
4. Find the project directory that is closest to the same .NET Framework/Core version your application is targeting (`TestFramework451`, `TestFramework461`, `TestFramework471`, `TestCore10`, `TestCore11`, `TestCore20`, `TestCore21`, or `TestCore22`)
5. From the `Program.cs` file in the appropriate project, copy the code _inside_ the `Main()` function. Paste the code into the location you selected in step 3.
6. Also from the `Program.cs` file, copy the `using` statements to the top of the file where you pasted the previous code, making sure to avoid duplicate usings (e.g. you may already have `using System`).
7. Run your test!
