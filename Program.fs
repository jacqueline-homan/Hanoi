open System
open System.IO

// idiomatic F# way
let rec TowerOfHanoi n s f =
    match n with
    | 0 -> []
    | _ -> let t = (6 - s - f)
           (TowerOfHanoi (n - 1) s t) @ [s, f] @ (TowerOfHanoi(n - 1) t f)
(TowerOfHanoi 2 1 2) |> List.iter (fun (x, y) -> printf "Move the disc from %A to %A\n" x y)

// basic recursive implementation
let rec towerOfHanoi f x t n =
    if n > 0 then 
        towerOfHanoi f t x (n - 1)
        printfn "Move disc from %c to %c" f t  
        towerOfHanoi x f t (n - 1)
towerOfHanoi 'x' 'y' 'z' 4

// Another recursion exercise
let factorial n = 
    [1..n]
    |> List.fold (*) 1
factorial 5 |> printfn "The value of 5! is: %A"

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0 // return an integer exit code

