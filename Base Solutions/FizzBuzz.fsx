for index in [1..100] do
    if index % 3 = 0 && index % 5 = 0 then
        printfn "FizzBuzz"
    else if index % 3 = 0 then
        printfn "Fizz"
    else if index % 5 = 0 then
        printfn "Buzz"
    else
        printfn "%i" index