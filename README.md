# BlazorTasker

A small **Blazor WebAssembly** app built on **.NET 10** to show the basics of Blazor: project structure, Razor syntax and components, routing, and layout components. It runs entirely in the browser, with no server-side code.

## Features

| Page | Route | What it shows |
|------|-------|---------------|
| **Home** | `/` | "Innovation Submission" landing page listing the Blazor concepts the project covers |
| **Counter** | `/counter` | Event handling and state: a button that increments a count and re-renders the page |
| **Weather** | `/weather` | Loading data asynchronously with an injected `HttpClient` from `sample-data/weather.json` and showing it in a table (Celsius and Fahrenheit) |
| **Reverse a String** | `/reverseastring` | Two-way data binding with `InputText` and `@bind-Value`: type a string, click **Reverse Me**, and see it reversed |
| **Not Found** | `/not-found` | A custom page for routes that don't exist |

## Tech stack

- .NET 10 / C# 14
- Blazor WebAssembly (`Microsoft.AspNetCore.Components.WebAssembly` 10.0.x)
- Bootstrap 5.3 and Bootstrap Icons (loaded from a CDN)
- Scoped component CSS (`*.razor.css`)

## Project structure

```
BlazorTasker/
├── Program.cs                 # Host setup: root components, HttpClient registration
├── BlazorTasker.csproj
├── Components/
│   ├── App.razor              # Router, default layout, not-found page
│   ├── _Imports.razor
│   ├── Layout/
│   │   ├── MainLayout.razor   # Sidebar + main content shell
│   │   └── NavMenu.razor      # Collapsible side navigation
│   └── Pages/
│       ├── Home.razor
│       ├── Counter.razor
│       ├── Weather.razor
│       ├── ReverseAString.razor
│       └── NotFound.razor
└── wwwroot/
    ├── index.html             # Static shell, loading and error UI
    ├── css/app.css
    ├── img/
    └── sample-data/weather.json
```

## Getting started

**Prerequisites:** the [.NET 10 SDK](https://dotnet.microsoft.com/download)

```bash
git clone https://github.com/tadesros/BlazorTasker.git
cd BlazorTasker
dotnet run
```

Then open the URL shown in the console, such as `https://localhost:5001`. You can also open `BlazorTasker.slnx` in Visual Studio 2022 or later and press **F5**.

## Blazor concepts covered

- **Components and Razor syntax:** markup mixed with C# in `@code` blocks
- **Routing:** each page declares its route with `@page`, and `App.razor` handles the routes that don't match
- **Data binding and events:** `@bind-Value` and `@onclick`
- **Dependency injection:** `HttpClient` is registered in `Program.cs` and used with `@inject`
- **Async lifecycle:** data loads in `OnInitializedAsync`
- **Layouts:** a shared `MainLayout` and a customized `NavMenu`
