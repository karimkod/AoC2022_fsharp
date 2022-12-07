module tests.day2.RockPaperScissorScoreCalculator


open solutions.day2.RockPaperScissorScoreCalculator
open Xunit


[<Theory>]
[<InlineData("A X", 3)>] 
[<InlineData("B Y", 5)>] 
[<InlineData("C Z", 7)>] 
[<InlineData("A Z", 8)>] 
[<InlineData("B X", 1)>] 
[<InlineData("C Y", 6)>] 
[<InlineData("A Y", 4)>] 
[<InlineData("B Z", 9)>] 
[<InlineData("C X", 2)>] 
let ``Score for a single pair`` (input:string,  expectedScore:int) =
    Assert.Equal(expectedScore, [input] |> CalculateScore)
    
    
[<Fact>]
let ``Get Score for a complete party`` () =
    let input = [
        "A Y"
        "B X"
        "C Z"
    ]
    Assert.Equal(12, input |> CalculateScore)
