var builder = DistributedApplication.CreateBuilder(args);

var api = builder.AddProject<Projects.Aspire4Wasm_Samples_Standalone_Mud_WebApi>("api");
var blazor = builder.AddStandaloneBlazorWebAssemblyProject<Projects.Aspire4Wasm_Samples_Standalone_Mud_Client>("blazor");

api.WithReference(blazor);
blazor.WithReference(api);

builder.Build().Run();
