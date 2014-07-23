[<EntryPoint>]
let main argv = 
    for bottles in [99..-1..1] do
        if bottles > 1 then
            if bottles < 99 then printfn "%i bottles of beer on the wall.\n" bottles
            printfn "%i bottles of beer on the wall, %i bottles of beer." bottles bottles
            printf "Take one down and pass it around, "
        else
            printfn "1 bottle of beer on the wall.\n"
            printfn "1 bottle of beer on the wall, 1 bottle of beer."
            printfn "Go to the store and buy some more, 99 bottles of beer on the wall."
    0
