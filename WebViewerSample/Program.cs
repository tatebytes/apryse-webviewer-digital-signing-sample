using Microsoft.AspNetCore.StaticFiles;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

var provider = new FileExtensionContentTypeProvider();

// Add required MIME types for Apryse WebViewer
provider.Mappings[".res"] = "application/octet-stream";
provider.Mappings[".mem"] = "application/octet-stream";
provider.Mappings[".wasm"] = "application/wasm";
provider.Mappings[".json"] = "application/json";
provider.Mappings[".ttf"] = "font/ttf";
provider.Mappings[".woff2"] = "font/woff2";

app.UseStaticFiles(new StaticFileOptions
{
    ContentTypeProvider = provider
});


app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
