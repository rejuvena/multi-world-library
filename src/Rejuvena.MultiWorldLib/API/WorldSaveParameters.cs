namespace Rejuvena.MultiWorldLib.API
{
    /// <summary>
    ///     Parameters for how <see cref="IWorld"/>s should be saved.
    /// </summary>
    /// <param name="SaveWorld">Whether the world should be saved upon exiting.</param>
    /// <param name="SavePlayer">Whether the player should be saved upon exiting.</param>
    public record struct WorldSaveParameters(bool SaveWorld = false, bool SavePlayer = true);
}