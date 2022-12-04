
open System.IO
open solutions.day1;


printfn "Day 1 - Max Calories"

printfn "The maximum number of calories is : %d" (File.ReadAllLines("./DataFiles/day1_maxcalories") |> Array.toList |> MaxCalories.CalculateMaxCalories)

printfn "The sum of the Top 3 maximum calories is %d"  (File.ReadAllLines("./DataFiles/day1_maxcalories") |> Array.toList |> MaxCalories.GetTopThreeMaxCaloriesSum)


printf "==============================="





