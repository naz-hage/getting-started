# Create a simple project

This repo has 3 components:
- `Display`: a console app
- `DisplayLib`: a class library
- `DisplayTests`: unit tests for `DisplayLib`


The commands below document how they were created:

1. Create a new console app `Display`

```
dotnet new console --name Display
```
2. Create a new class library `DisplayLib`

```
dotnet new classlib --name DisplayLib
```
3. Follow the [instructions](https://learn.microsoft.com/en-us/visualstudio/test/getting-started-with-unit-testing?view=vs-2022&tabs=dotnet%2Cmstest#create-unit-tests) to create `DisplayTests` (unit tests for `DisplayLib`)
