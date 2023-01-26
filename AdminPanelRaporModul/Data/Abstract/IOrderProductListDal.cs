using AdminPanelRaporModul.Models;
using Core.DataAccess;

namespace AdminPanelRaporModul.Data.Abstract
{
    public interface IOrderProductListDal : IEntityRepository<ProductOrder>
    {
    }
}
