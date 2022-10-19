open System

let HolaMundo() =  
    printf "Dime tú nombre: "

    let nombre = Console.ReadLine()
    
    printf "Hola %s desde FSharp" nombre 

HolaMundo()

Console.ReadKey() |> ignore