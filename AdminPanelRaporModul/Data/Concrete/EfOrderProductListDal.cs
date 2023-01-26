using AdminPanelRaporModul.Data.Abstract;
using AdminPanelRaporModul.Models;
using Core.EntityFreamwork;

namespace AdminPanelRaporModul.Data.Concrete
{


    public class EfOrderProductListDal : EfEntityRepositoryBase<ProductOrder,WebContext>,IOrderProductListDal
    {
        
    }
}
