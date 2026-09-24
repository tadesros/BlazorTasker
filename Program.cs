// Program.cs
// Blazor WebAssembly application startup.
// C# 14.0, .NET 10
//
// This file performs minimal host bootstrapping for a Blazor WebAssembly app:
// - Creates the default WebAssembly host builder (loads configuration, sets environment, etc.)
// - Registers root components that mount Blazor into the static HTML page
// - Adds framework and app services (example: HttpClient preconfigured with the host base address)
// - Builds and runs the app asynchronously

using BlazorTasker;
//Add for our modification
using BlazorTasker.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

// Create the WebAssembly host builder with default configuration sources and environment.
var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Register the root `App` component and mount it to the DOM element with id `#app`.
builder.RootComponents.Add<App>("#app");

// Register `HeadOutlet` to enable server/JS-controlled modifications to the HTML <head> (title, meta, styles).
builder.RootComponents.Add<HeadOutlet>("head::after");

// Register a scoped `HttpClient` instance preconfigured with the host environment base address.
// This `HttpClient` is suitable for making relative requests back to the hosting origin or API endpoints.
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Build the host and start the Blazor WebAssembly app asynchronously.
await builder.Build().RunAsync();
