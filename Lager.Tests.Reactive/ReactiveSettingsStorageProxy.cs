using Akavache;
using Lager.ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lager.Tests.Reactive
{
    public class ReactiveSettingsStorageProxy : ReactiveSettingsStorage
    {
        public ReactiveSettingsStorageProxy(IBlobCache blobCache = null)
            : base("#Storage#", blobCache ?? new InMemoryBlobCache())
        { }

        public T GetOrCreateProxy<T>(T defaultValue, string key)
        {
            return this.GetOrCreate(defaultValue, key);
        }

        public void SetOrCreateProxy<T>(T value, string key)
        {
            this.SetOrCreate(value, key);
        }
    }
}
