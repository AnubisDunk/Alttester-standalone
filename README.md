# AltTester Standalone - QA Engineer test

A C# test automation project using AltTester SDK for Unity game testing.

## Overview

This project contains automated tests for Unity applications using the AltTester framework. AltTester enables UI testing for Unity games by providing an API to interact with game objects and components.

## Prerequisites

- .NET 9.0 or later
- Unity application with AltTester integration
- NUnit testing framework

## Dependencies

- **AltTester Driver**: Unity game testing framework
- **NUnit**: Unit testing framework for .NET

## Test Cases

### Current Tests

1. **CountInteractable**: Verifies that the submit button is interactable
2. **CountIncreasedAfterClick**: Tests that the counter increases after clicking
3. **CountAfterXClicks**: Parameterized test that verifies exact count after multiple clicks

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

## Configuration

### Connection Settings
- **Default Port**: 13000 (AltTester default)

## Troubleshooting

### Common Issues

**Connection Timeout**
- Ensure Unity application is running
- Verify AltTester is properly configured in Unity
- Check firewall settings

## Resources

- [AltTester Documentation](https://alttester.com/docs/)
- [NUnit Documentation](https://docs.nunit.org/)
