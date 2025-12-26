using CommandSystem;
using System;
using LabApi.Features.Wrappers;

[CommandHandler(typeof(ClientCommandHandler))]
public class shownamecommand : ICommand
{
    public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
    {
        var sendername = Player.Get(sender).DisplayName;
        response = sendername;
        return true;
    }

    public string Command => "showname";
    public string[] Aliases => [];
    public string Description => "Shows your nickname.";
}