using epadoca_api.DAO;
using epadoca_api.Model;
using System.Collections.Generic;

namespace epadoca_api.Repository
{
    public class BakeryRepository: IBakeryRepository
    {
        public readonly BakeryDAO _bakeryDAO;

        public BakeryRepository() { 
            _bakeryDAO = new BakeryDAO();
        }

        public List<BakeryModel> GetAll()
        {
            return _bakeryDAO.GetBakery();
        }
    }
}
