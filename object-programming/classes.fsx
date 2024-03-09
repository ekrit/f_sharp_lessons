(* Classes *)
type Repo(name:string, stars:int) = 

    // Private properties
    let baseUrl = "https://github.com"

    // private method
    let incrementStarsBy stars n = stars + n

    // additional Constructors
    new() = Repo("", 0)

    // instance properties
    member this.Name = name // read-only, immutable
    member val Stars = stars with get, set // mutable

    // static Methods
    static member PrintHelp() = "Class that contains repo information"

    // methods
    member _.GetBaseUrl() = $"{baseUrl}"
    member this.GetRepoUrl() = $"{baseUrl}/{this.Name}"
    member this.IncrementStarsBy(n) = this.Stars <- incrementStarsBy this.Stars n //takes parameters

// static members
Repo.PrintHelp()

// create instance
let fsharpRepo = Repo("dotnet/fsharp", 25)
let blankRepo = Repo()

(* Access Members / Properties *)
fsharpRepo.Name
fsharpRepo.GetRepoUrl()
fsharpRepo.Stars <- 300
fsharpRepo.IncrementStarsBy 2
fsharpRepo.Stars
