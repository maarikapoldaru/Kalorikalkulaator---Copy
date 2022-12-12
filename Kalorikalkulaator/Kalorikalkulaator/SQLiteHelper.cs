using Sitecore.FakeDb;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;
using static Android.Resource;

namespace Kalorikalkulaator
{
    
        public class SQLiteHelper
        {
            SQLiteAsyncConnection db;
            public SQLiteHelper(string dbPath)
            {
                db = new SQLiteAsyncConnection(dbPath);
                db.CreateTableAsync<Toit>().Wait();
            }

             
            public Task<int> SaveItemAsync(Toit toit)
            {
                //if (toit.ToitID != 0)
                //{
                //    return db.UpdateAsync(toit);
                //}
                //else
                //{
                    return db.InsertAsync(toit);
                //}
            }

            
            public Task<int> DeleteItemAsync(Toit toit)
            {
                return db.DeleteAsync(toit);
            }

            
            public Task<List<Toit>> GetItemsAsync()
            {
                return db.Table<Toit>().ToListAsync();
            }


            
            public Task<Toit> GetItemAsync(int toitId)
            {
                return db.Table<Toit>().Where(i => i.ToitID == toitId).FirstOrDefaultAsync();
            }

        internal Task GetItemAsync(object p)
        {
            throw new NotImplementedException();
        }
    }
    }
   






   