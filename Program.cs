using System.Threading.Tasks;
using Statiq.App;
using Statiq.Web;
using System;
using System.Linq;
using Statiq.Common;

namespace MySite
{
    public class Program
    {
        public static async Task<int> Main(string[] args) =>
          await Bootstrapper
            .Factory
            .CreateWeb(args)
            /*.AddSetting(Keys.LinksUseHttps, true)*/
            .RunAsync();
    }
}
