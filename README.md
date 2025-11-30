# InventoryHub - FullStack Sample Submission

This repository contains a minimal, ready-to-upload set of files to fulfill the InventoryHub capstone requirements:
- A Minimal API back-end (ServerApp) exposing `/api/productlist`
- A Blazor WebAssembly front-end (ClientApp) with a `FetchProducts` component that consumes the API
- Basic optimizations: simple in-memory caching on the server and client-side caching to avoid redundant calls
- CORS enabled on the server
- Structured JSON response with nested `Category` object
- `REFLECTION.md` describing how Microsoft Copilot assisted

**Important:** These files are prepared so you can drop them into a GitHub repository. To run locally you'll need .NET 7+ SDK installed.

## Quick run instructions (recommended workflow)
1. Create the solution and projects (if you want the exact dotnet project scaffolding):
   ```bash
   mkdir FullStackApp
   cd FullStackApp
   dotnet new sln -n FullStackSolution
   dotnet new webapi -n ServerApp
   dotnet new blazorwasm -n ClientApp
   dotnet sln add ServerApp/ServerApp.csproj ClientApp/ClientApp.csproj
   ```
2. Replace the generated files with the files from this zip (or copy the ServerApp and ClientApp folders into your solution).
3. From two terminals:
   - `cd ServerApp` then `dotnet run`
   - `cd ClientApp` then `dotnet run` (or `dotnet watch` / `dotnet run` depending on template)
4. Open the Blazor client in the browser and navigate to `/fetchproducts`.

## What is included in this zip
- `ServerApp/Program.cs` : Minimal API with `/api/productlist`, CORS, and memory caching.
- `ServerApp/ServerApp.csproj` : minimal csproj to allow project restore/build.
- `ClientApp/Program.cs` : Blazor WASM Program wiring HttpClient and JSInterop.
- `ClientApp/Pages/FetchProducts.razor` : component that fetches products, handles JSON errors, caches results in browser localStorage, and avoids redundant calls.
- `REFLECTION.md` : reflective summary about using Copilot during development.
- `.gitignore` : basic gitignore for .NET projects.

## Notes
- This is a minimal educational sample to satisfy the assignment checklist. For production use, expand authentication, error handling, and add unit tests.
