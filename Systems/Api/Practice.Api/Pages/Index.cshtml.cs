namespace Practice.Api.Pages;

using Practice.Api.Settings;
using Practice.Common;
using Practice.Services.Settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;
using NSwag.AspNetCore;

public class IndexModel : PageModel
{
    [BindProperty]
    public bool OpenApiEnabled => settings.Enabled;

    [BindProperty]
    public string Version => Assembly.GetExecutingAssembly().GetAssemblyVersion();

    [BindProperty]
    public string HelloMessage => apiSettings.HelloMessage;


    private readonly Services.Settings.SwaggerSettings settings;
    private readonly ApiSpecialSettings apiSettings;

    public IndexModel(Services.Settings.SwaggerSettings settings, ApiSpecialSettings apiSettings)
    {
        this.settings = settings;
        this.apiSettings = apiSettings;
    }

    public void OnGet()
    {
    }
}
