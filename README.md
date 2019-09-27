# BlazorDual

## Switch between Blazor WebAssembly and Blazor Hosted

I have started to utilize Blazor, and created my project with a target of Blazor WebAssembly, as this is how I intend to deploy the project. However, I was consequently unable to use the Visual Studio debugger. 

This BlazorDual project shows a workaround. The main BlazorDual project is based off a new WebAssembly project, then a Blazor Hosted project was added to the solution. The `wwwroot` folder was added to the Hosted project as a symbolic link.

The main target will be a client side Blazor project due to it requiring a lower .NET Core target compared to server side Blazor project (read: client size blazor is still in preview). To run the project as server side Blazor and enable the debugger, switch to BlazorDual.Hosted in the top toolbar of Visual Studio

Ideally, this would have been a seperate target for WebAssembly, a seperate target for Hosted, and a shared library for common code and razor pages. This however caused me to have issues where the .razor files were not compiled properly (encountering the error `Default Constructor not found for MainLayout`)

Blazor is still nascent, so contact me / make an issue if a better solution crops up for switching between WASM and Hosted Blazor.
