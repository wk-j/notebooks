-- stack runghc --package strict

toBin :: Int -> [Char]
toBin x 
    | x == 0 || x == 1 = show x
    | otherwise = toBin (x `div` 2) ++ show (x `mod` 2)


main :: IO ()
main = 
    print (toBin 100)