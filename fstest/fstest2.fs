type Status = Success=0 | Failure=1
type Funds = { real:decimal; linked:decimal; promotion:decimal; }
type FundsResult = { status:Status; contributive:bool; funds:Funds; }

