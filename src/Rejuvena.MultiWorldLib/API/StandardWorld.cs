using System.Collections.Generic;
using Terraria.ModLoader;
using Terraria.WorldBuilding;

namespace Rejuvena.MultiWorldLib.API
{
    /// <summary>
    ///     The standard implementation of <see cref="IWorld"/>, loaded through <see cref="WorldLoader"/>.
    /// </summary>
    public abstract class StandardWorld : ModType, IWorld
    {
        #region World Creation Parameters

        /// <inheritdoc />
        public abstract int Width { get; }

        /// <inheritdoc />
        public abstract int Height { get; }

        /// <inheritdoc />
        public abstract IEnumerable<GenPass> Passes { get; }

        /// <inheritdoc />
        public virtual WorldGenConfiguration? Configuration => null;

        #endregion

        #region Saving

        public virtual WorldSaveParameters SaveParameters => new();

        #endregion

        #region Updating

        public virtual WorldUpdateParameters UpdateParameters => new();

        #endregion
        
        #region ModType Impl

        protected override void Register() {
            WorldLoader.Worlds.Add(this);
            ModTypeLookup<IWorld>.Register(this);
        }

        public sealed override void SetupContent() {
            base.SetupContent();

            SetStaticDefaults();
        }

        #endregion
    }
}