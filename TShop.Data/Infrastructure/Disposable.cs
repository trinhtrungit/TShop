using System;

namespace TShop.Data.Infrastructure
{
    public class Disposable : IDisposable
    {
        private bool isDisposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool isDisposing)
        {
            if (!isDisposed && isDisposing)
            {
                DisposeCore();
            }
            isDisposed = true;
        }

        // declare to child class override
        protected virtual void DisposeCore()
        {
            // Do something
        }

        ~Disposable()
        {
            Dispose(false);
        }
    }
}