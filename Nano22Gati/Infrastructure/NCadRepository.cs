using HostMgd.ApplicationServices;
using Nano22GatiCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teigha.DatabaseServices;

namespace Nano22Gati.Infrastructure
{
    internal class NCadRepository : INCadRepository
    {
        public bool IsDocumentActive
        {
            get
            {
                Document doc = Application.DocumentManager.MdiActiveDocument;
                return doc != null && doc.IsActive;
            }
        }

        public string DrawingName
        {
            get
            {
                Document doc = Application.DocumentManager.MdiActiveDocument;
                if (doc == null)
                {
                    return null;
                }
                return doc.Name;
            }
        }

        public List<string> GetLayerNamesList()
        {
            List<string> names = new List<string>();
            Database db = HostApplicationServices.WorkingDatabase;
            using(Transaction trans = db.TransactionManager.StartTransaction())
            {
                LayerTable layerTable = trans.GetObject(db.LayerTableId, OpenMode.ForRead) as LayerTable;
                foreach(ObjectId idObj in layerTable)
                {
                    LayerTableRecord item = trans.GetObject(idObj, OpenMode.ForRead) as LayerTableRecord;
                    if (!item.Name.Contains("|"))
                    {
                        names.Add(item.Name);
                    }
                }
            }
            return names.OrderBy(x => x).ToList();
        }

        public void ShowModalWindow(System.Windows.Window win)
        {
            win.ShowInTaskbar = false;
            Application.ShowModalWindow(win);
        }
    }
}
