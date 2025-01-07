using System;

namespace Unity.Services.CloudCode.Subscriptions
{
    /// <summary>
    /// Event triggered when a message is received from Cloud Code.
    /// </summary>
    public interface IMessageReceivedEvent
    {
        /// <summary>
        /// Getter for the spec version of the received message's envelope.
        /// </summary>
        string SpecVersion { get; }

        /// <summary>
        /// Getter for the id of the received message's envelope.
        /// </summary>
        string Id { get; }

        /// <summary>
        /// Getter for the source of the message's envelope.
        /// </summary>
        string Source { get; }

        /// <summary>
        /// Getter for the type of the message's envelope.
        /// </summary>
        string Type { get; }

        /// <summary>
        /// Getter for the time when the message was created.
        /// </summary>
        DateTime Time { get; }

        /// <summary>
        /// Getter for the project id that the message is for.
        /// </summary>
        string ProjectId { get; }

        /// <summary>
        /// Getter for the environment id that the message is for.
        /// </summary>
        string EnvironmentId { get; }

        /// <summary>
        /// Getter for the correlation id that the message is for.
        /// </summary>
        string CorrelationId { get; }

        /// <summary>
        /// Getter for the message that was sent from Cloud Code for the player.
        /// </summary>
        string Message { get; }

        /// <summary>
        /// Getter for the type of message that was received.
        /// </summary>
        string MessageType { get; }
    }
}
