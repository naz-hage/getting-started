Last Modified: 02-oct-2023
This list updated very often.  Please check back often.
- Write code using modern Source code managment and adhere to IT policies. i.e.GitHub Enterprise
- Write code using modern IDE which incldes intellesense, refactor, and use static code analysis
    For Windows clients use Visual Studio 2022
- Use C# 9.0 or higher
- Use C++ 20 or higher
- Use WinRT for Windows 10 applications
- Use .NET 7.0 or higher for cross platform applications
- Reduce executables by moving functionality to well named classes which each class including the desired methods
- Create common static class for validating input
- Pay special attention to public global properties which can be controlled by outside to change direction of execution
- Remove redunduncies in code by moving common code to a common class
- Create well intentions class that include methods to fullfill the class intentions and nothing else
- Shorter methods with clear method signatures - no more 2 or three arguments per method
- Use named parameters when calling methods
- Avoid using bool parameters in methods 
- Each method must validate input and fail fast when incorrect arguments are passed
- Don't catch exceptions in class methods unless they are handled
- Add unit tests for the shorter methods
- Rename methods to show intentions
- When calling methods which requires boolean such as true or false, use named parameters such as SaveOption:true
- Run static code analysis
- For c++, use std c++ or winrt.
- When launching executable, allow UAC to de displayed