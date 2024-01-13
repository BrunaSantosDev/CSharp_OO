using System;

namespace Course.Entities.Enum
{
    enum OrderStatus : int
    {
        Pending_Payment,
        Processing = 1,
        Shipped = 2,
        Delivered = 3,
    }
}
