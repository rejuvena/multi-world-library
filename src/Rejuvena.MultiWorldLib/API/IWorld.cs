using System;
using System.Collections.Generic;
using Terraria.ModLoader;
using Terraria.WorldBuilding;

namespace Rejuvena.MultiWorldLib.API
{
    /// <summary>
    ///     An object defining the behavior of a world loaded under the multi-world system provided by Multi-World Lib.
    /// </summary>
    public interface IWorld : IModType
    {
        #region World Creation Parameters

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

        #endregion

        #region Saving

        /// <summary>
        ///     Describes what data should be saved upon exiting.
        /// </summary>
        WorldSaveParameters SaveParameters { get; }

        #endregion

        #region Updating

        /// <summary>
        ///     Denotes how traditional world updating applies to this world.
        /// </summary>
        WorldUpdateParameters UpdateParameters { get; }

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