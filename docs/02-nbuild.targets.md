# Add nbuild.targets

- Follow [documentation](https://naz-hage.github.io/ntools/) to install `ntools`
- Add [nbuild.targets](https://naz-hage.github.io/ntools/setup/#nbuildtargets) file
- Open a VS command Prompt for Visual studio
   - Change to project working directory
   -  Run
```
nb staging 
nb production
```
- Ensure that ntools runs pass

## Add more targets
- Check [this example](../nbuild.targets#L56-L61): a target was added to build and test without changing the tag)
- This will create the command below
```
nb build_test
```
