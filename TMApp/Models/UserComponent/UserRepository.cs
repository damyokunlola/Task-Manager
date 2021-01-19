using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TMApp.Models.UserComponent
{
    public class UserRepository : IUserRepository
    {
        protected readonly TMAppContext db;
        public UserRepository(TMAppContext con)
        {
            db = con;
        }
        public Register GetProfile(string Email)
        {
            try
            {
                var FindProfile = db.RegistersTable.Find(Email);
                    if (FindProfile != null)
                {
                    return FindProfile;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception)
            {
                throw new Exception("Error occur while geting user profile");
            }
        }

        public void RegisterUser(Register newUser)
        {
            try
            {
                db.RegistersTable.Add(newUser);
            }
            catch (Exception)
            {
                throw new Exception("Error occure while adding new user");
            }
        }

        //public ScheduleSet TaskList(string Email)
        //{
        //    try
        //    {
        //        var ListTask= db.ScheduleSetsTable.Find(Email);
        //        if (ListTask != null)
        //        {
                    
        //            db.ScheduleSetsTable.ToList();
        //        }

        //    }
        //    catch (Exception)
        //    {
        //        throw new Exception("errow occur while listing task");
        //    }
        //}

        public void UpdateUser(string Email)
        {
            throw new NotImplementedException();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls
        

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~UserRepository()
        // {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}