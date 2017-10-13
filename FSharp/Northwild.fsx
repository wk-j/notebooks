#r "../packages/FSharp.Data.TypeProviders/lib/net40/FSharp.Data.TypeProviders.dll"

open Microsoft.FSharp.Data.TypeProviders

type NortWind = ODataService<"http://services.odata.org/V3/NorthWind/NorthWind.svc"
