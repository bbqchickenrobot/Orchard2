﻿using Microsoft.Extensions.DependencyInjection;
using Orchard.ContentManagement;
using Orchard.DependencyInjection;

namespace Orchard.Contents
{
    public class Module : IModule
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddContentManagement();
        }
    }
}