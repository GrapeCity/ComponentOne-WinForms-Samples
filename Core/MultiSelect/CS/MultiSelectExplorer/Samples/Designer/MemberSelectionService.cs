// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using C1.Win.Input;
using MultiSelectExplorer.Properties;
using System.Collections.Generic;
using System.Linq;

namespace MultiSelectExplorer.Samples.Designer
{
    public class MemberSelectionService
    {
        private static readonly string[] _defaultMembers = Resources.TeamMembers.Split(',');

        public IEnumerable<string> GetAvailableMembers() => _defaultMembers;

        public IEnumerable<string> GetSelectedMembers(C1MultiSelect multiSelect)
        {
            return multiSelect.SelectedValues.Cast<string>();
        }

        public bool HasValidSelection(IEnumerable<string> selectedMembers)
        {
            return selectedMembers != null && selectedMembers.Any();
        }
    }
}
