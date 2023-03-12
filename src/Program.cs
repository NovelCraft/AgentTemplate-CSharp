using CommandLine;

using NovelCraft.Sdk;

try {
  Options opt = Parser.Default.ParseArguments<Options>(args)
    .MapResult(
      opt => opt,
      _ => throw new Exception("Invalid arguments")
    );

  Config config = new() {
    Token = opt.Token,
    Host = opt.Host,
    Port = opt.Port
  };

  Sdk.Initialize(config);

} catch (Exception e) {
  Sdk.Logger.Error($"Failed to parse arguments: {e.Message}");
  Environment.Exit(1);
}


#region User code

// Your code here

#endregion


record Options {
  [Option("token", Required = true, HelpText = "The token of the agent.")]
  public required string Token { get; init; }

  [Option("host", Required = true, HelpText = "The host to connect.", Default = "localhost")]
  public required string Host { get; init; }

  [Option("port", Required = true, HelpText = "The port to connect.", Default = 14514)]
  public required int Port { get; init; }
}