using GalaSoft.MvvmLight;
using MDIXTemplateSelector;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MDIXTemplateSelector
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Option> Options { get; }

        public MainWindowViewModel()
        {
            Options = new ObservableCollection<Option>
            {
                new Option("Do you want large size?", "CheckBox"),
                new Option("My Placeholder", "TextBox"),
                new MultiplChoiceOption("Fruit", "ComboBox", new[] {"Apple", "Kiwi", "Orange"}),
                new MultiplChoiceOption("Veggies", "ComboBox", new[] {"Carrot", "Lettuce", "Rubarb"}),
                new Option("Button Text", "Button"),
                new Option("Button Text2", "Button")
            };
        }
    }
}
