//------------------------------------------------------------------------------
// <copyright file="CarsDatabase.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;

namespace Ucu.Poo.Repositories
{
    /// <summary>
    /// Esta clase representa una base de datos de autos.
    /// </summary>
    public class CarsDatabase
    {
        private Repository<Car> repository = new Repository<Car>();

        public void Add(Car car)
        {
            this.repository.Add(car);
        }

        public void Remove(Car car)
        {
            this.repository.Remove(car);
        }

        public Car Find(Predicate<Car> criteria)
        {
            return this.repository.Find(criteria);
        }
    }
}
