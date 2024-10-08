﻿using BusinessLayer.Abstact;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DestinationManager : IDestinationService
    {
        IDestinationDal _destinationDal;

        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public void Add(Destination t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Destination t)
        {
            throw new NotImplementedException();
        }

        public Destination GetById(int id)
        {
            return _destinationDal.TGetById(id);
        }

        public List<Destination> GetList()
        {
            return _destinationDal.TGetList();
        }

        public void Update(Destination t)
        {
            throw new NotImplementedException();
        }
    }
}
