(* Create Collection *)

// List

// Build-in creation function
List.init<int> 10 (fun i -> i)
List.init<int> 10 (fun i -> i * 2)

// Inline initialization
[1;2;3;4;5;6;7;8;9;10]
[1 .. 10]

// Array 
Array.init<int> 10 (id)
Array2D.init<int> 3 3  (fun x _ -> x)
Array3D.init<int> 3 3 3 (fun _ _ z -> z)

[| 1; 2; 3; 4; 5; 6; 7; 8; 9; 10 |]
[| 1 .. 10|]


// Sequence
Seq.init<int> 10 (fun i -> i)
Seq.initInfinite<int> (fun i -> i)

seq {
    1
    2
    4
    5
    6
    7
    8
    9
    10
}

seq {1 .. 10}

(* Access elements *)

open System

type Transaction =
    {
        Date:DateTime
        CustomerId:string
        Amount:double
    }

let transactions = 
    [
        { 
            Date = new DateTime(2024,3,11)
            CustomerId = "1"
            Amount = 23.80
        }
        { 
            Date = new DateTime(2024,3,11)
            CustomerId = "1"
            Amount = 13.80
        }
        { 
            Date = new DateTime(2024,3,11)
            CustomerId = "2"
            Amount = 33.80
        }
        { 
            Date = new DateTime(2024,3,11)
            CustomerId = "3"
            Amount = 29.80
        }
        { 
            Date = new DateTime(2024,3,11)
            CustomerId = "2"
            Amount = 3.80
        }
    ]

// get first element
transactions.Head


// get rest of the elements
transactions.Tail

// Access by index
// This is just for demo purposes
// Access by index is more efficient on arrays
transactions.[0] // similar to Head 
transactions.[1..] // similar to Tail

// Built in collection operations
transactions
|> List.find (fun transactions -> transactions.CustomerId = "1")

// this one throws an error
transactions
|> List.find (fun transactions -> transactions.CustomerId = "6")

// Append & Prepend
let todoList = ["Learn F#"; "Create App"; "Profit!"]

["Repeat"] |> List.append todoList // Append
todoList |> List.append ["Make Coffee"]  // Prepend

(* Convert Collections *)
let transactionArray = transactions |> Array.ofList
let transactionSeq = transactions |> Seq.ofList

(* Opearations *)
transactions
|> List.map
    (
        fun transaction -> 
        let taxRate = 0.03

        {|
            PreTax = transaction.Amount
            Tax = transaction.Amount * taxRate
            Total = transaction.Amount * (1.0 + taxRate) // Calculate tax
        |}
    )


transactions
|> List.iter (fun transaction -> printfn $"{transaction.CustomerId}")

// total transactions
transactions
|> List.sumBy (fun transaction -> transaction.Amount)

// average amount
transactions
|> List.averageBy (fun transaction -> transaction.Amount)

// Filter
transactions
|> List.filter (fun x -> x.Date > DateTime.Now)

// Sort
transactions
|> List.sortBy (fun x -> x.Date)

transactions
|> List.sortByDescending (fun (x: Transaction) -> x.Date)

// pipelines
transactions
|> List.filter (fun x -> x.Date > DateTime(2021, 1,1))
|> List.sortByDescending (fun x -> x.Date)