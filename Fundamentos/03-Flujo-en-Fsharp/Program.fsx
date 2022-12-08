//Lógica condicional//

//Ramas en el código//

// let age = 17
// if age >= 18
// then printfn "Eres mayor de edad"
// else printfn "Eres menor de edad"


//Expresión ternaria//

// let age = 17
// //unit es un valor que actúa como marcador de posición cuando no se devuelve ningún valor real. Puede pensar en él como void o None.
// let mensaje = if age >= 18 then "Eres mayor de edad" else "Eres menor de edad"
// printfn "%s" mensaje

//Elif//
//la construcción elif toma un valor booleano que se debe agregar justo después de if. La construcción elif se ejecuta si if se evalúa como false. Este es un ejemplo de cómo usar elif

// let valorCarta = 141
// let descripcionCarta = if valorCarta = 1 then "Ace" elif valorCarta = 14 then "Ace14" else "A card"
// printfn "%s" descripcionCarta

//Naipes//
// let valorCarta = 14
    
// let descripcionCarta =
//     if valorCarta = 1 then "Ace"
//     elif valorCarta = 11 then "Jack"
//     elif valorCarta = 12 then "Queen"
//     elif valorCarta = 13 then "King"
//     else string valorCarta

// printfn "%s" descripcionCarta

//Bucles, si bucles//

//for ... in

// let list = [1; 2; 3; 4; 5] //Expresión enumerable
// for i in list do //Patrón de enumeración y expresión enumerable
//    printf "%d " i //Expresión de cuerpo

// printfn ""

// //for ... to

// for i = 1 to 10 do
//   printf "%i " i  // prints 1 2 3 4 5 6 7 8 9 10

// printfn ""
// //for ... downto

// for i = 10 downto 1 do
//   printf "%i " i  // prints 10 9 8 7 6 5 4 3 2 1

// printfn ""

//while ... do

// let mutable quit = false
// let no = 11
// while not quit do //Mientras quit sea falso:not
//     printf "Adivina un número: "
//     let guess = System.Console.ReadLine() |> int
//     if guess = no then
//       quit <- true //Si adivinaste el número, quit es verdadero
//       printfn "Adivinaste, %i es el número secreto" no
//     else
//       printfn "%i es incorrecto" guess

//Naipes con bucles//

let suit (no:int) : string = 
    let suitNo:int = no / 13 //Dividimos el número de la carta entre 13 para obtener el número de palo
    if suitNo = 0 then "Hearts"
    elif suitNo = 1 then "Spades"
    elif suitNo = 2 then "Diamonds"
    else "Clubs"

//La función se denomina cardDescription y el parámetro de entrada es card
let cardDescription (card: int) : string =
    let cardNo: int = card % 13 //Obtenemos el resto de la división de card entre 13, que es el número de la carta en el palo
    printfn "cardNo: %i" cardNo
    if cardNo = 1 then "Ace"
    elif cardNo = 11 then "Jack"
    elif cardNo = 12 then "Queen"
    elif cardNo = 0 then "King"
    else string cardNo 
    

let cards = [1; 10; 34; 13]
for card in cards do
    printfn "%s of %s" (cardDescription card) (suit card)
