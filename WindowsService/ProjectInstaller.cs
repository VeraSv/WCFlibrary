﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;
using System.ServiceProcess;


namespace WindowsService
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {

        ServiceInstaller serviceInstaller;
        ServiceProcessInstaller processInstaller;
        public ProjectInstaller()
        {
            InitializeComponent();
            serviceInstaller = new ServiceInstaller();
            processInstaller = new ServiceProcessInstaller();

            processInstaller.Account = ServiceAccount.LocalSystem;
            serviceInstaller.StartType = ServiceStartMode.Manual;
            serviceInstaller.ServiceName = "WindowsService";
            Installers.Add(processInstaller);
            Installers.Add(serviceInstaller);
        }
    }
}
