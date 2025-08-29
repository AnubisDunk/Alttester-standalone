![Unity](https://img.shields.io/badge/unity-%23000000.svg?style=for-the-badge&logo=unity&logoColor=white)
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white)
# AltTester Standalone - QA Engineer test assignment for [Estoty](https://www.estoty.com/careers/details/?id=junior-qa-engineer)

This is my assignment for the QA Engineer test - A C# standalone test automation project that uses AltTester for Unity game testing.

## Overview

This project contains automated tests for a Unity application using the AltTester framework. Unity game was compiled from [provided project](https://github.com/Estoty/qa-engineer-test) to several [platforms](#Available-builds-for-testing) with help of [AltTester Unity package](https://alttester.com/docs/sdk/latest/pages/get-started.html#import-alttester-package-in-unity-editor).

## Test Cases

1. **CountInteractable**: Verifies that the submit button is interactable
2. **CountIncreasedAfterClick**: Tests that the counter increases after clicking
3. **CountAfterXClicks**: Parameterized test that verifies exact count after multiple clicks (10 by default)

## Prerequisites

- [.NET 9.0 or later](https://dotnet.microsoft.com/en-us/download) is installed
- Unity application with AltTester integration - If you don't have your own use [this](#Available-builds-for-testing)
- [The AltTester® Desktop](https://alttester.com/downloads/) installed on your PC


## Getting Started

### 1. Clone the Repository
```bash
git clone https://github.com/AnubisDunk/Alttester-standalone.git
cd Alttester-standalone
```

### 2. Build the Project
```bash
dotnet build
```
### 3.Run and connect to the app
1. Run The AltTester® Desktop app
2. Run desired [instrumented build](#Available-builds-for-testing)
3. Configure the IP of the build in order to match the IP of the machine (PC) the Desktop app is running on. (Leave it as default for Desktop/WebGL)
4. Then press the restart button in the AltTester® dialog and wait until the **Connected to AltTester® Server...** message is displayed in the dialog.

**⚠️ Important**: Your game must be connected to AltTester Desktop before running tests!

### 4. Run Tests
```bash
# Run all tests
dotnet test

# Run specific test
dotnet test --filter "CountInteractable"

```

## Available builds for testing
- Windows - Located in *Builds/build_win.rar*
- Android - Located in *Builds/build_android.apk*
- [WebGL version](https://anubisdunk.itch.io/qa-test-estoty) - Published on itch.io (Password: *alexQA12#*)

## AltTester Unity SDK Package *(Optional)*
Unity game was compiled from [provided project](https://github.com/Estoty/qa-engineer-test) to several [platforms](#Available-builds-for-testing) with help of [AltTester Unity package](https://alttester.com/docs/sdk/latest/pages/get-started.html#import-alttester-package-in-unity-editor). Generated package with [included tests](#Test-Cases) are located in *Build* folder(AltTester_2_2_5.unitypackage). If needed can be installed into Unity project following the [guide](https://alttester.com/docs/sdk/latest/pages/get-started.html#resolve-dependencies)
1. Install [QA Engineer Test](https://github.com/Estoty/qa-engineer-test) project
2. Add *AltTester_2_2_5.unitypackage* to the Unity project. (*Assets -> Import Package*)
2. Resolve dependencies by putting missing ones to *manifest.json* 

```json 
{
  "dependencies": {
    // other dependencies...
    "com.unity.nuget.newtonsoft-json": "3.1.0",
    "com.unity.editorcoroutines": "1.0.0"
  },
  "testables": [
    "com.unity.inputsystem"
  ]
}
```
4. Now you have AltTester Editor in your Unity project, can run test in Editor

## Dependencies

- **AltTester Driver**: Unity game testing framework
- **NUnit**: Unit testing framework for .NET

## Resources

- [QA Engineer Test](https://github.com/Estoty/qa-engineer-test) project was used to build Unity apps
- [AltTester Documentation](https://alttester.com/docs/)
- [NUnit Documentation](https://docs.nunit.org/)

## Author

> Aleksandrs Baranovskis

[Website](https://anubisdunk.com/cv)
[Steam](https://steamcommunity.com/id/anubisdunk)
[Github](https://github.com/AnubisDunk)