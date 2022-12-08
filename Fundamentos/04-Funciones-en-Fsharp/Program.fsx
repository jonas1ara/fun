// //Fundamentos//
// //let <function name> <parameters> = <function body>
// let a = 1
// let b = 2
// let c = 3

// let add a b = a + b

// //En F# lo que se devuelve es la información de la última línea de una función

// let addAndMultiply a b c = 
//     let suma = a + b
//     let producto = suma * c
//     producto
// //Si no se especifica el tipo de retorno, se infiere el tipo de retorno de la última expresión de la función

// let sum = add a b
// printfn "%d" sum
// printfn "%d" (addAndMultiply a b c)

// //Funciones con tipos explícitos//
// let convert (a:string) :int = //Parametro de tipo string y retorno de tipo int
//     int a

// let cardFace (card:int) :string = 
//    let no = card % 13
//    if no = 1 then "Ace"
//    elif no = 0 then "King"
//    elif no = 12 then "Queen"
//    elif no = 11 then "Jack"
//    else string no

// printfn "%s" (cardFace 11)

//Patrones funcionales//
//Composición: una composición combina varias funciones en una sola.
//Canalización: una canalización comienza con un valor y, luego, llama secuencialmente a muchas funciones usando la salida de una función como entrada de la siguiente.

//Composición//
// let add2 a = a + 2
// let multiply3 a = a * 3 
// let addAndMultiply a =
//     let sum = add2 a
//     let product = multiply3 sum
//     product

// printfn "%i" (addAndMultiply 2) // 12

// //Composición//
// let add2 a = a + 2
// let multiply3 a = a * 3 
// let addAndMultiply = add2 >> multiply3

// printfn "%i" (addAndMultiply 2) // 12

//Canalización//

// let list = [4; 3; 1]
// let sort (list: int list) = List.sort list
// let print (list: int list)= List.iter(fun x-> printfn "item %i" x) list

// list |> print  // item 4 item 3 item 1
// printfn"-----------------"
// list |> sort |> print // item 1 item 3 item 4

let cards = [21; 3; 1; 7; 9; 23]
let cardFace card = 
    let no = card % 13
    if no = 1 then "Ace"
    elif no = 0 then "King"
    elif no = 12 then "Queen"
    elif no = 11 then "Jack"
    else string no

let suit card =
    let no = card / 13
    if no = 0 then "Hearts"
    elif no = 1 then "Spades"
    elif no = 2 then "Diamonds"
    else "Clubs"

let shuffle list =
    let random = System.Random()
    list |> List.sortBy (fun x -> random.Next())

let printCard card = printfn "%s of %s" (cardFace card) (suit card)

let printAll list = List.iter(fun x -> printCard(x)) list

let take (no:int) (list) = List.take no list

cards |> shuffle |> take 3 |> printAll