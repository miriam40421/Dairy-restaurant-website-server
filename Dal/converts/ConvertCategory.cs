using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.converts
{
    public class ConvertCategory
    {
        public static Dto.DtoCategory ConvertToDto(CategoryTbl c)
        {
            Dto.DtoCategory cNew = new Dto.DtoCategory();
            cNew.CatId = c.CatId;
            cNew.Name = c.Name;
            return cNew;
        }
        public static List<Dto.DtoCategory> ToListCategory(List<CategoryTbl> lc)
        {
            List<Dto.DtoCategory> lnew = new List<Dto.DtoCategory>();
            foreach (var c in lc)
            {
                lnew.Add(ConvertToDto(c));
            }
            return lnew;
        }


        public static CategoryTbl convertTomic(Dto.DtoCategory c)
        {
          CategoryTbl cNew = new CategoryTbl();
            cNew.CatId = c.CatId;
            cNew.Name = c.Name;
           
            return cNew;
        }
    }
}
