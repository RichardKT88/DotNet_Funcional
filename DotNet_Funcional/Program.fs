open System
let olaMundo() = 
    printfn "Olá mundo!" 

let elevaNumeroAoQuadrado numero = numero * numero

let SomaQuadradoDosNumerosAteDez = 
    [1..10] |> List.map elevaNumeroAoQuadrado |> List.sum

[<EntryPoint>]
let main argv =
    olaMundo()
    0 