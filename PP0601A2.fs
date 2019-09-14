module PP0601A2

open System

let mutable earlierValue = 0
let mutable counter = 3

let rec readUntil42 input= 
    match input with 
    | "42" -> if input = "42" then
                if earlierValue = 42 then
                    Console.WriteLine(input) 
                    readUntil42(Console.ReadLine())
                else
                    if counter > 0 then
                        earlierValue <- Convert.ToInt32(input)
                        counter <- counter - 1
                        Console.WriteLine(input) 
                        readUntil42(Console.ReadLine())

    | _ -> earlierValue <- Convert.ToInt32(input)
           Console.WriteLine(input) 
           readUntil42(Console.ReadLine())

readUntil42(Console.ReadLine())