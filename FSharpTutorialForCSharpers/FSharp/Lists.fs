namespace FSharp

module Collections =

    // -------------
    // Lists
    // -------------

    let empty : string list = []
    let simpsons = ["Homer"; "Bart"; "Marge"; "Lisa"; "Maggie"]
    // : string list

    // produce lists
    let oneToTen = [1..10]
    let oddOneToTen = [1..2..10]
    let squares = [for i in 1 .. 10 -> i * i]

    // add element
    let simpsonsAndCat = "Snowball" :: simpsons
    let simpsonsAndCats = simpsons @ ["Snowball I"; "Snowball II"; "Snowball III"; "Snowball IV"; "Snowball V"; ]

    // get first element
    let elem1stUnsafe = List.head squares
    let elemt1stFailing = List.head empty

    let elem1stOptional = List.head empty
            
    // let elem1st :: _ = squares // --> compiler error
    let elem1stMatched = match empty with
                         | x :: _ -> x
                         | [] -> "was empty"

    // Mapping
    let simpsonsFullnames = simpsons 
                            |> List.map (fun s -> s + " Simpson")

    let squaresMapped = [1 .. 10]
                        |> List.map (fun i -> i*i)

    let squaresReduced = [1 .. 10]
                         |> List.map (fun i -> i*i)
                         |> List.reduce (+)

    let allSimpsons = simpsons
                      |> List.reduce (sprintf "%s, %s")

    let rec printAllNames entries =
        match entries with
        | name :: rest -> printfn "%s Simpson" name
                          printAllNames rest
        | [] -> ()
    printAllNames simpsons

    let rec printAllNames2 = function
        | name :: rest -> printfn "%s Simpson" name
                          printAllNames rest
        | [] -> ()

    // -------------
    // Arrays
    // -------------

    let emptyArray : string[] = [||]
    let simpsonArray = [|"Homer"; "Bart"; "Marge"; "Lisa"; "Maggie"|]
    // : string []


    let oneToTenArray = [| 1 .. 10 |]
    let oddOneToTenArray = [| 1 .. 2 .. 10 |]
    let squaresArray = [|for i in 1 .. 10 -> i * i|]


    // -------------
    // Enumerables
    // -------------

    let emptySeq = Seq.empty<string>

    let single = Seq.singleton 123

    let simpsonSeq = seq {
        yield "Homer"
        yield "Bart"
        yield "Marge"
        yield "Lisa"
        yield "Maggie"
    }
    // : seq<string>

    let oneToTenSeq = seq { 1 .. 10 }
    let oddOneToTenSeq = seq { 1 .. 2 .. 10 }
    let squaresSeq = Seq.initInfinite (fun i -> i*i)
    let elem99th = squaresSeq 
                    |> Seq.skip 98 
                    |> Seq.head

