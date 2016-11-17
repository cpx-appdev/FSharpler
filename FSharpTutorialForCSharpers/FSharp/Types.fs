namespace FSharp

open System

module Types = 

    // --------------------------
    // Primitive Typen
    // --------------------------
    let number = 1 // : int
    
    let floating = 1.0                  // : float

    let flag = true                     // : bool

    let text = "Text"                   // : string

    // --------------------------
    // Tupel
    // --------------------------

    let coord = (123, 456)              // : int * int
    let price = (9.99, "€")             // : float * string    

   

    // --------------------------
    // Discriminated Unions
    // --------------------------

    type Gender = Female | Male
    let male = Male                     // : Gender = Male

    // Enumeration
    type AccessMode = Read = 1 | Write = 2 | Delete = 4
    let mode1 : AccessMode = LanguagePrimitives.EnumOfValue 2

    type PaymentMethod =
    | Cash
    | CreditCard of int * DateTime
    | Sepa of string * string

    let payWith = CreditCard (123455678, DateTime(2020, 1, 1))
    //  : PaymentMethod = CreditCard (123455678,01.01.2020 00:00:00)


    // Single Choice Unions für Typsicherheit

    type CustomerId = int
    type PruductId = int
    let getCustomer (id : CustomerId) = "abc";
    let product1 : PruductId = 123
    let oh_oh = getCustomer product1 // au wei !!!

    type CustomerId2 = CustomerId of int
    type ProductId2 = ProductId of int
    let product2 = ProductId 123
    let getCustomer2 (id : CustomerId2) = "abc";
    // let error = getCustomer2 product2 // compiler error


    // --------------------------
    // Records
    // --------------------------

    type Person = { 
        FirstName : string;
        LastName : string;
        // DateOfBirth : DateTime  // einkommentieren erzeugt Compilerfehler
    }

    let homer = {FirstName = "Homer"; LastName = "Simpson" }
    printfn "FSharp-Pretty-Print: %A" homer
    printfn "Object.ToString(): %O" homer

    let homer_firstname1 = homer.FirstName;

    let {FirstName = homer_firstname2 } = homer;

    let printName p = printfn "Hallo %s %s" p.FirstName p.LastName
    printName homer 


