-- stack runghc
cartesian xs ys = [(x,y) | x <- xs, y <- ys]

main = do
    let a = [1,2,3]
    let b = [4,5,6]
    print $ cartesian a b

