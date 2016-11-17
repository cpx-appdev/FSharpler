namespace FSharp

open System

module Functions = 

    let AplusB a b = a + b              //  : a:int -> b:int -> int
    let summe = AplusB 1 2

    // Tupel dann verwenden, wenn die Parameter immer zusammen gesetzt werden!
    let AplusB_Tuple (a, b) = a + b     // : a:int * b:int -> int
    let summe2 = AplusB_Tuple (1, 2)    // : int = 3

    let AplusB_Partial a = (+) a        // : a:int -> (int -> int)
    let summe3 = AplusB_Partial 1 2     // -> ist linksassoziativ, die Klammern sind daher optional

    let AplusB_Alias = (+)              // : (int -> int -> int)
    let summe4 = AplusB_Alias 1 2

    // Vergleiche (int -> int) -> int
    let OnePlusMapTwo f = 1 + (f 2)     // : f:(int -> int) -> int
    let summe5 = OnePlusMapTwo (fun a -> a * a) // : int = 5

    // jede Funktion hat exakt eine Eingabe und eine Ausgabe !!
    let getPi () = 3.14159              // : unit -> float
    let pi = getPi()                    // : float = 3.14159

    let printValue i = printfn "Value = %i" i // : i:int -> unit
    printValue 123                            // : unit = ()


    // Partial application
    let AddToHundred = AplusB 100       // : (int -> int)
    let summe6 = AddToHundred 1         // : int = 101

    let Greetings = sprintf "Grüße von %s aus %s" // : (string -> string -> string)
    let grüße = Greetings "Homer" "Springfield"        // : string = "Grüße von Tino aus Leipzig"

    let GrüßeVonHomer = Greetings "Homer" // : (string -> string)
    let grüße2 = GrüßeVonHomer "Springfield"

    
    // Composing functions

    let timesTwo x = 2 * x
    let square x = x * x
    let printNumber = printfn "Result: %i"

    let print2xSquared x = 
        printNumber (square (timesTwo x))
    print2xSquared 5

    let print2xSquaredPiped x =
        timesTwo x
        |> square
        |> printNumber
    print2xSquaredPiped 5

    let print2xSquaredComposed =
        timesTwo >> square >> printNumber
    print2xSquaredComposed 5
