using System.Collections.Generic;
using Terraria.ModLoader;
using Terraria.WorldBuilding;

namespace Rejuvena.MultiWorldLib.API
{
    /// <summary>
    ///     An object defining the behavior of a world loaded under the multi-world system provided by Multi-World Lib.
    /// </summary>
    public abstract class MultiWorld : ModType
    {
        #region World Creation Parameters

        /// <summary>
        ///     The world's width, in tiles.
        /// </summary>
        public abstract int Width { get; }

        /// <summary>
        ///     The world's height, in tiles.
        /// </summary>
        public abstract int Height { get; }

        /// <summary>
        ///     The world generation passes that should be ran upon generating this world.
        /// </summary>
        public abstract IEnumerable<GenPass> Passes { get; }

        /// <summary>
        ///     The world generation configuration that should be applied upon generating this world.
        /// </summary>
        public virtual WorldGenConfiguration? Configuration => null;

        #endregion

        #region Saving

        /// <summary>
        ///     Describes what data should be saved upon exiting.
        /// </summary>
        public virtual WorldSaveParameters SaveParameters => new();

        #endregion

        #region Updating

        /// <summary>
        ///     Denotes how traditional world updating applies to this world.
        /// </summary>
        public virtual WorldUpdateParameters UpdateParameters => new();

        #endregion

        #region Events

        // OnEnter
        // OnExit
        // OnLoad
        // OnUnload
        // SyncVariables
        // DrawSetup(GameTime)
        // DrawMenu(GameTime)
        // GetLight(Tile,int,int,FastRandom&,Vector3&)bool

        #endregion
    }
}