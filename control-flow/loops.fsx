// For start to end
for i=1 to 3 do
    printfn $"{i}"

// revers
for i=3 downto 1 do
    printfn $"{i}"

// For in
let todoList = ["Learn F#"; "Create App"; "Profit!"]

for todo in todoList do
    printfn $"{todo.ToUpper()}"

// Collection generation
[for todo in todoList do todo.ToUpper()]

// while loop
open System
let mutable input = ""
while (input <> "q") do
    input <- Console.ReadLine()
    printfn $"{input}"

