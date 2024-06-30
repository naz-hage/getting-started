Last Modified: 30-jun-2024
This list updated very often.  Please check back often.
**Best Practices for Modern Software Development in Windows Environments**

1. Ensure all code is managed using a modern Source Code Management system like GitHub Enterprise, adhering to IT policies.
2. Utilize a modern IDE like Visual Studio 2022 for Windows clients, which supports IntelliSense, refactoring, and static code analysis.
3. Adopt C# version 11.0 or higher for development.
4. Use C++20 or higher for C++ projects.
5. For Windows 11 or higher client applications, employ WinRT.
6. Utilize .NET version 8.0 or higher for cross-platform application development.
7. Optimize executables by structuring functionality into well-named classes, with each class containing relevant methods.
8. Implement a common static class dedicated to input validation.
9. Exercise caution with public global properties to prevent external manipulation of execution flow.
10. Eliminate code redundancies by centralizing common code into a shared class.
11. Design classes with clear intentions, including only methods that serve the class's purpose.
12. Aim for shorter methods with clear signatures, limiting arguments to no more than two or three per method.
13. Prefer named parameters for method calls to enhance readability.
14. Avoid using boolean parameters in methods; consider alternative designs.
15. Ensure each method validates its input and fails fast upon receiving incorrect arguments.
16. Avoid catching exceptions within class methods unless they are explicitly handled.
17. Incorporate unit tests for all methods, focusing on the newly shortened ones.
18. Rename methods to clearly convey their purpose.
19. When invoking methods that require boolean arguments, use named parameters for clarity, e.g., `SaveOption: true`.
20. Regularly run static code analysis to identify and resolve potential code issues.
21. For C++ development, stick to standard C++ or WinRT as appropriate.
22. When launching executables, configure them to trigger the User Account Control (UAC) prompt, ensuring security best practices.
