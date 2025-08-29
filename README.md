# AltTester Standalone - QA Engineer test

A C# test automation project using AltTester SDK for Unity game testing.

## Overview

This project contains automated tests for Unity applications using the AltTester framework. AltTester enables UI testing for Unity games by providing an API to interact with game objects and components.

## Test Cases

### Current Tests

1. **CountInteractable**: Verifies that the submit button is interactable
2. **CountIncreasedAfterClick**: Tests that the counter increases after clicking
3. **CountAfterXClicks**: Parameterized test that verifies exact count after multiple clicks (10 by default)

## Prerequisites

- [.NET 9.0 or later](https://dotnet.microsoft.com/en-us/download) is installed
- Unity application with AltTester integration
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
### Run and connect to the app
1. Run The AltTester® Desktop app
2. Run desired instrumented build
3. Configure the IP of the build in order to match the IP of the machine (PC) the Desktop app is running on. (Leave it as default for Desktop/WebGL)
4. Then press the restart button in the AltTester® dialog and wait until the **Connected to AltTester® Server...** message is displayed in the dialog.

### 3. Run Tests
```bash
# Run all tests
dotnet test

# Run specific test
dotnet test --filter "CountInteractable"

# Run with verbose output
dotnet test --logger "console;verbosity=detailed"
```

## Troubleshooting

### Common Issues

**Connection Timeout**
- Ensure Unity application is running
- Verify AltTester is properly configured in Unity
- Check firewall settings

## Dependencies

- **AltTester Driver**: Unity game testing framework
- **NUnit**: Unit testing framework for .NET

## Resources

- [AltTester Documentation](https://alttester.com/docs/)
- [NUnit Documentation](https://docs.nunit.org/)
