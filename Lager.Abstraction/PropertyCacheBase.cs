using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lager.Abstraction
{
    public abstract class PropertyCacheBase : ReactiveObject, IPropertyCache
    {
        protected String _cacheKey;

        public PropertyCacheBase(String cacheKey)
        {
            _cacheKey = cacheKey;
        }

        public abstract T GetOrCreate<T>(T defaultValue, [CallerMemberName] string key = null);

        public virtual Task InitializeAsync()
        {
            return TaskHelper.CompletedTask;
        }

        public abstract void SetOrCreate<T>(T value, [CallerMemberName] string key = null);
    
    }
}
