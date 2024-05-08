using System.Windows;
using System.Windows.Controls;
using CIM_Client.Models;

namespace CIM_Client.UserControls;

public class MessageTemplateSelector : DataTemplateSelector
{
    public DataTemplate Received { get; set; }
    public DataTemplate Send { get; set; }

    public override DataTemplate SelectTemplate(object item, DependencyObject container)
    {
        var message = (Message)item;
        return message.Type == 1 ? Received : Send;
    }
}