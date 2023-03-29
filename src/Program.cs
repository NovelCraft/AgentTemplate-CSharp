using NovelCraft.Sdk;

Sdk.Initialize(args);

while (Sdk.Agent is null);

Sdk.Agent?.Jump();

// Your code here
Sdk.Logger.Info("Hello World!");