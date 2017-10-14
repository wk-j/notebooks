
let  f k =
    let rec pos i = 
        match i with
        | 0 | 1 -> [string i ]
        | _ -> (pos (i / 2)) @ pos (i % 2)
    if k < 0 then 
        let wise x = if x = "0" then "1" else "0"
        let plus a x = 
            match x, a with
            | "0", "0" -> "0", "0"
            | "1", "1" -> "0", "1"
            | _  -> "1", "0"
        let rs = pos (-k) |> List.map(wise)
        let fst, snd = List.mapFoldBack plus rs "1"
        if snd = "1" then snd :: fst else fst
    else pos k

f  9 |> printfn "%A"
f -9 |> printfn "%A"
