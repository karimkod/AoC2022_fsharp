
open System.IO
open solutions.day1
open solutions.day2;


printfn "Day 1 - Max Calories"

printfn "The maximum number of calories is : %d" (File.ReadAllLines("./DataFiles/day1_maxcalories") |> Array.toList |> MaxCalories.CalculateMaxCalories)

printfn "The sum of the Top 3 maximum calories is %d"  (File.ReadAllLines("./DataFiles/day1_maxcalories") |> Array.toList |> MaxCalories.GetTopThreeMaxCaloriesSum)


printf "==============================="


printfn "Day 2 - Score Rock Paper Scissor"

printfn "Total Play according to the strategy is : %d" (File.ReadAllLines("./DataFiles/day2_rockpaperscissorparty") |> Array.toList |> RockPaperScissorScoreCalculator.CalculateScore)

printf "==============================="




