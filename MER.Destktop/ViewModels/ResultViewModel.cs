using FileHelpers;
using MER.Libs;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MER.Destktop.ViewModels
{
    public class ResultViewModel : BindableBase, INavigationAware
    {
        public ResultViewModel()
        {

        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            var engine = new FileHelperEngine<Beneficiario>();
            engine.Options.IgnoreFirstLines = 1;
            var records = engine.ReadFile(@"C:\Users\asimoes\Downloads\layout_dba_completo_exemplos.txt");

            foreach (var record in records)
            {

            }
        }
    }
}
