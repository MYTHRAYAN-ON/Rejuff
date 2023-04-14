using Rejuff.BO;
using SQLite;
using System;

namespace Rejuff.Services
{
    public interface ISQLiteDB
    {
        SQLiteAsyncConnection GetConnection();
    }
    public class LocalDatabase
    {
        string databasepath;
        SQLiteConnection database;

        public LocalDatabase()
        {
            databasepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/SHSLocalDB.db3";
            database = new SQLiteConnection(databasepath);
        }

        public bool TableExists<T>(SQLiteConnection DatabasePath)
        {
            try
            {
                SQLite.TableMapping map = new TableMapping(typeof(T)); 
                object[] ps = new object[0]; 

                Int32 tableCount = DatabasePath.Query(map, "SELECT * FROM sqlite_master WHERE type = 'table' AND name = '" + map.TableName + "'", ps).Count; 
                if (tableCount == 0)
                {
                    return false;
                }
                else if (tableCount == 1)
                {
                    return true;
                }
                else
                {
                    throw new Exception("More than one table by the name of " + map.TableName + " exists in the database.", null);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogExceptions(ex.ToString());
                return false;

            }
        }

        public void DeleteUserProfile()
        {
            try
            {
                using (database = new SQLiteConnection(databasepath))
                {
                    if (TableExists<UserProfileBO>(database))
                    {
                        database.Execute("DROP TABLE IF EXISTS " + "UserProfileBO");
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogExceptions(ex.ToString());
            }
        }

        public void WriteUserProfile(UserProfileBO userProfileBO)
        {
            try
            {
                using (database = new SQLiteConnection(databasepath))
                {
                    if (TableExists<UserProfileBO>(database))
                    {
                        database.Execute("DROP TABLE IF EXISTS " + "UserProfileBO");

                    }
                    database.CreateTable<UserProfileBO>();
                    database.Insert(userProfileBO);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogExceptions(ex.ToString());
            }
        }

        public UserProfileBO ReadUserProfile()
        {
            try
            {
                using (database = new SQLiteConnection(databasepath))
                {
                    if (TableExists<UserProfileBO>(database))
                    {
                        var userProfile = database.Table<UserProfileBO>().FirstOrDefault();
                        return userProfile;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogExceptions(ex.ToString());
                return null;
            }
        }
    }
}
