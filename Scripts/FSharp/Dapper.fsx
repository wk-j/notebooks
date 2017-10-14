#r "../packages/System.Data.SQLite.Core/lib/net451/System.Data.SQLite.dll"
#l "../packages/System.Data.SQLite.Core/lib/net46/x64"
#r "../packages/Dapper/lib/net451/Dapper.dll"
#r @"System.Transactions"

open System
open System.Collections.Generic
open System.Data.SQLite
open Dapper

type TradeData = {
    Symbal: string;
    Timestamp: DateTime;
    Price: float
}

let trades = [
    { Symbal = "BTC/USD"; Timestamp = new DateTime(2017, 07, 28); Price = 2751.20 }
    { Symbal = "BTC/USD"; Timestamp = new DateTime(2017, 07, 28); Price = 2751.20 }
    { Symbal = "BTC/USD"; Timestamp = new DateTime(2017, 07, 28); Price = 2751.20 }
]

let databaseFile = "Sample.sqlite"
let connectionString = sprintf "Data Source=%s;Version=3" databaseFile

SQLiteConnection.CreateFile(databaseFile)

let connection = new SQLiteConnection(connectionString)
connection.Open()

let structureSql = """ create table Trades ( Symbal varchar(20), Timestamp datetime, Price float) """

let structureCommand = new SQLiteCommand(structureSql, connection)
structureCommand.ExecuteNonQuery()

let insertTradeSql = """
insert into Trades(Symbal, Timestamp, Pirce) values(@symbal, @timestamp, @price)
"""

trades
|> List.map (fun x -> connection.Execute(insertTradeSql, x))
|> List.sum
|> (fun recordsAdded -> printfn "Records added : %d" recordsAdded)