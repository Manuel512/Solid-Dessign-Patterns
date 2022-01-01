using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DessignPatterns.Factory_Pattern.Asynchronous_Factory_Method
{
    public class Foo
    {
        private Foo()
        {

        }

        private async Task<Foo> InitAsync()
        {
            await Task.Delay(1000);
            return this;
        }

        public static Task<Foo> CreateAsync()
        {
            var result = new Foo();
            return result.InitAsync();
        }

        public override string ToString()
        {
            return $"Foo Initialized";
        }
    }
}
