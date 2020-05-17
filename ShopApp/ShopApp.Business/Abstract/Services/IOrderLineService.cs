using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Business.Abstract.Services
{
    public interface IOrderLineService : IService<OrderLine>
    {
        decimal GetTotalPriceOfUnit();
    }
}
