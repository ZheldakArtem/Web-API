﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(TempWeb.Startup))]

namespace TempWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
       //     ConfigureAuth(app);
        }
    }
}
