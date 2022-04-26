using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.Utility
{
    public static class SD
    {
        //Session Key
        public const string sesModule = "SessionSelectedModule";
        public const string sesModuleName = "SessionSelectedModuleName";


        //Statik list data
        public static string[] AssetDataRetention = { "Day", "Month", "Year" };
        public static string[] AssetOwnership = { "Internal", "3rd Party" };
        public static string[] ScopeOrg = { "Internal", "3rd Party" };
        public static string[] HostingType = { "Cloud", "On-Premises" };
        public static string[] LocParties = { "Access", "Use Data" };
        public static string[] RiskStage = { "new", "under evaluation", "in review", "live" };

}
}
