using MenuDesign.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MenuDesign.Services
{
    public class WindowMapper
    {
        private readonly Dictionary<Type, Type> _mappings = new Dictionary<Type, Type>();

        public WindowMapper() 
        {
            //RegisterMapping<MainViewModel, MainWindow>();
            //RegisterMapping<SettingsViewModel, SettingsWindow>();
        }

        public void RegisterMapping<TViewModel, TWindow>() where TViewModel : HomeViewModel where TWindow : Window
        {
            _mappings[typeof(TViewModel)] = typeof(TWindow);
        }

        public Type GetWindowTypeForViewModel(Type viewModelType)
        {
            _mappings.TryGetValue(viewModelType, out var type);
            return type;
        }
    }
}
