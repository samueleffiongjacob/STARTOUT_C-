var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.STARTOUT_C#>("startout-c#");


builder.Build().Run();
