using Terraria;

namespace Rejuvena.MultiWorldLib.API
{
    /// <summary>
    ///     Describes what world updating behavior should persist in your <see cref="IWorld"/>. These features typically expect vanilla world parameters to behave correctly.
    /// </summary>
    /// <remarks>
    ///     These exist for feature parity with Subworld Library, and are likely to be revised in the future by allowing <see cref="IWorld"/>s to adjust individual parameters instead of outright disabling them.
    /// </remarks>
    /// <param name="PerformTimeUpdates">Whether to progress time forward (or backward, for that matter).</param>
    /// <param name="PerformWorldUpdates">Whether to perform world updates described in <see cref="WorldGen.UpdateWorld"/>.</param>
    /// <param name="AdjustPlayerGravityAtSpaceHeight">Whether to adjust players' gravities as they approach the vanilla space layer.</param>
    /// <param name="AdjustNPCGravityAtSpaceHeight">Whether to adjust NPCs' gravities as they approach the vanilla space layer.</param>
    /// <param name="EvaporateWaterAtUnderworldHeight">Whether water should begin to evaporate once it reaches a sufficient depth into the underworld layer.</param>
    public record struct WorldUpdateParameters(
        bool PerformTimeUpdates = false,
        bool PerformWorldUpdates = false,
        bool AdjustPlayerGravityAtSpaceHeight = false,
        bool AdjustNPCGravityAtSpaceHeight = false,
        bool EvaporateWaterAtUnderworldHeight = false
    );
}