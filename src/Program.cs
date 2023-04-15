using NovelCraft.Sdk;

Sdk.Initialize(args);
Sdk.Logger.Info("Hello World!");

while (true)
{
    var agent = Sdk.Agent;

    if (agent is null) {
        continue;
    }

    agent.Movement = IAgent.MovementKind.Forward;
}
