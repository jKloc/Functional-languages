module POTSAM

open System

let resultResize = new ResizeArray<_>()
let rec check (number : string) =
    let splitted = number.Split(' ') |> Seq.map System.Int32.Parse |> Seq.toArray
    for i = 0 to splitted.Length - 1 do
        let splittedNumber = splitted.[i]
        if (i % 2 = 0) then
            let result = splittedNumber * splitted.[i+1]
            resultResize.Add(result)
    let resultList = Seq.toList resultResize
    Console.WriteLine(List.sum resultList)

[<EntryPoint>]

let main args =
    check (Console.ReadLine() |> string)
    0