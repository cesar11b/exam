﻿using Appcore.Interfaces;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appcore.Services
{
    public abstract class BaseServices<T> : IService<T>
    {
        private IModel<T> Model;
        protected BaseServices(IModel<T> model)
        {
            this.Model = model;
        }

        public T Extracción(string t)
        {
            return Model.Extraccion(t);
        }
    }
}
