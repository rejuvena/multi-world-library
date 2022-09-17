using Terraria;

namespace Rejuvena.MultiWorldLib.API.Behaviors
{
    // TODO: These exist for feature parity with sublib, and are likely to be revised in the future by allowing multi-worlds to adjust individual parameters instead of outright disabling them.
    /// <summary>
    ///     Describes how world updating-related features should behave within a <see cref="MultiWorld"/>. These features typically expect vanilla world parameters in order to behave correctly.
    /// </summary>
    public interface IWorldUpdateBehavior
    {
        /// <summary>
        ///     Whether to progress time forward (or backward, for that matter).
        /// </summary>
        bool PerformTimeUpdates { get; }

        /// <summary>
        ///     Whether to perform world updates described in <see cref="WorldGen.UpdateWorld"/>.
        /// </summary>
        bool PerformWorldUpdates { get; }

        /// <summary>
        ///     Whether to adjust players' gravities as they approach the vanilla space layer.
        /// </summary>
        bool AdjustPlayerGravityAtSpaceHeight { get; }

        /// <summary>
        ///     Whether to adjust NPCs' gravities as they approach the vanilla space layer.
        /// </summary>
        bool AdjustNPCGravityAtSpaceHeight { get; }

        /// <summary>
        ///     Whether water should begin to evaporate once it reaches a sufficient depth into the underworld layer.
        /// </summary>
        bool EvaporateWaterAtUnderworldHeight { get; }
    }

    /// <summary>
    ///     Describes how world updating-related features should behave within a <see cref="MultiWorld"/>. These features typically expect vanilla world parameters in order to behave correctly.
    /// </summary>
    /// <param name="PerformTimeUpdates">Whether to progress time forward (or backward, for that matter).</param>
    /// <param name="PerformWorldUpdates">Whether to perform world updates described in <see cref="WorldGen.UpdateWorld"/>.</param>
    /// <param name="AdjustPlayerGravityAtSpaceHeight">Whether to adjust players' gravities as they approach the vanilla space layer.</param>
    /// <param name="AdjustNPCGravityAtSpaceHeight">Whether to adjust NPCs' gravities as they approach the vanilla space layer.</param>
    /// <param name="EvaporateWaterAtUnderworldHeight">Whether water should begin to evaporate once it reaches a sufficient depth into the underworld layer.</param>
    public record struct StandardWorldUpdateBehavior(
        bool PerformTimeUpdates = false,
        bool PerformWorldUpdates = false,
        bool AdjustPlayerGravityAtSpaceHeight = false,
        bool AdjustNPCGravityAtSpaceHeight = false,
        bool EvaporateWaterAtUnderworldHeight = false
    ) : IWorldUpdateBehavior;
}