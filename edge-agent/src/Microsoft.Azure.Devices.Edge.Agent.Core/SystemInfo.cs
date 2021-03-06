// Copyright (c) Microsoft. All rights reserved.

namespace Microsoft.Azure.Devices.Edge.Agent.Core
{
    public class SystemInfo
    {
        public SystemInfo(string operatingSystemType, string architecture, string version, ProvisioningInfo provisioning, string serverVersion, string kernelVersion, string operatingSystem, int numCpus)
        {
            this.OperatingSystemType = operatingSystemType;
            this.Architecture = architecture;
            this.Version = version;
            this.Provisioning = provisioning;
            this.ServerVersion = serverVersion;
            this.KernelVersion = kernelVersion;
            this.OperatingSystem = operatingSystem;
            this.NumCpus = numCpus;
        }

        public SystemInfo(string operatingSystemType, string architecture, string version)
            : this(operatingSystemType, architecture, version, ProvisioningInfo.Empty, string.Empty, string.Empty, string.Empty, 0)
        {
        }

        public string OperatingSystemType { get; }

        public string Architecture { get; }

        public string Version { get; }

        public ProvisioningInfo Provisioning { get; }

        public string ServerVersion { get; }

        public string KernelVersion { get; }

        public string OperatingSystem { get; }

        public int NumCpus { get; }

        static SystemInfo Empty { get; } = new SystemInfo(string.Empty, string.Empty, string.Empty);
    }
}
