using System;
using System.Windows;
using CIM_Client.Views;
using MySql.Data.MySqlClient;

namespace CIM_Client.Utils;

public abstract class DbUtil
{

    private static MySqlConnection? _connection;

    public static MySqlConnection GetConnection()
    {
        if (_connection == null)
        {
            try
            {
                const string str = "server=localhost;User Id=root;password=root;Database=bravery_group";
                _connection = new MySqlConnection(str);
                _connection.Open();
            }
            catch (Exception)
            {
                var alertWindow = new AlertWindow();
                alertWindow.ConfirmationButtonClicked += (_, _) => Application.Current.Shutdown();
                alertWindow.ShowDialog("数据库连接失败，应用即将关闭");
            }
        }

        return _connection;
    }

}