using NetCord;
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
            Description = "Number of hours to join the queue for",
            MinValue = .5f,
            MaxValue = 12f
        )]
            float hours = 1
    )
    {
        float durationSeconds = hours * 3600;

        InteractionMessageProperties messageProperties = new();
        messageProperties.WithContent(
            $"Joined the {queueName} queue for {TimeSpan.FromSeconds(durationSeconds)} --- Logic not implemented"
        );
        messageProperties.WithFlags(MessageFlags.Ephemeral);

        await Context.Interaction.SendResponseAsync(InteractionCallback.Message(messageProperties));
    }
}
