using System.Collections.Generic;
using Rejuvena.MultiWorldLib.API.Behaviors;
using Terraria.ModLoader;
using Terraria.WorldBuilding;

namespace Rejuvena.MultiWorldLib.API
{
    /// <summary>
    ///     An object defining the behavior of a world loaded under the multi-world system provided by Multi-World Lib.
    /// </summary>
    public abstract class MultiWorld : ModType
    {
        #region Behaviors

        /// <summary>
        ///     Determines how the world should generate, encompassing generation passes and world size.
        /// </summary>
        public abstract IWorldGenerationBehavior GenerationBehavior { get; }

        /// <summary>
        ///     Determines what data should be saved upon exiting.
        /// </summary>
        public virtual IWorldSaveBehavior SaveBehavior => new StandardWorldSaveBehavior();
        
        /// <summary>
        ///     Determines how traditional world updating applies to this world.
        /// </summary>
        public virtual IWorldUpdateBehavior UpdateBehavior => new StandardWorldUpdateBehavior();
        
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