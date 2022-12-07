module solutions.day2.RockPaperScissorScoreCalculator

type private Play =
    | A
    | B
    | C

let private ConvertToPlayFromString (singlePlay:string) =
    match singlePlay with
    | "A" | "X" -> A
    | "B" | "Y" -> B
    | "C" | "Z" -> C
    | _ -> raise (System.ArgumentException("Unexpected Play"))

let private GetValueOfPlay(play:Play[]) =
    match play with
    | [|A; A|] -> 4
    | [|B; B|] -> 5
    | [|C; C|] -> 6
    | [|A; C|] -> 3
    | [|B; A|] -> 1
    | [|C; B|] -> 2
    | [|A; B|] -> 8
    | [|B; C|] -> 9
    | [|C; A|] -> 7
    | _ -> raise (System.ArgumentException("Unexpected Play"))
let CalculateScore (input:List<string>) =
    let x = input |> List.map(fun dual -> dual.Split ' ' |> Array.toList) |> List.map (fun singlePlay -> [|singlePlay.Head |> ConvertToPlayFromString; singlePlay.Tail.Head |> ConvertToPlayFromString |])
    x |> List.map (fun play -> play |> GetValueOfPlay) |> List.sum   
        
        
    

