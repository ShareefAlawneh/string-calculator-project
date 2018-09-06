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

   printf "\n\n---- Starting The \\n Delimeter String Test ----\n"
   printf "Input: \"1,2\\n3\"\n"
   printf "Result:\t"
   let test3 = "1,2\n3" |> StringNormalizer |> SplitToList |> Add  

   printf "\n\n---- Starting The Custom Delimeters String Test ----\n"
   printf "Input: \"//[**][&]\\n1,2\\n3\"\n"
   printf "Result:\t"
   let test4 = "//[**][&]\n1,2\n3" |> StringNormalizer |> SplitToList |> Add 
   
   printf "\n\n---- Starting The Single Custom Delimeters String Test ----\n"
   printf "Input: \"//;\\n1;2;3;4;5\n6\"\n"
   printf "Result:\t"
   let test5 = "//;\n-1;2;3;4;-5\n6" |> StringNormalizer |> SplitToList |> Add 

   printf "\n\n---- Starting The Thousnd String Test ----\n"
   printf "Input: \"//[**][&]\\n1,2\\n3,10000\"\n"
   printf "Result:\t"
   let test6 = "//[**][&]\n1,2\n3,10000" |> StringNormalizer |> SplitToList |> Add 
   
   0 // return an integer exit code
