module VSR

open System
let rec averageSpeed (counter : int, numbers : string) =
    let splittedNum = numbers.Split(' ') |> Seq.map System.Int32.Parse |> Seq.toArray
    let splittedSum = splittedNum |> Seq.sum
    Console.WriteLine(2 * splittedNum.[0] * splittedNum.[1] / splittedSum)
    if counter > 1 then averageSpeed (counter-1, Console.ReadLine() |> string)

[<EntryPoint>]
let main args =
    averageSpeed (Console.ReadLine() |> int, Console.ReadLine() |> string)
    0