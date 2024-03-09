(*Value types*)

// string
"Sarajevo"

// bolean
true

// integer
13

// tuple
(1.0, 3.0)

// list value
["someting"; "somewhere"; "sometimes"]

// lambda expression / anonymous function value
fun input -> input / 3

(*Value binding*)

let city_name = "Sarajevo"

let sarajevo_is_cool = true

let zip_code = 76250

let coordinates = (63.2, 345.2)

let todo_list = ["sometings"; "sometimes"; "somewhere"]

let dividedByThree input = input / 3 

(*Explicit type annotations*)
let (luckyNumberString:string) = "12"

(*Updating values*)

city_name <-"Sarajevo"     // now this cannot happen because every variable is immutable by default in F#

let city_corrected_name = "Sarajevo"

(*Mutable values*)

let mutable city_correct_name = "Sarajevo"

city_correct_name <- "sarajevo"


