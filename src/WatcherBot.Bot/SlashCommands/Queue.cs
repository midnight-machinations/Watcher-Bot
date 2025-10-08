using NetCord;
using NetCord.Rest;
using NetCord.Services.ApplicationCommands;

namespace WatcherBot.Bot.SlashCommands;

public class Queue : ApplicationCommandModule<ApplicationCommandContext>
{
    [SlashCommand("create", "Creates a queue for users to join")]
    public async Task CreateQueueAsync(
        [SlashCommandParameter(Name = "name", Description = "Name of the queue")] string name,
        [SlashCommandParameter(Name = "size", Description = "Size to auto pull at")]
            ushort? size = null
    )
    {
        Context.Interaction.SendResponseAsync(
            InteractionCallback.DeferredMessage(MessageFlags.Ephemeral)
        );

        // Simulate creating a queue
        await Task.Delay(5000);

        Context.Interaction.ModifyResponseAsync(
            (message) =>
            {
                message.WithContent($"Created '{name}' queue with a size of {size}");
            }
        );
    }

    [SlashCommand("delete", "Deletes a queue")]
    public async Task DeleteQueueAsync(
        [SlashCommandParameter(Name = "name", Description = "Name of the queue")] string name
    )
    {
        Context.Interaction.SendResponseAsync(
            InteractionCallback.DeferredMessage(MessageFlags.Ephemeral)
        );

        // Simulate deleting a queue
        await Task.Delay(5000);

        Context.Interaction.ModifyResponseAsync(
            (message) =>
            {
                message.WithContent($"Deleted '{name}' queue");
            }
        );
    }
}
