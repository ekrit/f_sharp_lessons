type StringGitHubProject = 
    {
        ProjectName: string
        Stars: int
        State: string
    }

let fakeProject =
    {
        ProjectName = "Amazing Project"
        Stars = 4
        State = "asdfwerq" // no enforcement
    }

(* Define Discriminated Union *)
type ProjectState = 
    | Archived
    | Active of {|Maintainer : string|}

type GitHubProject = 
    {
        ProjectName: string
        Stars: int
        State: ProjectState
    }

(*Use discriminated Union*)
let (anotherFakeProject: GitHubProject) = 
    {
        ProjectName = "Other Amazing Project"
        Stars = 4
        State = "asdfwerq"
    }

let corefxlab = 
    {
        ProjectName = "corefxlab"
        Stars = 6
        State = Archived
    }

let fsharp = 
    {
        ProjectName = "dotnet/fsharp"
        Stars = 12
        State = Active {| Maintainer = "F#'s Team" |}
    }

