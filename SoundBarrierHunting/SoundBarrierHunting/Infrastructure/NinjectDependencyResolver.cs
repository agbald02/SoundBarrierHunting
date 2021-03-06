﻿using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Ninject;
using SoundBarrierHunting.Domain.Interfaces;
using SoundBarrierHunting.Domain.Entities;
using SoundBarrierHunting.Domain.Concrete;

namespace SoundBarrierHunting.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver 
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            kernel.Bind<IVideoRepository>().To<VideoRepository>();
            kernel.Bind<IProductRepository>().To<ProductRepository>();
        }
    }
}