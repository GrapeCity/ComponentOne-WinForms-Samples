#nullable enable
using System;
using System.ComponentModel;

namespace InputExplorer.Samples.C1ButtonCommandBinding.Models
{
    /// <summary>
    /// Represents a single task item
    /// Implements INotifyPropertyChanged for data binding support
    /// </summary>
    public class TaskItem : INotifyPropertyChanged
    {
        private string _description = string.Empty;
        private bool _isCompleted = false;
        private DateTime _createdDate;

        /// <summary>
        /// Task description text
        /// </summary>
        public string Description
        {
            get => _description;
            set
            {
                if (_description != value)
                {
                    _description = value;
                    OnPropertyChanged(nameof(Description));
                }
            }
        }

        /// <summary>
        /// Whether the task is completed
        /// </summary>
        public bool IsCompleted
        {
            get => _isCompleted;
            set
            {
                if (_isCompleted != value)
                {
                    _isCompleted = value;
                    OnPropertyChanged(nameof(IsCompleted));
                }
            }
        }

        /// <summary>
        /// Date when task was created
        /// </summary>
        public DateTime CreatedDate
        {
            get => _createdDate;
            set
            {
                if (_createdDate != value)
                {
                    _createdDate = value;
                    OnPropertyChanged(nameof(CreatedDate));
                }
            }
        }

        /// <summary>
        /// Event raised when a property value changes
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Constructor - initializes created date
        /// </summary>
        public TaskItem()
        {
            _createdDate = DateTime.Now;
        }

        /// <summary>
        /// Raises the PropertyChanged event
        /// </summary>
        /// <param name="propertyName">Name of the property that changed</param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
#nullable restore