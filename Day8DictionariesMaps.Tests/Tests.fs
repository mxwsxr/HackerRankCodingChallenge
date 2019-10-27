module Tests

open System.IO
open Xunit
open FsUnit.Xunit

[<Fact>]
let ``Additional Test Case`` () =
    //Setup
    let input = File.ReadAllLines("./Data/Input/TestData.txt") |> Array.toList
    let result = File.ReadAllLines("./Data/Output/TestDataResults.txt")

    let fileImpl = FileCommImpl.FileImpl(input, "./results.txt")
    //Act
    Day8DictionariesMaps.Day8Solution.Execute fileImpl |> ignore
    fileImpl.Close()
    //Assert
    let writtenResults = File.ReadAllLines("./results.txt")
    writtenResults.Length |> should equal result.Length
    writtenResults |> Array.zip result |> Array.iter (fun x -> (snd x) |> should equal (fst x) )