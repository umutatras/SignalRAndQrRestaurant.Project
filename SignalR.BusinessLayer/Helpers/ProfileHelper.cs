using AutoMapper;
using SignalR.BusinessLayer.Mappings.AutoMapper;

namespace SignalR.BusinessLayer.Helpers;

public static class ProfileHelper
{
    public static List<Profile> GetProfiles()
    {
        return new List<Profile>
        {
            new AboutProfile(),
        
        };

    }
}
