﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void TInsert(T item);
        void TDelete(T item);
        void TUpdate(T item);
        List<T> TGetList();
        T TGetByID(int id);
    }
}
