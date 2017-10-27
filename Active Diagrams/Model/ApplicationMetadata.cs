using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Active_Diagrams.Model
{
    internal class ApplicationMetadata
    {
        internal int Revision { get;}
        internal int MajorVersion { get; }
        internal int MinorVersion { get; }

        internal ApplicationMetadata()
        {
            Version version;

            version = (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed) ?
               System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion :
               System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

            Revision = version.Revision;
            MajorVersion = version.Major;
            MinorVersion = version.Minor;

        }
    }
}
