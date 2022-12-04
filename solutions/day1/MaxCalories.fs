module solutions.day1.MaxCalories

open System


let rec private Sum(input:List<string>) =
    match input with
    | [] -> 0
    | "" :: tail -> Sum tail
    | head::tail ->
        int head + Sum tail
        
let private SumCommaSeparatedString(input:string) =
        input.Split [|','|] |>  Array.toList |>Sum
    
    
let private GetListOfSums(input:List<string>) =
    let csl = List.fold(fun acc element -> if element = "" then acc + ";" else acc + element + ",") "" input
    [for css in csl.Split [|';'|]  do
                    SumCommaSeparatedString css]
        
let CalculateMaxCalories (input:List<string>) =
    input |> GetListOfSums |> Linq.Enumerable.Max
    

let GetTopThreeMaxCaloriesSum(input:List<string>) =
    (input |> GetListOfSums |> List.sortDescending)[0..2] |> Linq.Enumerable.Sum




