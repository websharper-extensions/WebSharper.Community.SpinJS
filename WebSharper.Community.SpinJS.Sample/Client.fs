namespace WebSharper.Community.SpinJS.Sample

open WebSharper
open WebSharper.JavaScript
open WebSharper.UI.Next
open WebSharper.UI.Next.Client
open WebSharper.UI.Next.Html
open WebSharper.Community.SpinJS

[<JavaScript>]
module Client =

    let Main () =
        let spinOpts = SpinnerSettings(Length=0, Radius=70, Opacity=0.05, Width=20)        
        let spinnerDiv = div [] //target div
        let spinner = Spinner(spinOpts) //create with options


        let start_spinner () : unit = 
            async {
              spinner.Spin spinnerDiv.Dom
            } |> Async.Start

        let stop_spinner () : unit = 
            async {
              spinner.Stop()
            } |> Async.Start

        

        div [
            Doc.Button "Start spinner" [attr.``class`` "btn btn-primary"]  (fun _ -> start_spinner())
            Doc.Button "Stop spinner" [attr.``class`` "btn btn-success"]  (fun _ -> stop_spinner())
            
            spinnerDiv
        ]
