module FileCommImpl

open System.IO

type FileImpl(input,results) =
    [<DefaultValue>] val mutable private index : int
    member this.Input : string list = input
    do if File.Exists results then
            do File.Delete results
    
    let result = new StreamWriter(File.Create(results))

    member this.Results = result
        

    member this.Close () = this.Results.Close()

    interface Day8DictionariesMaps.ICommInterface with
        member this.ReadLine(): string =
            if this.index < this.Input.Length then
                let res = this.Input.[this.index]
                this.index <- this.index + 1
                res
            else
                ""

        member this.WriteLine(value: string): unit = 
            this.Results.WriteLine(value)