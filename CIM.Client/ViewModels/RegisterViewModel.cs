using CIM.IServers.Test;
using CIM_Client.Views;
using MySql.Data.MySqlClient;
using Prism.Commands;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Regions;
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

    public class RegisterViewModel : BindableBase
    {
        private readonly ITest1Servers _test1Servers;

        public RegisterViewModel(ITest1Servers test1Servers)
        {
            this._test1Servers = test1Servers;
        }

        public void Exec()
        {
            
            _test1Servers.Add();
        }
        

    }
}
