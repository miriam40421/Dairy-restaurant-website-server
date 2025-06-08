using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.converts
{
    public class ConvertDetails
    {
        public static Dto.DtoDetails ConvertToDto(DetailsTbl c)
        {
            Dto.DtoDetails cNew = new Dto.DtoDetails();
            cNew.Qty = c.Qty;
            cNew.Ordnum = c.Ordnum;
            cNew.Id = c.Id;
            cNew.Prod.ProdId = c.ProdId;
            return cNew;
        }
        public static List<Dto.DtoDetails> ToListDetails(List<DetailsTbl> lc)
        {
            List<Dto.DtoDetails> lnew = new List<Dto.DtoDetails>();
            foreach (var c in lc)
            {
                lnew.Add(ConvertToDto(c));
            }
            return lnew;
        }


        public static DetailsTbl convertTomic(Dto.DtoDetails c)
        {
            DetailsTbl cNew = new DetailsTbl();
            cNew.Qty = c.Qty;
            cNew.Ordnum = (short?)c.Ordnum;
            cNew.Id = c.Id;
            cNew.ProdId = c.Prod.ProdId;



            return cNew;
        }
    }
}

