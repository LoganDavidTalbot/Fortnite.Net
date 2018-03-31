using Fortnite.Net.Enum;
using Fortnite.Net.Resources;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fortnite.Net.Interfaces
{
    public interface IFortniteClient
    {
        /// <summary>
        /// Set the ApiKey Only
        /// </summary>
        string ApiKey { set; }

        /// <summary>
        /// Gets the profile and static of fortnite user
        /// </summary>
        /// <param name="platform">Platform the fortnite user is on</param>
        /// <param name="name">Epic Nickname of fortnite user</param>
        /// <returns>Profile object filled with fortnite user's all time/ seasonal stats and recent games</returns>
        Profile GetProfile(string platform, string name);
        Profile GetProfile(EPlatform platform, string name);
        Profile GetPcProfile(string name);
        Profile GetXblProfile(string name);
        Profile GetPsnProfile(string name);
    }
}
