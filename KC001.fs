module KC001

open System

let rec sumValues(a : int, b : int, c : int) =
    Console.WriteLine(a + b + c)

[<EntryPoint>]

let main args =
    sumValues(Console.ReadLine() |> int, Console.ReadLine() |> int, Console.ReadLine() |> int)
    0