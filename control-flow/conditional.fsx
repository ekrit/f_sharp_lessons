// conditional expressions
open System.IO

let processFile (fileName:string) = 
    let fileExtension = Path.GetExtension(fileName)

    if fileExtension = ".fs" then
        printfn "This is a source file"
    elif fileExtension = ".fsx" then
        printfn "this is a script"
    elif fileExtension = ".fsproj" then
        printfn "this is a build configuration file"
    else printfn "Can't process the file"

processFile "hello.fsx"
processFile "app.fs"
processFile "Readme.md"
    
// Exception Handling
let divide x y =
    try 
        Some(x/y)
    with
        | :? System.DivideByZeroException -> printfn "Can't divide by Zero"; None
        | ex -> printfn "Some other exception occured"; None

divide 1 2
divide 2 0
