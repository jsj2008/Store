﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDB.DAL
{
    interface IRepository<T>
        where T: class
    {
        IEnumerable<T> GetAll();
        T GetElement(int id);
        void Create(T item);
        void Update(T item);
        void Delete(int id);
    }
}
