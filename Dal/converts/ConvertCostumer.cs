using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Models;

namespace Dal.converts
{

    public class ConvertCostumer
    {
        public static Dto.DtoCustomer ConvertToDto(CustumerTbl c)
        {
            Dto.DtoCustomer cNew = new Dto.DtoCustomer();

            cNew.CustPhone = c.CustPhone;
            cNew.CustEmail = c.CustEmail;
            cNew.CustId = c.CustId;
            cNew.CustName = c.CustName;
            cNew.DateOfBirth = c.DateOfBirth;
            return cNew;
        }
        public static List<Dto.DtoCustomer> ToListCustomer(List<CustumerTbl> lc)
        {

            List<Dto.DtoCustomer> lnew = new List<Dto.DtoCustomer>();
            foreach (var c in lc)
            {
                lnew.Add(ConvertToDto(c));
            }
            return lnew;
        }


        public static CustumerTbl convertTomic(Dto.DtoCustomer c)
        {
            CustumerTbl cNew = new CustumerTbl();
            cNew.CustPhone = c.CustPhone;
            cNew.CustEmail = c.CustEmail;
            cNew.CustId = c.CustId;
            cNew.CustEmail = c.CustEmail;
            cNew.DateOfBirth = c.DateOfBirth;
            return cNew;
        }
    }
}
