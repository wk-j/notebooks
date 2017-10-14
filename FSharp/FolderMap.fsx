let input = ["0"; "1"; "1"];

let f a x = 
    match x, a with
    | "1", "1" -> "0", "1"
    | "1", "0" -> "1", "0"
    | "0", "1" -> "1", "0"
    | _ -> "0", "0"

List.mapFoldBack f input "1"
|> printfn "%A"


