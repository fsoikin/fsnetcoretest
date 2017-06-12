module Main
open Newtonsoft.Json

[<EntryPoint>]
let main argv = 
    let j = JsonConvert.SerializeObject [|1; 2; 3|]
    let a = JsonConvert.DeserializeObject<int[]> j
    printfn "%s == %A" j a
    0