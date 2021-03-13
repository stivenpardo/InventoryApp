using System.Collections.Generic;
using Entities;
using DataAccess;
using System.Linq;

namespace Business
{
    public class B_Warehouse
    {
        public static List<WareHouseEntity> WarehouseList()
        {
            using (var db = new InventaryContext())
            {
                return db.Warehouses.ToList();
            }
        }
        public static WareHouseEntity WarehouseById (string id)
        {
            using (var db = new InventaryContext())
            {
                return db.Warehouses.ToList().LastOrDefault(w=>w.WarehouseId==id);
            }
        }
        public static void CreateWarehouse(WareHouseEntity oWarehouse)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouses.Add(oWarehouse);
                db.SaveChanges();
            }
        }
        public static void UpdateWarehouse( WareHouseEntity oWarehouse)
        {
            using ( var db = new InventaryContext())
            {
                db.Warehouses.Update(oWarehouse);
                db.SaveChanges();
            }
        }
    }
}
