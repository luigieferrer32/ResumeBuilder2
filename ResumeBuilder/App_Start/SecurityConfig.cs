using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.Google;
using Owin;

namespace ResumeBuilder.App_Start
{
    public class SecurityConfig
    {
        public static void Configure(IAppBuilder app)
        {
            // Enable the application to use a cookie to store information for the signed in user
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ExternalCookie
            });

            // Use a cookie to temporarily store information about a user logging in with a third party login provider
            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            // Configure google authentication
            var options = new GoogleOAuth2AuthenticationOptions()
            {
                ClientId = "600419893999-5aclh44gcf08kqjbp8484livoi1gl3oe.apps.googleusercontent.com",
                ClientSecret = "RlgM6bK4cdP6ym7trkcG9PW6"
            };

            app.UseGoogleAuthentication(options);
        }
    }
}