using Akavache;
using Lager.ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lager.Tests.Reactive
{
    public class DummySettingsStorage : ReactiveSettingsStorage
    {
        public DummySettingsStorage(string keyPrefix, IBlobCache cache)
            : base(keyPrefix, cache)
        { }

        public int DummyNumber
        {
            get { return this.GetOrCreate(42); }
            set { this.SetOrCreate(value); }
        }

        public string DummyText
        {
            get { return this.GetOrCreate("Yaddayadda"); }
            set { this.SetOrCreate(value); }
        }
    }
}
