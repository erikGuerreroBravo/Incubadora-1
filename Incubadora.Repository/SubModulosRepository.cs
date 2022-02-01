﻿using Incubadora.Repository.Infraestructure;
using Incubadora.Repository.Infraestructure.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incubadora.Repository
{
    public class SubModulosRepository : BaseRepository<SubModulos>
    {
        public SubModulosRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
    }
}
