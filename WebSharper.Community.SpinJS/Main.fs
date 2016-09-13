namespace WebSharper.Community.SpinJS

open WebSharper
open WebSharper.JavaScript
open WebSharper.InterfaceGenerator

module Definition =

    let SpinnerSettings =
        Pattern.Config "SpinnerSettings" {
            Required = []
            Optional =
                [
                    "lines" , T<int>
                    "length", T<int>
                    "width", T<int>
                    "radius", T<int>
                    "scale", T<int>
                    "corners", T<int>
                    "color", T<string>
                    "opacity", T<float>
                    "rotate", T<int>
                    "direction", T<int>
                    "speed", T<int>
                    "trail", T<int>
                    "fps", T<int>
                    "zIndex", T<int>
                    "className", T<string>
                    "top", T<string>
                    "left", T<string>
                    "shadow", T<bool>
                    "hwaccel", T<bool>
                    "position", T<string>                    
                ]
        }

    let Spinner =
        Class "Spinner"
        |+> Instance [
                "spin" => T<Dom.Node>?target ^-> T<unit>
                "stop" => T<unit> ^-> T<unit>
            ]
        |+> Static [
                Constructor (!? SpinnerSettings?options)
                |> WithComment "Create spinner with given options"
            ]

    let Assembly =
        Assembly [
            Namespace "WebSharper.Community.SpinJS" [
                SpinnerSettings
                Spinner
            ]
            Namespace "WebSharper.Community.SpinJS.Resources" [
                //Resource "SpinJS" "https://cdnjs.cloudflare.com/ajax/libs/spin.js/2.3.2/spin.js"
                Resource "SpinJS" "https://cdnjs.cloudflare.com/ajax/libs/spin.js/2.3.2/spin.min.js"
                |> fun r -> r.AssemblyWide()
            ]
        ]

[<Sealed>]
type Extension() =
    interface IExtension with
        member ext.Assembly =
            Definition.Assembly

[<assembly: Extension(typeof<Extension>)>]
do ()
