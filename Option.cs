using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace MDIXTemplateSelector
{
    public class Option : ObservableObject
    {
        public string Text { get; }

        public string Type { get; }

        private object _Value;
        public object Value
        {
            get => _Value;
            set => Set(ref _Value, value);
        }

        public Option(string text, string type)
        {
            Text = text;
            Type = type;
        }
    }
}
