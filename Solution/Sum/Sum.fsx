let max = 299L

#time
seq { 
    for i in [1L..max] do
        for j in [1L..(max + i)] do
            for k in [1L..(max + i + j)] do 
                yield (i * j * k) % (i + j + k) 
                //yield (i,j,k)
}
|> Seq.sum
|> printfn "%A"
#time