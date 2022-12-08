//Estructuras de datos en Fsharp

//Colleciones
//Las listas son estructuras de datos que contienen una secuencia de elementos.
//Las listas son inmutables, es decir, no se pueden modificar una vez creadas.

// let cards = ["Ace"; "King"; "Queen"]
// let  newList = "Jack" :: cards

// let otherCardList = ["Jack"; "10"]
// let fullList = cards @ otherCardList // "Ace", "King", "Queen", "Jack", "10"


// //Agregar elementos a una lista con append
// let cards = ["Ace"; "King"; "Queen"]
// let otherCardList = ["10"; "9"]
// let fullList = cards |> List.append ["Jack"] // "Jack", "Ace", "King", "Queen"
// let fullList1 = cards |> List.append otherCardList // "10", "9", "Ace", "King", "Queen"

// printf "{cards.Item 0}" // "Ace"

//Cartas// Propiedades de las listas//
// let cards = [ 0 .. 5 ]

// let drawCard (list:int list) = 
//     printfn "%i" list.Head
//     list.Tail

// let result = cards |> drawCard |> drawCard |> drawCard// 0 1

// let cards = [ 0 .. 5 ]

// let hand = []

// let drawCard (tuple: int list * int list) = 
//     let deck = fst tuple
//     let draw = snd tuple
//     let firstCard = deck.Head
//     printfn "%i" firstCard

//     let hand = 
//         draw
//         |> List.append [firstCard]

//     (deck.Tail, hand)

// let d, h = (cards, hand) |> drawCard |> drawCard

// printfn "Deck: %A Hand: %A" d h // Deck: [2; 3; 4; 5] Hand: [1; 0]

//Operaciones con listas//
// let cards = [ 1 .. 5 ]
// List.iter(fun i -> printfn "%i" i) cards // 1 2 3 4 5

//for i in cards do printfn "%i" i
//iter recorre la lista
//fun i -> printfn "%i" i es una función anónima que recibe un entero y lo imprime

//map
// type Person = { FirstName: string; LastName: string  }
// let people = [
//    { FirstName="Albert"; LastName= "Einstein" }
//    { FirstName="Marie"; LastName="Curie" }
// ]
// let nobelPrizeWinners = List.map (fun person -> person.FirstName + person.LastName) people 
// printfn "%A" nobelPrizeWinners // ["Albert Einstein"; "Marie Curie"]

//filter
// //La función filter() también toma una función como parámetro, pero su propósito es definir los elementos que se conservarán. Si la evaluación de la expresión es true, se mantiene el elemento. Si la expresión es false, el elemento no formará parte de la lista filtrada.
// let cards = [ 1 .. 5 ]
// let filteredList = List.filter(fun i-> i % 2 = 0) cards
// List.iter(fun i -> printfn "item %i" i) filteredList // item 2 item 4

// //sort
// let list = [2; 1; 5; 3]
// let sortedList = List.sort list // 1 2 3 5

// let fruits = ["Banana"; "Apple"; "Pineapple"]
// let sortedFruits = List.sortBy (fun (fruit : string) -> fruit.Length) fruits // Apple, Banana, Pineapple

//Busqueda

let list = [1; 2; 3; 4]
let found = List.find( fun x -> x % 2 = 0) list // 2 - Only the first element that matches the condition is returned.

