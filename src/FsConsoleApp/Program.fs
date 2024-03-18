//Programs.fs demo file contents

/// This is a simple F# console application that demonstrates the use of XML comments.
/// It prompts the user to enter a name and then greets them.
module FsConsoleApp

open System

/// This function greets the user with a personalized message.
let greet (name: string) =
    printfn "Hello, %s! Welcome to the F# console app." name

[<EntryPoint>]
let main args =
    printfn "Please enter your name:"
    /// Apply XML comment to the name binding
    /// <summary>This is an XML comment for name.</summary>
    let name = Console.ReadLine()

    
    greet name

    printfn "Press any key to exit..."
    Console.ReadKey() |> ignore
    0 // return an integer exit code