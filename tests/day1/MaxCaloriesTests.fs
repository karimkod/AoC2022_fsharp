module tests.day1.MaxCaloriesTests

open System.Collections
open Xunit
open solutions.day1.MaxCalories


[<Fact>]
let ``Max Calories for one elf`` () =
    let input = [
        "1000"
        "2000"
        "3000"
    ]
    Assert.Equal(6000, input |> CalculateMaxCalories)
    
    
[<Fact>]
let ``Max Calories for one elf with a separator`` () =
    let input = [
        "1000"
        "2000"
        "3000"
        ""
    ]
    Assert.Equal(6_000, input |> CalculateMaxCalories)
   
   
[<Fact>]
let ``Max Calories for two elves`` () =
    let input = [
        "1000"
        "2000"
        "3000"
        ""
        "10000"
    ]
    Assert.Equal(10_000, input |> CalculateMaxCalories)
  
  
[<Fact>]
let ``Get Top 3 max calories sum``  () =
    let input = [
        "100"
        ""
        "1000"
        "2000"
        "3000"
        ""
        "10_000"
        ""
        "50_000"
        ""
        "30_000"
    ]
    let expected: int list = [
                        50_000
                        30_000
                        10_000
                    ]
    Assert.Equivalent(50_000 + 30_000 + 10_000 ,(input |> GetTopThreeMaxCaloriesSum))
