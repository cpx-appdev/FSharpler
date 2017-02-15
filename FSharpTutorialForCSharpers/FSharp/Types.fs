namespace FSharp

open System

module Types = 

    // --------------------------
    // Primitive Typen
    // --------------------------
    let number = 2 // : int
    
    let floating = 1.0                  // : float

    let flag = true                     // : bool

    let text = "Text"                   // : string

    let leer : string = null

    // --------------------------
    // Tupel
    // --------------------------

    let coord = (123, 456)              // : int * int
    let price = (9.99, "€")             // : float * string    

    let coord3 = (123, (456, (789, "Hallo")))
    let (x, (y, (z, halloText))) = coord3

    // --------------------------
    // Discriminated Unions
    // --------------------------

    type Gender = Female | Male
    let male = Male                     // : Gender = Male

    type Gender2 = Female | Male | Transgender
    let male2 = Male

    // Enumeration
    type AccessMode = Read = 1 | Write = 2 | Delete = 4
    let mode1 = AccessMode.Write

    type PaymentMethod =
    | Cash
    | CreditCard of int * DateTime
    | Sepa of string * string

    let payWith = CreditCard (123455678, DateTime(2020, 1, 1))
    //  : PaymentMethod = CreditCard (123455678,01.01.2020 00:00:00)

    let nullstring : string option = None
    let somestring : string option = Some "Hallo Welt"

    let blubb = match nullstring with
                | Some text -> sprintf "%s" text
                | None -> "leider nix"

    // Single Choice Unions für Typsicherheit

//    type CustomerId = int
//    type PruductId = int
//    let getCustomer (id : CustomerId) = "abc";
//    let product1 : PruductId = 123
//    let oh_oh = getCustomer product1 // au wei !!!

    type CustomerId = CustomerId of int
    type ProductId = ProductId of int
    let product2 = ProductId 123
    let getCustomer2 (id : CustomerId) = "abc";
    //let error = getCustomer2 product2 // compiler error


    // --------------------------
    // Records
    // --------------------------

    type Address = {
        Street : string
        PLZ : string
    }

    type Person = { 
        FirstName : string;
        LastName : string;
        //DateOfBirth : DateTime;  // einkommentieren erzeugt Compilerfehler
        Address : Address
    }    
    
    let homer = { 
        FirstName = "Homer"; 
        LastName = "Simpson"; 
        //DateOfBirth = DateTime(1984, 3, 19);
        Address = { Street = "abc"; PLZ = "123" }
    }

    let homer2 = { homer with LastName="--"; Address = { Street = "abc"; PLZ = "123" }}

    let homer3 = { homer2 with Address = {homer2.Address with PLZ = "456" }}

    printfn "FSharp-Pretty-Print: %A" homer
    printfn "Object.ToString(): %O" homer

    let homer_firstname1 = homer.FirstName;

    let {FirstName = homer_firstname2 } = homer;

    let printName p = printfn "Hallo %s %s" p.FirstName p.LastName
    printName homer 


