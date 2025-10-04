using NetCord.Rest;
using NetCord.Services.ApplicationCommands;

namespace WatcherBot.Bot.SlashCommands;

public class Queue : ApplicationCommandModule<ApplicationCommandContext>
{
    [SlashCommand("join", "Joins the specified queue")]
    public async Task JoinQueueAsync(
        [SlashCommandParameter(Name = "queue_name", Description = "Name of the queue to join")]
            string queueName = "default",
        [SlashCommandParameter(
            Name = "duration",
            Description = "Number of hours to join the queue for (can be decimal value)",
            MinValue = .5f,
            MaxValue = 5f
        )]
            float hours = .5f
    )
    {
        InteractionCallbackProperties message = InteractionCallback.Message();

        await Context.Interaction.SendResponseAsync(message);
    }
}
