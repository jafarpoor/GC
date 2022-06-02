using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GcService.Model
{
    public class Book : IDisposable
    {
        private bool Disposed = false;

        ~Book()
        {
            CleanUp(false);
        }

        public void Dispose()
        {
            CleanUp(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void CleanUp(bool disposing)
        {
            if (!Disposed)
            {
                Disposed = true;
                if (disposing)
                {
                    // clean up  unmanagent resource
                }

                else
                {
                    //base.finalize();
                }
            }
        }
    }
}
