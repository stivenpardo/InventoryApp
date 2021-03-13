using DataAccess;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public class B_InputOutput
    {
        public static List<InputOutputEntity> InputOutputList()
        {
            using (var db = new InventaryContext())
            {
                return db.InOuts.ToList();
            }
        }
        public static void CreateInputOutput(InputOutputEntity oInputOutput)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Add(oInputOutput);
                db.SaveChanges();
            }
        }
        public static void UpdateInputOutput( InputOutputEntity oInputOutput )
        {
            using ( var db = new InventaryContext())
            {
                db.InOuts.Update(oInputOutput);
                db.SaveChanges();
            }
        }

    }

}
