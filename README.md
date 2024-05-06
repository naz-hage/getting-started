# Getting Started
- This repo is a template for creating a new .NET Core Desktop project with a GitHub Actions pipeline using `NTools`.

- It consists of:
  - `Display`: a console app (Created using `dotnet new console --name Display`)
  - `DisplayLib`: a class library (Created using `dotnet new classlib --name DisplayLib`)
  - `DisplayTests`: unit tests for `DisplayLib` (Learn how to [create unit tests](https://learn.microsoft.com/en-us/visualstudio/test/getting-started-with-unit-testing?view=vs-2022&tabs=dotnet%2Cmstest#create-unit-tests))

- List steps to create a new project using this template
  - issue [#7](https://github.com/naz-hage/getting-started/issues/7)


- Ntools documentation can be found [here](https://naz-hage.github.io/ntools/)
- Steps to build, test and run the project are given below:
  - Open a PowerShell terminal in admin mode
  - Run 
    ```shell
    cd c:\source
    git clone https://github.com/naz-hage/getting-started
    cd getting-started
    cd DevSetup
    .\DevSetup.ps1
    cd ..
    ```
  - To build the project, open a PowerShell for VS 2022:
  - To build the project
    ```shell
    cd c:\source\getting-started
    nb solution
    ```
  - To test the project
    ```shell
    cd c:\source\getting-started
    nb test
    ```
  - To build a staging environment
    ```shell
    cd c:\source\getting-started
    nb staging
    ```
  
  - To build a production environment
    ```shell
    cd c:\source\getting-started
    nb production
    ```
  - To deploy a production environment
    ```shell
    cd c:\source\getting-started
    nb deploy
    ```
