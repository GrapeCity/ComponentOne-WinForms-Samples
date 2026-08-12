// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using System;

namespace UIAScenarios
{
    /// <summary>
    /// Represents a single UI Automation test scenario.
    /// Contains scenario metadata and executable action.
    /// </summary>
    public class TestScenario
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestScenario"/> class.
        /// </summary>
        /// <param name="name">Scenario display name.</param>
        /// <param name="description">Short scenario description.</param>
        public TestScenario(string name, string description)
        {
            Name = name;
            Description = description;
        }

        /// <summary>
        /// Gets the scenario name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the scenario description.
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Gets or sets the action that executes the scenario logic.
        /// </summary>
        public Action Scenario { get; set; }
    }
}
