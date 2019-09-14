module PP0502B

open System

[<EntryPoint>]
let main argv =

    let mutable results : string list = []
    let mutable i = 0
    let count = Console.ReadLine() |> int
    while (i < count) do
        let x = Console.ReadLine()
        let y = x.Split ' ' 
                |> Array.skip 1
                |> Array.rev 
                |> String.concat " "
        results <- y :: results
        i <- i + 1

    i <- count - 1
    while (i >= 0) do
        Console.WriteLine(results.[i])
        i <- i - 1

    0
