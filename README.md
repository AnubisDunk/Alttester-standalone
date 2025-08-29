# AltTester Standalone

A C# test automation project using AltTester SDK for Unity game testing.

## Overview

This project contains automated tests for Unity applications using the AltTester framework. AltTester enables UI testing for Unity games by providing an API to interact with game objects and components.

## Prerequisites

- .NET 9.0 or later
- Unity application with AltTester integration
- NUnit testing framework

## Project Structure

```
Alttester-standalone/
├── Tests/
│   └── GameTests.cs          # Main test file with UI automation tests
├── bin/                      # Build output (excluded from git)
├── obj/                      # Build artifacts (excluded from git)
├── Alttester-standalone.csproj
├── Alttester-standalone.sln
└── README.md
```

## Dependencies

- **AltTester SDK**: Unity game testing framework
- **NUnit**: Unit testing framework for .NET
- **NUnit3TestAdapter**: Test adapter for running NUnit tests

## Test Cases

### Current Tests

1. **CountInteractable**: Verifies that the submit button is interactable
2. **CountIncreasedAfterClick**: Tests that the counter increases after clicking
3. **CountAfterXClicks**: Parameterized test that verifies exact count after multiple clicks

### Test Features

- **SetUp**: Connects to Unity application via socket, loads test scene
- **TearDown**: Properly closes connection after each test
- **Element Finding**: Locates UI elements by name
- **Component Interaction**: Gets component properties and performs actions
- **Assertions**: Validates expected behavior with descriptive messages

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

### 3. Run Tests
```bash
# Run all tests
dotnet test

# Run specific test
dotnet test --filter "CountInteractable"

# Run with verbose output
dotnet test --logger "console;verbosity=detailed"
```

## Unity Setup Requirements

Your Unity project must have:

1. **AltTester Package**: Install AltTester from Unity Package Manager
2. **AltTester Component**: Add AltTester component to a GameObject in your scene
3. **Test Scene**: A scene named "SampleScene" with:
   - A button named "SubmitButton"
   - A text/label component named "Count"

## Configuration

### Connection Settings
- **Default Port**: 13000 (AltTester default)
- **Connection Timeout**: 30 seconds
- **Target Scene**: "SampleScene"

### Modifying Tests

To adapt tests for your Unity application:

1. Update scene name in `SetUp()` method
2. Modify element names in `FindObject()` calls
3. Adjust component properties and namespaces as needed

## Troubleshooting

### Common Issues

**Connection Timeout**
- Ensure Unity application is running
- Verify AltTester is properly configured in Unity
- Check firewall settings

**Element Not Found**
- Verify object names match exactly (case-sensitive)
- Ensure scene is fully loaded before finding objects
- Check object hierarchy and naming

**Test Failures**
- Review TestContext output for detailed error messages
- Verify Unity application state matches test expectations
- Check component properties and methods exist

## Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/new-test`)
3. Commit your changes (`git commit -am 'Add new test case'`)
4. Push to the branch (`git push origin feature/new-test`)
5. Create a Pull Request

## Best Practices

- **Descriptive Test Names**: Use clear, descriptive names for test methods
- **Proper Cleanup**: Always include teardown to close connections
- **Assertions with Messages**: Provide meaningful failure messages
- **Parameterized Tests**: Use TestCase attributes for testing multiple scenarios
- **Wait Strategies**: Use appropriate waits for UI elements to load

## License

This project is open source. Please refer to the license file for details.

## Resources

- [AltTester Documentation](https://alttester.com/docs/)
- [NUnit Documentation](https://docs.nunit.org/)
- [Unity Testing Documentation](https://docs.unity3d.com/Manual/testing-editortestsrunner.html)
