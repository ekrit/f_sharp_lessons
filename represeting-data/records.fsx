(* Define record *)
type GitHubProject = { ProjectName:string; Stars: int}

(* Create record *)
let fsharp = {
                                ProjectName="Something" 
                                Stars=4
                            }

(* Access Record Data *)
printfn $"{fsharp.ProjectName} has {fsharp.Stars} stars!"

(* Update Record Data *)
let updatedFSharp = {fsharp with Stars = 3000}
printfn $"{updatedFSharp.ProjectName} has {updatedFSharp.Stars} stars!"

(* Record Members *)
type GitHubProjectWithMember = 
            {
                ProjectName:string
                Stars:int
            }
            member this.GetUrl() = $"https://github.com/{this.ProjectName}"

            member _.GetCodeOwner () = "Haris"

let fsharpProj = {
                        ProjectName="js-blog" 
                        Stars = 3
                        }

fsharpProj.GetUrl()
fsharpProj.GetCodeOwner()


