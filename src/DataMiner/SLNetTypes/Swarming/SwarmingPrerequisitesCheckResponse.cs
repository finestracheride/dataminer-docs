﻿﻿using System;
using Skyline.DataMiner.Net.Messages;

namespace Skyline.DataMiner.Net.Swarming
{
    /// <summary>
    /// Response for <see cref="SwarmingPrerequisitesCheckRequest"/>
    /// </summary>
    [Serializable]
    public class SwarmingPrerequisitesCheckResponse : ResponseMessage
    {
        /// <summary>
        /// <code>true</code> only if the cluster config is ready for enabling Swarming.
        /// An example of an incompatible configuration is a Failover setup.
        /// </summary>
        public bool SupportedDMS { get; set; }

        /// <summary>
        /// <code>true</code> only if the DataMiner System uses a clustered database
        /// </summary>
        public bool SupportedDatabase { get; set; }

        /// <summary>
        /// <code>true</code> only if legacy dashboards are truly disabled
        /// </summary>
        public bool LegacyReportsAndDashboardsDisabled { get; set; }

        /// <summary>
        /// <code>true</code> only if no central database has been configured.
        /// </summary>
        public bool CentralDatabaseNotConfigured { get; set; }

        /// <summary>
        /// Whether incompatible AlarmID usages were detected in scripts.
        /// Also returns true in case this check was requested to be skipped in the message
        /// </summary>
        public bool NoObsoleteAlarmIdUsageInScripts { get; set; }

        /// <summary>
        /// Whether incompatible AlarmID usages were detected in protocol QActions.
        /// Also returns true in case this check was requested to be skipped in the message
        /// </summary>
        public bool NoObsoleteAlarmIdUsageInProtocolQActions { get; set; }

        /// <summary>
        /// <code>true</code> if enhanced services on the system are compatible with Swarming.
        /// </summary>
        public bool NoIncompatibleEnhancedServicesOnDMS { get; set; }

        /// <summary>
        /// A textual summary of the issues that were found (if any)
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// Combined value for the individual results.
        /// </summary>
        public bool SatisfiesPrerequisites =>
            SupportedDMS
            && SupportedDatabase
            && LegacyReportsAndDashboardsDisabled
            && CentralDatabaseNotConfigured
            && NoObsoleteAlarmIdUsageInScripts
            && NoObsoleteAlarmIdUsageInProtocolQActions
            && NoIncompatibleEnhancedServicesOnDMS;
    }
}