namespace MoonoF

open Godot

type FSharpNode() =
    inherit Node()

    override _._Ready() = GD.Print "Hello from F#"
