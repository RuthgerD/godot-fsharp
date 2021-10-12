namespace MoonoF

open Godot
open System

type FSharpNode() =
    inherit Node()

    override _._Ready() =
        GD.Print "Hello from F#"

        // Who invented exceptions??

        let opt = Some()

        match opt with
        | Some _ -> GD.Print "Sound!"
        | None -> GD.Print "Unsound!"


        // Functional shiz!

        let list = [ 'a' .. 'z' ]

        list
        |> List.map Char.ToUpper
        |> List.iteri (fun i c -> GD.Print(c, i))

        ()
