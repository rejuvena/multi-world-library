namespace Rejuvena.MultiWorldLib.API.Behaviors
{
    /// <summary>
    ///     Describes the behavior regarding how multi-world data is saved.
    /// </summary>
    public interface IWorldSaveBehavior
    {
        /// <summary>
        ///     Whether the world should be saved upon exiting.
        /// </summary>
        bool SaveWorld { get; }

        /// <summary>
        ///     Whether the player should be saved upon exiting.
        /// </summary>
        bool SavePlayer { get; }
    }

    /// <summary>
    ///     The standard implementation of <see cref="IWorldSaveBehavior"/>.
    /// </summary>
    /// <param name="SaveWorld">Whether the world should be saved upon exiting.</param>
    /// <param name="SavePlayer">Whether the player should be saved upon exiting.</param>
    public record struct StandardWorldSaveBehavior(bool SaveWorld = false, bool SavePlayer = true) : IWorldSaveBehavior;
}