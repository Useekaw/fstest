type Status = Success=0 | Failure=1
type Funds = { real:float; linked:float; promotion:float; }
type FundsResult = { status:Status; contributive:bool; funds:Funds; }

let funds = { real = 100.0; linked = 5.0; promotion = 10.0;}
let order = -20.0

let substract x y = x - y

let xxx value funds =
    { real = funds.real; linked = funds.linked; promotion = funds.promotion + order }


let result = 
    order
    |> substract funds.promotion