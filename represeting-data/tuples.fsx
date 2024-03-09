(* Create tuples *)

let point1 = (1.0, 2.0)

let githubStars = ("someRepository", 3000)

fst githubStars // gets the first element
snd githubStars // gets the second element

printfn $"{fst}"
printfn $"{snd}"


let projectName, stars = githubStars

printfn "bellow"

printfn $"{projectName}"
printfn $"{stars}"


let projectName, _ = githubStars // stars is ignored
