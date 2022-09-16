using System.Collections.Generic;
using Terraria.WorldBuilding;

namespace Rejuvena.MultiWorldLib.API
{
    /// <summary>
    ///     A <see cref="StandardWorld"/> providing feature parity with Subworld Library's <c>Subworld</c>.
    /// </summary>
    public abstract class SublibWorld : StandardWorld
    {
        #region Subworld Members

        public abstract List<GenPass> Tasks { get; }

        public virtual bool ShouldSave => false;

        public virtual bool NoPlayerSaving => false;

        public virtual bool NormalUpdates => false;

        #endregion

        #region Multi-World Overrides

        public sealed override IEnumerable<GenPass> Passes => Tasks;

        public override WorldSaveParameters SaveParameters => new(ShouldSave, !NoPlayerSaving);

        public override WorldUpdateParameters UpdateParameters {
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