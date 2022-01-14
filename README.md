# Interactive + FCS + Ionide.ProjInfo

Unfortunately code is not working in .NET interactive while it works fine in FSI.

Repro steps:
1. Clone repo
2. Run `dotnet build Sample` to restore and build sample project
3. Run `dotnet fsi exploration.fsx` to check if code is working correctly (it should output blob of data related to the project)
4. Open folder in VSCode and try to run `Exploration.dib` notebook. It contains same file code as `exploration.fsx` file. However it's not working. In the output you'll see some error coming from MsBuild