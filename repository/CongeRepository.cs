﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GRHGRASP.model;
namespace GRHGRASP.repository
{
    interface CongeRepository
    {
        void demander(int id);
        List<CongeModel> getConges();
    }
}
