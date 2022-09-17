using System.Collections.Generic;
using Rejuvena.MultiWorldLib.API;
using Rejuvena.MultiWorldLib.API.Behaviors;
using Terraria.WorldBuilding;

// Use sublib's namespace for drop-in compatibility.
// ReSharper disable once CheckNamespace
namespace SubworldLibrary
{
    /// <summary>
    ///     A <see cref="MultiWorld"/> providing feature parity with Subworld Library's <c>SubworldLibrary.Subworld</c>.
    /// </summary>
    public abstract class Subworld : MultiWorld
    {
        public class SubworldWorldGenerationBehavior : IWorldGenerationBehavior
        {
            public int Width => subworld.Width;
            
            public int Height => subworld.Height;
            
            public IEnumerable<GenPass> Passes => subworld.Tasks;

            public WorldGenConfiguration? Configuration => subworld.Config;

            private readonly Subworld subworld;

            public SubworldWorldGenerationBehavior(Subworld subworld) {
                this.subworld = subworld;
            }
        }
        public class SubworldWorldSaveBehavior : IWorldSaveBehavior
        {
            public bool SaveWorld => subworld.ShouldSave;

            public bool SavePlayer => !subworld.NoPlayerSaving;
            
            private readonly Subworld subworld;

            public SubworldWorldSaveBehavior(Subworld subworld) {
                this.subworld = subworld;
            }
        }
        
        public class SubworldWorldUpdateBehavior : IWorldUpdateBehavior
        {
            public bool PerformTimeUpdates => subworld.NormalUpdates;
            
            public bool PerformWorldUpdates => subworld.NormalUpdates;
            
            public bool AdjustPlayerGravityAtSpaceHeight => subworld.NormalUpdates;
            
            public bool AdjustNPCGravityAtSpaceHeight => subworld.NormalUpdates;
            
            public bool EvaporateWaterAtUnderworldHeight => subworld.NormalUpdates;

            private readonly Subworld subworld;

            public SubworldWorldUpdateBehavior(Subworld subworld) {
                this.subworld = subworld;
            }
        }

        public abstract int Width { get; }

        public abstract int Height { get; }

        /// <summary>
        ///     The <see cref="GenPass"/>es that should be used when this multi-world is generating.
        /// </summary>
        public abstract List<GenPass> Tasks { get; }

        public virtual WorldGenConfiguration? Config => null;

        /// <summary>
        ///     Whether this world should save to a file to be loaded later.
        /// </summary>
        public virtual bool ShouldSave => false;

        /// <summary>
        ///     Whether player data should persist through saving.
        /// </summary>
        public virtual bool NoPlayerSaving => false;

        /// <summary>
        ///    Whether regular world updating, such as time progression and gravity adjustment should occur.
        /// </summary>
        public virtual bool NormalUpdates => false;

        public sealed override IWorldGenerationBehavior GenerationBehavior { get; }

        public sealed override IWorldSaveBehavior SaveBehavior { get; }

        public sealed override IWorldUpdateBehavior UpdateBehavior { get; }

        protected Subworld() {
            GenerationBehavior = new SubworldWorldGenerationBehavior(this);
            SaveBehavior = new SubworldWorldSaveBehavior(this);
            UpdateBehavior = new SubworldWorldUpdateBehavior(this);
        }
    }
}