﻿using Incubadora.Domain;
using System.Collections.Generic;

namespace Incubadora.Business.Interface
{
    public interface IGiroBusiness
    {
        /// <summary>
        /// Este método se encarga de consultar todos los giros del catálogo de la bd.
        /// </summary>
        /// <returns>Una lista del catálogo de giros</returns>
        List<GiroDomainModel> GetGiros();

        /// <summary>
        /// Este método se encarga de consultar el giro por Id del catálogo de la bd.
        /// </summary>
        /// <returns>Un giro</returns>
        GiroDomainModel GetGiroById(string Id);
    }
}
