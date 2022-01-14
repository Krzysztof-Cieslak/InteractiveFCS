#r "nuget: Ionide.ProjInfo"
// #r "nuget: Ionide.ProjInfo.FCS"
// #r "nuget: FSharp.Compiler.Service"

open Ionide.ProjInfo
open System.IO
open System

let toolsPath = Init.init (DirectoryInfo Environment.CurrentDirectory) None
let props = [ ("Configuration", "Debug") ]
let workspaceLoader = WorkspaceLoader.Create (toolsPath, props)
let samplePath = Path.Join(Environment.CurrentDirectory, "Sample", "Sample.fsproj")

workspaceLoader.Notifications.Add (printfn "%A")

let parsedProject = 
    workspaceLoader.LoadProjects [samplePath]
    |> Seq.toArray
    |> Seq.head

// let fpo = FCS.mapToFSharpProjectOptions parsedProject []
// fpo

// open FSharp.Compiler.CodeAnalysis
// let checker = FSharpChecker.Create(keepAssemblyContents = true)
// let checkResults = checker.ParseAndCheckProject fpo |> Async.RunSynchronously
// checkResults.GetAllUsesOfAllSymbols()
// checkResults.AssemblyContents.ImplementationFiles