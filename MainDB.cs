using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lombard
{
    internal class MainDB
    {
        private static readonly MainDB _instance = new MainDB();

        private LombardDataSet _main_dataSet = new LombardDataSet();
        private bool _has_changes = false;
        public static MainDB GetInstance()
        {
            return _instance;
        }

        private MainDB() // Singleton
        {
                        
        }

        public LombardDataSet GetMainDataset()
        {
            return _main_dataSet;
        }
        public void LoadDBFromFile(string dbFilePath)
        {
             _main_dataSet = new LombardDataSet();

            using (var stream = System.IO.File.OpenRead(dbFilePath))
            {
                _main_dataSet.ReadXml(stream);
            }
                  
        }

        public void SaveDBToFile(string dbFilePath)
        {

            using (var stream = System.IO.File.Create(dbFilePath))
            {
                _main_dataSet.WriteXml(stream);
            }

        }

        public bool isDBChanged()
        {

            return _has_changes;
        
        }

        public bool setHasChangesDBState()
        {
            MainDB.GetInstance().GetMainDataset().AcceptChanges();
            return _has_changes = true;
       
        }
        public void acceptDBChanges()
        {

            _has_changes = false;
            _main_dataSet.AcceptChanges();

        }

    }

}
