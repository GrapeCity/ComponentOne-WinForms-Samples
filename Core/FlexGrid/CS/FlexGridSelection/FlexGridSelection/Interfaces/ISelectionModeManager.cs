using C1.Win.FlexGrid;
using C1.Win.Ribbon;

namespace FlexGridSelection.Interfaces
{
    public interface ISelectionModeManager
    {
        void HandleSelectionModeChanged(SelectionModeEnum selectionMode);
        void PopulateSelectionModeCombo(RibbonComboBox combo);
    }
}
