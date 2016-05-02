module Core.Compute
   
    let division (price:double) (ticketValue:double) = price / ticketValue
    let ticketsToGive divisionResult = divisionResult |> truncate
    let reste (divisionResult:double) ticketsToGive = System.Math.Round(divisionResult - ticketsToGive, 2)