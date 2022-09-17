using System.Collections.Generic;
using Rejuvena.MultiWorldLib.API;
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
        #region Subworld Members

        /// <summary>
        ///     The <see cref="GenPass"/>es that should be used when this multi-world is generating.
        /// </summary>
        public abstract List<GenPass> Tasks { get; }

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

        #endregion

        #region Multi-World Overrides

        /// <summary>
        ///     Short-hand for <see cref="Tasks"/>.
        /// </summary>
        public sealed override IEnumerable<GenPass> Passes => Tasks;

        /// <summary>
        ///     Uses the values of <see cref="ShouldSave"/> and<see cref="NoPlayerSaving"/>.
        /// </summary>
        public sealed override WorldSaveParameters SaveParameters => new(ShouldSave, !NoPlayerSaving);

        /// <summary>
        ///     Each parameter is set to the value of <see cref="NormalUpdates"/>.
        /// </summary>
        public sealed override WorldUpdateParameters UpdateParameters {
            get {
                bool norm = NormalUpdates;
                return new WorldUpdateParameters(
                    norm,
                    norm,
                    norm,
                    norm,
                    norm
                );
            }
        }

        #endregion
    }
}