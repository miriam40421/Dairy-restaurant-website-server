using Dal.DalClasses;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.converts
{
    public class ConvertOrder
    {
        public static Dto.DtoOrder ConvertToDto(OrderTbl o)
        {
            Dto.DtoOrder oNew = new Dto.DtoOrder();
            oNew.OrdDate = o.OrdDate;
            oNew.Ordnum = o.Ordnum;
            oNew.Cust.CustId = o.CustId;
            oNew.Sum = o.Sum;
            oNew.Ispaid = o.Ispaid;
            if (o.DetailsTbls.Count > 0)
            {
                oNew.listDetails = ConvertDetails.ToListDetails(o.DetailsTbls.ToList());
            }
            return oNew;
        }
        public static List<Dto.DtoOrder> ToListOrders(List<OrderTbl> lo)
        {
            List<Dto.DtoOrder> lnew = new List<Dto.DtoOrder>();
            foreach (var c in lo)
            {
                lnew.Add(ConvertToDto(c));
            }
            return lnew;
        }


        public static OrderTbl convertTomic(Dto.DtoOrder o)
        {
            OrderTbl oNew = new OrderTbl();

            oNew.CustId = o.Cust.CustId;
            oNew.Sum = o.Sum;
            oNew.OrdDate = o.OrdDate;
            oNew.Ordnum = o.Ordnum;
            oNew.Ispaid = o.Ispaid;

            return oNew;
        }
    }
}


