using Dal.Models;
using Dto;
using I_Bll;
using I_Dall;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Bll
{
    public class BllOrder : I_Bll.IBllOrder
    {
        BigBiteContext db;
        Order orderDal;
        IdalDetail IdalDetail;
        public BllOrder(Order c, IdalDetail IdalDetail, BigBiteContext db)
        {
            this.orderDal = c;
            this.IdalDetail = IdalDetail;
            this.db = db;
        }
        public async Task<List<Dto.DtoOrder>> SelectAllAsync()
        {

            return await orderDal.SelectAllAsync();
        }
        public async Task<Dto.DtoOrder> SelectByIdAsync(int id)
        {
            return await orderDal.SelectByIdAsync(id);
        }
        //הפונקציה מחזירה לנו את המחיר הסופי לאחר ההנחה של יום הולדת
        public async Task<double?> returnSum(DateTime date, double? s)
        {  if(date.Month== DateTime.Today.Month)
            {
                 s -=20;
            }
        
            return s ;
        }
        //הפונקציה מוסיפה את ההזמנה החדשה  ועוברת על הרשימה של פרטי הזמנה שיש לאוביקט הזמנה 
        //ומעדכנת את מס ההזמנה לש פרטי ההזמנה למס הזמנה שנוצרה עכשיו
        //ובנוסף מוסיפה את פרטי ההזמנה לטבלת הפרטים
        public async Task<int> AddAsync(DtoOrder d)
        {
            d.Ispaid = true;
            d.Sum = d.Sum;
            int newId = await orderDal.AddAsync(d);
            if (d.listDetails != null)
            {
                foreach (var item in d.listDetails)
                {
                    item.Ordnum = newId;
                    var entityDetail = Dal.converts.ConvertDetails.convertTomic(item);
                    db.DetailsTbls.Add(entityDetail);
                    await db.SaveChangesAsync();
                }
            }
            return newId;
        }

    }
}

