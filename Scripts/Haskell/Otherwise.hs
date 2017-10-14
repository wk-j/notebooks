-- stack runghc 

f :: (Num a, Ord a) => a -> [Char]
f x 
 | x < 0 = "0"
 | otherwise = "x"


main :: IO ()
main = 
    print $ f (100 :: Int)


