using MenuDesign.MVVM.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MenuDesign.Services
{
    internal class ViewModelLocator
    {
        private readonly IServiceProvider _provider;
        public ViewModelLocator(IServiceProvider provider)
        {
            _provider = provider;
        }

        public MainViewModel MainViewModel => _provider.GetRequiredService<MainViewModel>();
        public SettingsViewModel SettingsViewModel => _provider.GetRequiredService<SettingsViewModel>();
    }
}
