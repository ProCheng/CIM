using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Timers;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using CIM_Client.Utils;
using CIM_Client.ViewModels;
using Microsoft.Win32;
using MySql.Data.MySqlClient;

namespace CIM_Client.Views;

public partial class Register : BaseWindow
{

    //private readonly MySqlConnection _connection = DbUtil.GetConnection();

    public Register()
    {
        InitializeComponent();
    }

    private void UserRegister(object? sender, RoutedEventArgs? e) {

        new AlertWindow().ShowDialog("注册成功");
    }
    // 用户注册
    //private void UserRegister(object? sender, RoutedEventArgs? e)
    //{
    //    var alertWindow = new AlertWindow();

    //    var username = Username.Text;
    //    var password = Password.Password;

    //    // 用户信息校验

    //    if (username.Length is < 6 or > 12)
    //    {
    //        alertWindow.ShowDialog("用户名要求长度为6-12字符！");
    //        return;
    //    }
    //    if (password.Length is < 6 or > 15)
    //    {
    //        alertWindow.ShowDialog("密码要求长度为6-15字符！");
    //        return;
    //    }


    //    var query = $"select * from bg_user where phone = '{username}'";
    //    using var cmd1 = new MySqlCommand(query, _connection);
    //    var num = Convert.ToInt32(cmd1.ExecuteScalar());
    //    if (num > 0)
    //    {
    //        alertWindow.ShowDialog("该手机号码已注册！");
    //        return;
    //    }



    //    // 注册用户
    //    const string insert = $"insert into bg_user(username, password, sign, phone, avatar, gender, status) value " +
    //                       $"(@username, @password, @sign ,@phone, @avatar, 1, 0)";
    //    using var cmd2 = new MySqlCommand(insert, _connection);
    //    cmd2.Parameters.AddWithValue("@username", username);
    //    cmd2.Parameters.AddWithValue("@password", Convert.ToBase64String(MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(password))));
    //    cmd2.Parameters.AddWithValue("@sign", "这个人很高冷，没有个性签名");

    //    var rowAffected = cmd2.ExecuteNonQuery();
    //    if (rowAffected > 0)
    //    {
    //        alertWindow.ConfirmationButtonClicked += (_, _) =>
    //        {
    //            var login = new Login();
    //            Close();
    //            login.Show();
    //        };
    //        alertWindow.ShowDialog("注册成功！");
    //    }
    //    else
    //    {
    //        alertWindow.ShowDialog("注册失败！");
    //    }
    //}

    private void LoginByKeyboard(object sender, KeyEventArgs e)
    {
        if (e.Key != Key.Enter) return;
        e.Handled = true; // 阻止其他控件处理该事件


    }

    // 切换登录界面
    private void ChangeToLogin(object sender, RoutedEventArgs e)
    {
        var login = new Login();
        Close();
        login.Show();
    }

}