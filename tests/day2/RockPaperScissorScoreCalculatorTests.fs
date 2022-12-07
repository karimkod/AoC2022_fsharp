module tests.day2.RockPaperScissorScoreCalculator


open solutions.day2.RockPaperScissorScoreCalculator
open Xunit


[<Theory>]
[<InlineData("A X", 4)>] 
[<InlineData("B Y", 5)>] 
[<InlineData("C Z", 6)>] 
[<InlineData("A Z", 3)>] 
[<InlineData("B X", 1)>] 
[<InlineData("C Y", 2)>] 
[<InlineData("A Y", 8)>] 
[<InlineData("B Z", 9)>] 
[<InlineData("C X", 7)>] 
let ``Score for a single pair`` (input:string,  expectedScore:int) =
    Assert.Equal(expectedScore, [input] |> CalculateScore)
    
    
[<Fact>]
let ``Get Score for a complete party`` () =
    let input = [
        "A Y"
        "B X"
        "C Z"
    ]
    Assert.Equal(15, input |> CalculateScore)
