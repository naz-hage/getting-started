# Getting Started
- This repo is a template for creating a new .NET Core Desktop project with a GitHub Actions pipeline using `NTools`.

- Steps to create a new project using this template
  - [Create a simple project](docs/01-first-steps.md)
  - [Install ntools and add nbuild.targets](docs/02-nbuild.targets.md)
  - [Add DevSetup folder to setup the development environment](docs/02-dev-setup.md)
  - [Add GitHub workflow - issue #6](https://github.com/naz-hage/getting-started/issues/6)


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
