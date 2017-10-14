#r "../packages/Chessie/lib/net40/Chessie.dll"

open Chessie.ErrorHandling

type Data = { 
    Id: int
    Data: string
}

let log rs =
    let success(x, msg) = printfn "ok"
    let failure msg = printfn "fail"
    eitherTee success failure rs

let insert (data: Data) = 
    printfn "insert %A" data
    ok data


{ Id = 100; Data = "" }
|> insert 
|> log
