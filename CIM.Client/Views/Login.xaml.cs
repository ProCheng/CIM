using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using CIM_Client.Models;
using CIM_Client.Utils;
using CIM_Client.ViewModels;
using MySql.Data.MySqlClient;

namespace CIM_Client.Views;

public partial class Login: BaseWindow
{
    //private readonly MySqlConnection _connection = DbUtil.GetConnection();

    public Login()
    {
        InitializeComponent();
    }

    private void UserLogin(object sender, RoutedEventArgs e)
    {
        new AlertWindow().ShowDialog("登录成功");
        var md = (this.DataContext as LoginViewModel);
        md.Exec();
    }

    private void ChangeToRegister(object sender, RoutedEventArgs e)
    {

        var register = new Register();
        register.Show();
        Close();
    }

    private void LoginByKeyboard(object sender, KeyEventArgs e)
    {
        if (e.Key != Key.Enter) return;
                
        e.Handled = true; // 阻止其他控件处理该事件
        //UserLogin(null, null);
    }

}