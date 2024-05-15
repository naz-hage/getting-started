# Add DevSetup

DevSetup Folder contains the apps.json file and the DevSetup.ps1 file. The apps.json file contains the list of development tools required for your project. The DevSetup.ps1 file is a PowerShell script that installs the development tools and sets up the development environment for the project.


- Follow [documentation](https://naz-hage.github.io/ntools/setup/#devsetup-folder) to construct DevSetup Folder
- Your file structure should look like this:
```
%MainDirectory%\MyProject
%MainDirectory%\MyProject\DevSetup
%MainDirectory%\MyProject\DevSetup\apps.json
%MainDirectory%\MyProject\DevSetup\apps-Ntools.json
%MainDirectory%\MyProject\DevSetup\DevSetup.ps1
%MainDirectory%\MyProject\... other project and test files
```
- Open a VS Powershell for Visual studio
- Change to project working directory
- Run
```
cd DevSetup
./DevSetup.ps1
```
- Ensure that installation passes
