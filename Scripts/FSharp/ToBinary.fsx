
let  f k =
    let rec pos i = 
        match i with
        | 0 | 1 -> [string i ]
        | _ -> (pos (i / 2)) @ pos (i % 2)

    if k < 0 then 
        let rs = pos (-k) |> List.map(fun x -> if x = "0" then "1" else "0")
        let f a x = 
            match x, a with
            | "0", "0" -> "0", "0"
            | "1", "1" -> "0", "1"
            | _  -> "1", "0"
        List.mapFoldBack f rs "1" |> fst

    else pos k

f  9 |> printfn "%A"
f -9 |> printfn "%A"
