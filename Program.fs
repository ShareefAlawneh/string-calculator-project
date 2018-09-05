// Learn more about F# at http://fsharp.org


open StringCalculator.Calculator
[<EntryPoint>]
let main argv =
   
   printf "---- Starting The Empty String Test ----\n"
   printf "Input: \"\"\n"
   printf "Result:\t"
   let test1 = "" |> StringNormalizer |> SplitToList |> Add
   
   printf "\n\n---- Starting The Simple String Test ----\n"
   printf "Input: \"1,2\"\n"
   printf "Result:\t"
   let test2 = "1,2" |> StringNormalizer |> SplitToList |> Add  
   0 // return an integer exit code
