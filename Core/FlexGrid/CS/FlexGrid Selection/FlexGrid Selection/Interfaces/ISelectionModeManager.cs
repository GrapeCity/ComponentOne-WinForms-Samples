using C1.Win.FlexGrid;
using C1.Win.Ribbon;

namespace FlexGrid_Selection.Interfaces
{
    public interface ISelectionModeManager
    {
        void HandleSelectionModeChanged(SelectionModeEnum selectionMode);
        void PopulateSelectionModeCombo(RibbonComboBox combo);
    }
}
