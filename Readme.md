# Orchard Core Blazor Sample

This is a sample **Orchard Core CMS** project to demonstrate Orchard Core modules using **server-side** Blazor components. The idea is to be able to build a modularized CMS website using server-side Blazor. If you are planning to build a decoupled CMS websites or a Blazor-only SPA then another approach might be required.

Please note, that implementing a workaround was required to make Blazor static contents (e.g. blazor.server.js) accessible. See: https://github.com/OrchardCMS/OrchardCore/issues/2966#issuecomment-555506779

## How to use this sample

1. Clone the repository, restore and build. Please note that the solution uses the latest Orchard Core dev build which means that the referenced NuGet packages won't be available after some time. To solve this issue please update the Orchard Core package versions to the latest (which also means that something might broke). After the next major version is released this project should be upgraded as well to use a stable version.
2. Set up the Orchard Core website using the `Blazor Sample` recipe. You can use any recipe but make sure to enable the `OrchardCoreBlazorSample.Theme` theme and the `OrchardCoreBlazorSample.Module1` and `OrchardCoreBlazorSample.Module2` modules.
3. You can test Blazor components under the `/test/module1` and `/test/module2` URLs.
4. Explanations are in the comments. Please make sure you go through the source code, more specifically go to:
    * `OrchardCoreBlazorSample.Web/Startup.cs`
    * `OrchardCoreBlazorSample.Module1/Startup.cs`
    * `OrchardCoreBlazorSample.Module2/Views` (see all files)
    * `OrchardCoreBlazorSample.Module2/Views` (see all files)
    * `OrchardCoreBlazorSample.Theme/Views/Layout.cshtml`