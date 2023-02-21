﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        //Tüm araçları listelicek
        List<Car> GetAll();
        List<CarDetailDto> GetCarDetails();

    }
}
