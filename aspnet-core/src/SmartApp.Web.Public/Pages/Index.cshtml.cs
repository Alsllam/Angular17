using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace SmartApp.Web.Public.Pages;

public class IndexModel : SmartAppPublicPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
