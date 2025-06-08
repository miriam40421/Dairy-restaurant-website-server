using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.converts
{
    internal class ConvertPrudact

    {

        public static Dto.DtoProducts ConvertToDto(ProductsTbl c)
        {
            Dto.DtoProducts cNew = new Dto.DtoProducts();
            cNew.ProdDesc = c.ProdDesc;
            cNew.Cost = c.Cost;
            cNew.CatId = c.CatId;
            cNew.ProdId = c.ProdId;
            cNew.Img = c.Img;
            cNew.Name = c.Name;
            cNew.LastDateUpdate = c.LastDateUpdate;
            cNew.Oty = c.Oty;
            if (c.Cat != null)
                cNew.CatName = c.Cat.Name;
            return cNew;
        }
        public static List<Dto.DtoProducts> ToListPrudacts(List<ProductsTbl> lc)
        {
            List<Dto.DtoProducts> lnew = new List<Dto.DtoProducts>();
            foreach (var c in lc)
            {
                lnew.Add(ConvertToDto(c));
            }
            return lnew;
        }


        public static ProductsTbl convertTomic(Dto.DtoProducts c)
        {
            ProductsTbl cNew = new ProductsTbl();

            cNew.ProdDesc = c.ProdDesc;
            cNew.CatId = c.CatId;
            cNew.Cost = c.Cost;
            cNew.Oty = c.Oty;
            return cNew;
        }
    }
}

