using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstact;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concerete
{
    public class FeatureManager : IFeatureService
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void Add(Feature entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Feature entity)
        {
            throw new NotImplementedException();
        }

        public Feature GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Feature> GetList()
        {
            return _featureDal.TGetList();
        }

        public void Update(Feature entity)
        {
            throw new NotImplementedException();
        }
    }
}
