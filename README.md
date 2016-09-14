# WebSharper.Community.SpinJS
Spin.js (http://spin.js.org/) for WebSharper extension

# Documentation

[look also at sample](../master/WebSharper.Community.SpinJS.Sample/Client.fs)

1.open namespace WebSharper.Community.SpinJS

2.create settings (optional) - if options are not created default settings are used (look at http://spin.js.org/ for options)
```
let spinOpts = SpinnerSettings(Length=0, Radius=70, Opacity=0.05, Width=20) 
```
3.create target html element where spinner will appear
```
let spinnerDiv = div [] //target div
```
4.create spinner (with option from step2 or default)
```
let spinner = Spinner(spinOpts) //create with options
let spinner = Spinner() //create without options
```
5.show/hide spinner
```
spinner.Spin spinnerDiv.Dom  //show
spinner.Stop() //hide
```

