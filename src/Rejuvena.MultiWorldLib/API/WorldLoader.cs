using System.Collections.Generic;
using JetBrains.Annotations;
using Terraria.ModLoader;

namespace Rejuvena.MultiWorldLib.API
{
    /// <summary>
    ///     Handles the loading of <see cref="StandardWorld"/> instances.
    /// </summary>
    [UsedImplicitly]
    public sealed class WorldLoader : ModSystem
    {
        /// <summary>
        ///     A collection of all <see cref="IWorld"/> instances loaded through <see cref="WorldLoader"/>.
        /// </summary>
        internal static List<IWorld> Worlds = new();

        public override void Load() {
            base.Load();

            // Re-initialize upon reloading.
            Worlds = new List<IWorld>();
        }

        public override void Unload() {
            base.Unload();
        }
    }
}