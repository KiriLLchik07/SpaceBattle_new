using SpaceBattle_workspace;

namespace SpaceBattle_Tests;

public class EmptyCommandTest
{
    [Fact]
    public void EmptyCommand_ExecuteDoesNotThrow()
    {
        var cmd = new EmptyCommand();
        Assert.Null(Record.Exception(() => cmd.Execute()));
    }
}
