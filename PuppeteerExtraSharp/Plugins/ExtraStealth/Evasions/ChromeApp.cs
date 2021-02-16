﻿using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using PuppeteerSharp;
[assembly: InternalsVisibleTo("Extra.Tests")]
namespace PuppeteerExtraSharp.Plugins.ExtraStealth.Evasions
{
    internal class ChromeApp : PuppeteerExtraPlugin
    {
        public ChromeApp(): base("stealth-chromeApp") { }

        public override Task OnPageCreated(Page page)
        {
            var script = Utils.GetScript("ChromeApp.js");
            return Utils.EvaluateOnNewPageWithUtilsScript(page, script);
        }
    }
}
