using Microsoft.Extensions.Caching.Memory;

var builder = WebApplication.CreateBuilder(args);

// Add memory cache service
builder.Services.AddMemoryCache();

// Allow CORS for local development (adjust origins for production)
builder.Services.AddCors();

var app = builder.Build();
app.MapGet("/", () => Results.Ok("API is running"));

// Configure CORS - place before Map endpoints
app.UseCors(policy =>
    policy.AllowAnyOrigin()
          .AllowAnyMethod()
          .AllowAnyHeader());

// Simple in-memory cache for product list to improve performance
var cache = app.Services.GetRequiredService<IMemoryCache>();
var cacheKey = "product_list_v1";

app.MapGet("/api/productlist", () =>
{
    // Try to get from cache
    if (!cache.TryGetValue(cacheKey, out object? cached))
    {
        var products = new[]
        {
            new
            {
                Id = 1,
                Name = "Laptop",
                Price = 1200.50,
                Stock = 25,
                Category = new { Id = 101, Name = "Electronics" }
            },
            new
            {
                Id = 2,
                Name = "Headphones",
                Price = 50.00,
                Stock = 100,
                Category = new { Id = 102, Name = "Accessories" }
            }
        };

        // Cache for 60 seconds (tunable)
        var cacheEntryOptions = new MemoryCacheEntryOptions()
            .SetSlidingExpiration(TimeSpan.FromSeconds(60));

        cache.Set(cacheKey, products, cacheEntryOptions);
        cached = products;
    }

    return Results.Ok(cached);
})
.WithName("GetProductList");

app.Run();
