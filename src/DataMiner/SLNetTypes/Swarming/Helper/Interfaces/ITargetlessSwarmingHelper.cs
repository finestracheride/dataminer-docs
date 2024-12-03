﻿namespace Skyline.DataMiner.Net.Swarming.Helper.Interfaces
{
    public interface ITargetlessSwarmingHelper
    {
        /// <summary>
        /// Swarms one or more DMAObjects to a new hosting agent.
        /// </summary>
        /// <param name="dmaId"></param>
        /// <returns></returns>
        SwarmingResult[] ToAgent(int dmaId);
    }
}
