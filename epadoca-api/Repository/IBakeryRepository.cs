using epadoca_api.Model;
using System.Collections.Generic;

namespace epadoca_api.Repository
{
    public interface IBakeryRepository
    {
        List <BakeryModel> GetAll();
    }
}
