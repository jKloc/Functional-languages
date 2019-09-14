module PP0501A

open System

let rec check(a: int, b: int) =
    if(b = 0)
    then Console.WriteLine(abs a)
    else check(b, (a % b))

let rec nwd(counter: int, numbers: string) =
    let splittedNum = numbers.Split(' ') |> Seq.map System.Int32.Parse |> Seq.toArray
    let a = splittedNum.[0]
    let b = splittedNum.[1]
    check(b, (a % b))
    if counter > 1 then nwd(counter-1, Console.ReadLine() |> string)

[<EntryPoint>]

let main args =
    nwd(Console.ReadLine() |> int, Console.ReadLine() |> string)
    0