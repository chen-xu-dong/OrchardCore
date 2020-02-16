using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Orchard Demo",
    Author = "The Orchard Team",
    Website = "https://orchardproject.net",
    Version = "2.0.0",
    Description = "Test",
    Category = "Samples",
    Dependencies = new []{ "OrchardCore.Users", "OrchardCore.Contents" }
)]
