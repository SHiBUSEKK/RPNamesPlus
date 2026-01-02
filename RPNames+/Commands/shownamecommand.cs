using CommandSystem;
using System;
using Exiled.API.Features;

[CommandHandler(typeof(ClientCommandHandler))]
public class shownamecommand : ICommand
{
    public string Command => "showname";
    public string[] Aliases => [];
    public string Description => "Shows your nickname.";

    public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
    {
        var sendername = Player.Get(sender).DisplayNickname;
        response = sendername;
        return true;
    }
}