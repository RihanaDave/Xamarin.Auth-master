﻿using System;

namespace Xamarin.Auth.ProviderSamples
{
    public partial class GithubOAuth2Https127001 : Helpers.OAuth2
    {
        partial void SetPublicNonSensitiveData();
        partial void SetPrivateSensitiveData();

        public GithubOAuth2Https127001()
        {
            SetPublicNonSensitiveData();
            SetPrivateSensitiveData();

            return;
        }

        partial void SetPublicNonSensitiveData()
        {
            ProviderName = "Github";
            OrderUI = "4";
            Description = "Github OAuth2 https://127.0.0.1";
            HowToMarkDown =
@"
https://github.com/settings/applications
https://developer.github.com/v3/oauth/#scopes
https://github.com/settings/developers
";
            OAuth_IdApplication_IdAPI_KeyAPI_IdClient_IdCustomer = "";
            OAuth2_Scope = ""; // "", "user",
            OAuth_UriAuthorization = new Uri("https://github.com/login/oauth/authorize");
            OAuth_UriAccessToken_UriRequestToken = new Uri("https://github.com/login/oauth/access_token");
            OAuth_UriCallbackAKARedirect = new Uri("https://127.0.0.1");
            AllowCancel = true;

            return;
        }
    }
}

