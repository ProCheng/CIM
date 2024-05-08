using CIM.IServers.Test;
using CIM_Client.Models;
using CIM_Client.Views;
using MySql.Data.MySqlClient;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CIM_Client.ViewModels
{
    public class LoginViewModel : BindableBase
    {
        private readonly ITest1Servers _test1Servers;

        public LoginViewModel(ITest1Servers test1Servers)
        {
            this._test1Servers = test1Servers;
        }

        public void Exec() {

            _test1Servers.Add();
        }

        

    }
}
