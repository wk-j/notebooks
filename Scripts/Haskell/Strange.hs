-- stack runghc --package strict

data R = R { (-->) :: Int -> Int }

r :: R
r = R { (-->) = (+1) }

main :: IO ()
main = do
    print (r --> 8)