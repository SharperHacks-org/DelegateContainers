// Copyright and trademark notices at the end of this file.

using Microsoft.Extensions.Logging;

using SharperHacks.CoreLibs.LogWrappers;

namespace SharperHacks.CoreLibs.DelegateContainers;

// Base class for AtScopeExit* clases. Encapsulates the IDisposable pattern.
//
public abstract class AtScopeExitBase : IDisposable
{
    // Indicates whether Dispose(bool) has been called already.
    //
    protected bool DisposedValue { get; set; }

    // Get or set the logger interface to use.
    //
    protected ILogger? Logger { get; set; }

    // Called only when Dispose(true) and disposedValue is false.
    // This is never called on the finalizer.
    //
    protected abstract void DisposeManaged();

    // Called when Dispose(true) and disposedValue is false.
    // Always called in the finalizer, even if Dispose() is not called
    // for some reason.
    //
    protected abstract void DisposeUnmanaged();

    // Constructor.
    //
    // @logger
    //
    protected AtScopeExitBase(ILogger? logger = null)
    {
        Logger = logger;
    }

    // @IDisposable.Dispose()
    protected virtual void Dispose(bool disposing)
    {
        if (DisposedValue) return;

        try
        {
            if (disposing)
            {
                DisposeManaged();
            }

            DisposeUnmanaged();
        }
        catch (Exception ex)
        {
            if (Logger is not null)
            {
                Logger.LogException(ex);
            }
            else
            {
                throw;
            }
        }

        DisposedValue = true;
    }

    // Finalizer for IDisposable pattern.
    //
    ~AtScopeExitBase()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: false);
    }

    // @IDisposable.Dispose()
    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}

// Copyright Joseph W Donahue and Sharper Hacks LLC (US-WA)
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// SharperHacks is a trademark of Sharper Hacks LLC (US-Wa), and may not be
// applied to distributions of derivative works, without the express written
// permission of a registered officer of Sharper Hacks LLC (US-WA).
