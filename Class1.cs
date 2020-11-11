using System;
using System.Collections.Generic;
using System.Text;

namespace classcourse
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.Configure<CookiePolicyOptions>(options =>
        {
            options.CheckConsentNeeded = context => true;
            options.MinimumSameSitePolicy = SameSiteMode.None;
        });
        
        services.AddTransient<ICourse, Projeto>();
        services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
    }
}
//teste