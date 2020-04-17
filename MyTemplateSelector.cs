using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace MDIXTemplateSelector
{
    [ContentProperty(nameof(Templates))]
    public class MyTemplateSelector : DataTemplateSelector
    {
        public ResourceDictionary Templates { get; set; } = new ResourceDictionary();


        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is Option option)
            {
                return Templates[option.Type] as DataTemplate;
            }
            return base.SelectTemplate(item, container);
        }
    }
}
