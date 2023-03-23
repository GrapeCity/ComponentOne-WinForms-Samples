using C1.Win.Input.MultiColumnCombo;
using C1.Win.InputPanel;

namespace MultiColumnComboExplorer.Samples
{
    internal class MultiColumnComboHost : InputControlHost
    {
        public MultiColumnComboHost() : base(new C1MultiColumnCombo())
        {

        }

        public C1MultiColumnCombo MultiColumnCombo => (C1MultiColumnCombo)Control;
    }
}
