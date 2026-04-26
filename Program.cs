using BlazorKioscoAlmacenes;
using BlazorKioscoAlmacenes.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Supabase;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddSingleton<AppState>();

// Cargamos la configuración
var supabaseUrl = builder.Configuration["SupabaseUrl"] ?? "";
var supabaseKey = builder.Configuration["SupabaseKey"] ?? "";



builder.Services.AddScoped(provider =>
    new Supabase.Client(supabaseUrl, supabaseKey, new SupabaseOptions
    {
        AutoConnectRealtime = true
    }));

await builder.Build().RunAsync();
