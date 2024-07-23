```fsharp
open System

printf "What is your name: "
let name = Console.ReadLine() // string
printfn "Hello %s" name
```

Three ways to work with F#:

1. Interactive - Execute snippets using Alt+Enter

2. 


Introducing "let something = something else"

```fsharp
let x = 42 // int
```

x is and immutable *value*
Everywhere you see "x" you can replace it with 42

```fsharp
let x : int = 42 
```
Colon us for type annotations

Let is used to define functions as well

```fsharp
let add x y = x + y // int -> int -> int
```

Two parameter function, requires spaces between params and no return keyword

Test it

```fsharp
add 2 3
```

space between params, except when calling OO code like .NET library

Code blocks are represented by indentation

```fsharp
let square x = // -> int
    x * 2
```

```fsharp
let double x = // int -> int
    let two = 2
    x * two
```

```fsharp
let squareAndDouble x = // int -> int
    let v = square x
    double y // No return keyword
```

How to convert from a C-style language to F#

- Change to "let ... =" for definitions
- Indent how you normally would
- Delete the {}
- Delete "return"
- Delete semicolons
- You often can delete type annotations as well!

```c
int squareAndDouble(int x)
{
    var y = square(x);
    return double(y);
}
```

```fsharp
let squareAndDouble x =
    let y = square x
    double y
```

```python
def squareAndDouble(x):
    y = square(x)
    return double(y)
```

## Computation expressions: Special code blockswith customizable behavior

```fsharp
let downloadFile filename : Async<string> = failwith "not implemented"

let uploadFile filename url : Async<unit> = failwith "not implemented"
```

```fsharp
let downloadManyFiles() =
    async {
        let! contentsA = downloadFile "source/a.txt"
    do! uploadFile contentsA "target/a.txt"
    return "OK"
    }
```

In an `async` computation expression, let! is like `await` and do! is like `await void`

Computation expressions are used for:
- async/task
- queries (like query expression in C#)
- generating collections/enumerables
- validation
- error handing
- testing
- code generation
- etc etc

Generate an sequence/enumerable

```fsharp
seq {
    yield! [1..10]
    for i in [1..10] do yield square i
}   
```

Dummy database

```fsharp
let db = // {| Student: list<{| Name: string; StudentId: int |}> |}
    {|Student = [
        {[Student=1; Name="Alice"|}
        {[Student=42; Name="Bob"|}
    ] |}
```

Query a database

```fsharp
query {
    for student in db.Student do
    where (student.StudentId > 4)
    sortBy student.Name
    select student
}
```

Introducing the pipeline operator

```fsharp
let add42 x = x + 42

let squareDoubleAdd42 x = 
    x |> square |> double |> add42

    add42(double(square(x)))
```

## Pipelines are a bit like LINQ

```fsharp
open System // same as "using"
open System.Linq

[1..10]
    .Select(fun x -> x * 2) // lambda syntax in F#
    .Where(fun x -> x <= 6)
    .Select(fun x -> String.Format($"x={x}"))
    .ToArray()

[1..10] // int list
|> List.map (fun x -> x * 2) // int list
|> List.filter (fun x -> x <= 6) // int list
|> List.map (sprintf "x=%i") // string list
```

Pipelines are more flexibles because you don't need extension methods

```fsharp
let product aList = 
    List.fold (*) 1 aList

let logToConsole input =
    printfn "input=%i" input
    input

[1..10]
|> List.map (fun x -> x * 2)
|> List.filter (fun x -> x <= 6)
|> product
|> logToConsole
```

## SOLID

SOLID works well with functional programming

Open-closed principle:
You can add new code, but don't change existing code

Pipeline-oriented programming is a good technique for this!

```fsharp
// Some dummy functions

let log label input = failwith "not implemented"
let checkAuthorization query = failwith "not implemented"
let loadFromDB (query:string) :string = failwith "not implemented"

open System.Text.Json

let myImportantWorkflow query =
    // Onion architecture: I/O at edges

    query
    |> checkAuthorization
    |> loadFromDb
    |> JsonSerializer.Deserialize
    |> log "before processing"

    // Pure domain logic
    |> List.map(fun x -> x * 2)
    |> List.filter (fun x -> x <= 6)

    // I/O
    |> log "after processing"
    |>JsonSerializer.Serialize
    |>saveToDb
```

## How Type inference works

## Group by method

## Choice type
