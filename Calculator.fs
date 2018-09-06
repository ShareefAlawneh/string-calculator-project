namespace StringCalculator
open System
module public Calculator = 
       
    let isNegative (num: int) = 
        if num < 0 then true else false 

    let Add (nums : List<int>) =  
        let negatives = List.filter isNegative nums
        if negatives.Length > 0 then raise (System.NotSupportedException(String.Format("Cannot Add A Negative Value {0}", negatives)))
        let LessThan1000 num = if num < 1000 then true else false
        List.sum (List.filter LessThan1000 nums) |> printf "%A" 

    let SplitToList (stringSeq: string) = 
       stringSeq.Split [|','|] |>  Array.map System.Int32.Parse |>  Array.toList

    let NormalizeStringWithSpecialDelimeters (stringSeq: string) = 
        let delimeterEnd = stringSeq.IndexOf("\n")
        let mutable delimeters = stringSeq.[0..delimeterEnd-1]
        let mutable finalString = stringSeq.Remove(0, delimeterEnd+1).Replace("\n", ",")
        delimeters <- delimeters.Replace("//","")
        let mutable delimeter = ""
        if delimeters.Length = 1
        then finalString <- finalString.Replace(delimeters, ",")
        else for c in delimeters do 
                if c = '[' then
                   delimeter <- ""
                elif c = ']' then finalString.Replace(delimeter, ",") |> ignore
                else delimeter <-  delimeter + string c
        finalString
           
    let StringNormalizer (stringSeq: string) = 
        if stringSeq.Equals("") then "0" 
        elif stringSeq.StartsWith("//") then  stringSeq |> NormalizeStringWithSpecialDelimeters else stringSeq.Replace("\n",",")