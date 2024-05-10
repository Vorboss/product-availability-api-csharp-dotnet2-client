@echo off
SETLOCAL EnableExtensions

:: Check if PowerShell is available
powershell -command "exit" >nul 2>&1
IF %ERRORLEVEL% NEQ 0 (
    echo PowerShell is required but was not found. Please install PowerShell and try again.
    goto end
)

:: Download nuget.exe using PowerShell
echo Downloading nuget.exe...
PowerShell -Command "Invoke-WebRequest 'https://dist.nuget.org/win-x86-commandline/latest/nuget.exe' -OutFile 'nuget.exe'" >nul 2>&1
IF %ERRORLEVEL% NEQ 0 (
    echo Failed to download nuget.exe. Please check your internet connection and try again.
    goto end
)

:: Check if nuget.exe exists
IF NOT EXIST nuget.exe (
    echo nuget.exe is missing and could not be downloaded. Ensure you have internet access and try again.
    goto end
)

:: Restore packages using NuGet
echo Restoring packages...
nuget.exe install vendor/packages.config -OutputDirectory vendor >nul 2>&1
IF %ERRORLEVEL% NEQ 0 (
    echo Failed to restore NuGet packages. Ensure nuget.exe is correct and vendor/packages.config exists.
    goto end
)

:: Create output directory if it doesn't exist
IF NOT EXIST bin MKDIR bin

:: Check if the C# compiler (csc.exe) is available
where csc >nul 2>&1
IF %ERRORLEVEL% NEQ 0 (
    echo C# compiler csc.exe is not found. Ensure .NET Framework SDK is installed and csc.exe is in your PATH.
    goto end
)

:: Compile the project
echo Compiling the project...
csc -sdk:2 -reference:"vendor\Newtonsoft.Json.7.0.1\lib\net20\Newtonsoft.Json.dll;vendor\RestSharp.Net2.1.1.11\lib\net20\RestSharp.Net2.dll;System.Runtime.Serialization.dll" -target:library -out:bin\Com.Vorboss.ProductAvailability.dll -recurse:"src\*.cs" -doc:bin\Com.Vorboss.ProductAvailability.xml -platform:anycpu >nul 2>&1
IF %ERRORLEVEL% NEQ 0 (
    echo Compilation failed. Check that all references are correct and all source files are available.
    goto end
)

echo Compilation complete.
:end
pause
ENDLOCAL
