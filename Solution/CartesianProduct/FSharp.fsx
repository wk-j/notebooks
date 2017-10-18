let a = [1;2;3]
let b = [4;5;6]

let cartesian xs ys = 
    xs |> List.collect (fun x -> ys |> List.map (fun y -> x, y))

cartesian a b
|> printfn "%A"