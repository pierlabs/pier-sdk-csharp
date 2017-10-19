## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

## Dependencies
- [RestSharp] (https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET] (https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later 

The DLLs included in the package may not be the latest version. We recommned using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation
Run the following command to generate the DLL
- [Mac/Linux] compile-mono.sh
- [Windows] compile.bat

Then include the DLL (under the `bin` folder) in the C# project

## On Visual Studio

Open your VS, within the project where you will use the SDK methods, click with right button on "References" and select "Add Reference...".

![Step 1](https://lh4.googleusercontent.com/qW0HC9JRhWDjfhTt9_r3TR4K0U3ysJxejK8zIHrY8ihFwccBjwQZx03pOrw_QMTSTtWSam-lckLz0kQ=w1920-h948)

Select "Browser" on the left sidebar and click on the button "Browser".

![Step 2](https://lh3.googleusercontent.com/A-q1jhYs231Wtcipt5W7tpFMb3kcmg5yNCyapBkfAjltg6RCO8ZLIsccm7R472ChhJQerFWQkTDl3A0=w1920-h948)

After that, select a generated DLL after running the "compile.bat" file.

![Step 3](https://lh3.googleusercontent.com/jThRdkg4-WsYoDt0BIG_02-AofafpFNY3VMnFkq_U2Abpp_HuQDZSrTdf7rNBlLzVSopmEjlasu_mJM=w1920-h948)

Use all the features that SDK offers :)

![Step 4](https://lh6.googleusercontent.com/pMa1TIRv1D7eLLuO0MLAJdh7TgEQ-0bu9ehMBeQ5g6SibsQ6_vEGoHVmRESdGXlB_V3dbAjsK-fIzkE=w1920-h948-rw)
