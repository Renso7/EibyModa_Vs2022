﻿using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBussnies
{
    /*public interface IAlquilerBussnies: ICRUDBussnies<AlquilerRequest,AlquilerResponse>*/
    public interface ITipoDocBussnies: ICRUDBussnies<TipoDocRequest, TipoDocResponse>
    {

    }
}
