using System;
using NzbDrone.Api.REST;
using NzbDrone.Core.Authentication;
using NzbDrone.Core.Configuration;
using NzbDrone.Core.Update;

namespace NzbDrone.Api.Config
{
    public class HostConfigResource : RestResource
    {
        public string BindAddress { get; set; }
        public int Port { get; set; }
        public int SslPort { get; set; }
        public bool EnableSsl { get; set; }
        public bool LaunchBrowser { get; set; }
        public AuthenticationType AuthenticationMethod { get; set; }
        public bool AnalyticsEnabled { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string LogLevel { get; set; }
        public string Branch { get; set; }
        public string ApiKey { get; set; }
#warning FIXME: Unused.
        public bool Torrent { get; set; }
        public string SslCertHash { get; set; }
        public string UrlBase { get; set; }
        public bool UpdateAutomatically { get; set; }
        public UpdateMechanism UpdateMechanism { get; set; }
        public string UpdateScriptPath { get; set; }
    }

    public static class HostConfigResourceMapper
    {
        public static HostConfigResource ToResource(this IConfigFileProvider model)
        {
            return new HostConfigResource
            {
                BindAddress = model.BindAddress,
                Port = model.Port,
                SslPort = model.SslPort,
                EnableSsl = model.EnableSsl,
                LaunchBrowser = model.LaunchBrowser,
                AuthenticationMethod = model.AuthenticationMethod,
                AnalyticsEnabled = model.AnalyticsEnabled,
                //Username
                //Password
                LogLevel = model.LogLevel,
                Branch = model.Branch,
                ApiKey = model.ApiKey,
                SslCertHash = model.SslCertHash,
                UrlBase = model.UrlBase,
                UpdateAutomatically = model.UpdateAutomatically,
                UpdateMechanism = model.UpdateMechanism,
                UpdateScriptPath = model.UpdateScriptPath,
            };
        }
    }
}
