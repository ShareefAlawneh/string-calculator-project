namespace StringCalculator
module public Calculator = 
       
    let Add (nums : List<int>) =  List.sum nums |> printf "%A"
    let SplitToList (stringSeq: string) = 
       stringSeq.Split [|','|] |>  Array.map System.Int32.Parse |>  Array.toList
    let StringNormalizer (stringSeq: string) = 
        if stringSeq.Equals("") then "0" 
        else stringSeq