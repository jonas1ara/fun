//Fundamentos de F# - Datos//

// let mutable name = "Chris "

// let name2 = 1   
 
// let name3:float = 3.14

// let name4 = true

// printfn $"Entero: {name2}, Flotante: {name3} y Booleano: {name4}" //Sin comprobación de tipos

// name <- "Armando"

// printfn "Cadena: %s" name //Comprobación de tipos

//Convertir tipos de datos//

// System.Console.Write "Escribe algo:"
// let str = System.Console.ReadLine()
// printfn "Escribiste: %s" str

// let numberVersion = System.Int32.Parse str 
// printfn "Number %i" numberVersion // Output: Number 32

// let numberVersion2 = int str
// printfn "Number %i" numberVersion2 // Output: Number 32

//Operadores en Fsharp//

// let numero = 11
// let isDivisibleByTwo = numero % 2 = 0 //Función que devuelve un booleano
// printfn "Divisible by two: %b" isDivisibleByTwo

//Calculadora//

printfn "Bienvido a la calculadora de F#"
printfn "Escribe el primer número:"
let num1 = System.Int32.Parse(System.Console.ReadLine())

printfn "Escribe el segundo número:"
let num2 = System.Console.ReadLine() |> int

printfn "Primer numero: %i, Segundo numero: %i" num1 num2

let suma = num1 + num2 //suma
let resta = num1 - num2 //resta
let mul = num1 * num2 //multiplicación
let div = num1 / num2 //división

printfn "La suma es %i" suma
printfn "La resta es %i" resta
printfn "La multiplicación es %i" mul
printfn "La división es %i" div

// printfn "Escribe la operación que deseas realizar (+, -, *, /):"
// let op = System.Console.ReadLine()

// let result = 
//     match op with
//     | "+" -> num1 + num2
//     | "-" -> num1 - num2
//     | "*" -> num1 * num2
//     | "/" -> num1 / num2
//     | _ -> 0

// printfn "El resultado es: %i" result


