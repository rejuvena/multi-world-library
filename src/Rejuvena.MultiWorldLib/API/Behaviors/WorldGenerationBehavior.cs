using System.Collections.Generic;
using Terraria.WorldBuilding;

namespace Rejuvena.MultiWorldLib.API.Behaviors
{
    public interface IWorldGenerationBehavior
    {
        /// <summary>
        ///     The world's width, in tiles.
        /// </summary>
        int Width { get; }

        /// <summary>
        ///     The world's height, in tiles.
        /// </summary>
        int Height { get; }

        /// <summary>
        ///     The world generation passes that should be ran upon generating this world.
        /// </summary>
        IEnumerable<GenPass> Passes { get; }

        /// <summary>
        ///     The world generation configuration that should be applied upon generating this world.
        /// </summary>
        WorldGenConfiguration? Configuration { get; }
    }
}