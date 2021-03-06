﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_updater_lib
{
    public class InstallPath
    {
        public String Name { get; set; }
        public String Path { get; set; }
        public String Password { get; set; }
        public Boolean IsDefault { get; set; }
        public String Executable { get; set; }

        public InstallPath() {
            this.Name = "";
            this.Path = "";
            this.Password = "";
            this.IsDefault = false;
        }

        public InstallPath(String Name, String Path, String Password, Boolean IsDefault)
        {
            this.Name = Name;
            this.Path = Path;
            this.Password = Password;
            this.IsDefault = IsDefault;
        }
        public InstallPath(String Name, String Path, String Password, Boolean IsDefault, String Executable)
        {
            this.Name = Name;
            this.Path = Path;
            this.Password = Password;
            this.IsDefault = IsDefault;
            this.Executable = Executable;
        }
    }
}
