type Status = Success=0 | Failure=1
type Result = { id:int; status:Status }
type User = { jurisdiction:int; age:int; accountnr:int; name:string }
let user = { jurisdiction = 1; age = 18; accountnr = 1234; name = "Jack" } 
let equal x y = x = y
let gt x y = x > y
let gte x y = x >= y
let lt x y = x < y
let lte x y = x <= y
let contains list elem = list |> Seq.contains elem

//let check id f result =
let check (id:int) (f:bool) (result:Result) : Result =
    if result.status = Status.Failure then
        result
    elif f then
        result
    else
        { id=id; status=Status.Failure }

let init = { id=0; status=Status.Success }

let c1 = init
        |> check 1 (user.jurisdiction |> equal <| 1)
        |> check 2 (user.age |> gte <| 18)
        |> check 3 ([|1234;1235;1236|] |> contains <| user.accountnr)
        |> check 4 (user.name |> equal <| "Bob")

let c2 = init
        |> check 1 (equal user.jurisdiction 1)
        |> check 2 (gte user.age 19)
        |> check 3 (contains [|1234;1235;1236|] user.accountnr)