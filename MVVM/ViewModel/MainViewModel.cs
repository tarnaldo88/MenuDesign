using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuDesign.Core;

namespace MenuDesign.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject

    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand TasksViewCommand { get; set; }
        public RelayCommand CompViewCommand { get; set; }
        public HomeViewModel HomeVM { get; set; }
        public TasksViewModel TasksVM { get; set; }
        public CompletedTasksViewModel CompleteVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            TasksVM = new TasksViewModel();
            CompleteVM = new CompletedTasksViewModel();
            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            TasksViewCommand = new RelayCommand(o =>
            {
                CurrentView = TasksVM;
            });

            CompViewCommand = new RelayCommand(o =>
            {
                CurrentView = CompleteVM;
            });
        }
    }
}
