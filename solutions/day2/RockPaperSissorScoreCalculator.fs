module solutions.day2.RockPaperScissorScoreCalculator

type private Play =
    | A
    | B
    | C

type private Target =
    | Win
    | Draw
    | Loose

let private ConvertToPlayFromString (singlePlay: string) =
    match singlePlay with
    | "A" -> A
    | "B" -> B
    | "C" -> C
    | _ -> raise (System.ArgumentException("Unexpected Play"))

let private ConvertTargetFromString (target: string) =
    match target with
    | "X" -> Loose 
    | "Y" -> Draw 
    | "Z" -> Win 
    | _ -> raise (System.ArgumentException("Unexpected Target"))
    
let private GetValueOfPlay (play: Play []) =
    match play with
    | [| A; A |] -> 4
    | [| B; B |] -> 5
    | [| C; C |] -> 6
    | [| A; C |] -> 3
    | [| B; A |] -> 1
    | [| C; B |] -> 2
    | [| A; B |] -> 8
    | [| B; C |] -> 9
    | [| C; A |] -> 7
    | _ -> raise (System.ArgumentException("Unexpected Play"))

let private GetPlayFor (input:Play*Target) =
    match input with
    | A, Win -> B 
    | B, Win -> C 
    | C, Win -> A 
    | A, Draw ->A 
    | B, Draw -> B 
    | C, Draw -> C 
    | A, Loose -> C 
    | B, Loose -> A 
    | C, Loose -> B 



let CalculateScore (input: List<string>) =
    let x =
        input
        |> List.map (fun dual -> dual.Split ' ' |> Array.toList)
        |> List.map (fun singlePlay ->
            [| singlePlay.Head |> ConvertToPlayFromString
               (singlePlay.Head|> ConvertToPlayFromString,  (singlePlay.Tail.Head |> ConvertTargetFromString)) |> GetPlayFor |])

    x
    |> List.map (fun play -> play |> GetValueOfPlay)
    |> List.sum
