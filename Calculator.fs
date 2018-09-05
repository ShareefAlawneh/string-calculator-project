namespace StringCalculator
module public Calculator = 
       
    let Add (nums : List<int>) =  List.sum nums |> printf "%A"
    let SplitToList (stringSeq: string) = 
       stringSeq.Split [|','|] |>  Array.map System.Int32.Parse |>  Array.toList

    let NormalizeStringWithSpecialDelimeters (stringSeq: string) = 
        let delimeterEnd = stringSeq.IndexOf("\n")
        let mutable delimeters = stringSeq.[0..delimeterEnd]
        let finalString = stringSeq.Remove(0, delimeterEnd+1).Replace("\n", ",")
        delimeters <- delimeters.Replace("//","")
        let mutable delimeter = ""
        for c in delimeters do 
            if c = '[' then
               delimeter <- ""
            elif c = ']' then finalString.Replace(delimeter, ",") |> ignore
            else delimeter <-  delimeter + string c 
        finalString
           
    let StringNormalizer (stringSeq: string) = 
        if stringSeq.Equals("") then "0" 
        elif stringSeq.StartsWith("//") then  stringSeq |> NormalizeStringWithSpecialDelimeters else stringSeq.Replace("\n",",")