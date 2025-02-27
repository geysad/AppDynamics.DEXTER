﻿using AppDynamics.Dexter.ReportObjects;
using CsvHelper.Configuration;

namespace AppDynamics.Dexter.ReportObjectMaps
{
    public class NodeMetricReportMap : ClassMap<APMNode>
    {
        public NodeMetricReportMap()
        {
            int i = 0;
            Map(m => m.Controller).Index(i); i++;
            Map(m => m.ApplicationName).Index(i); i++;
            Map(m => m.TierName).Index(i); i++;
            Map(m => m.NodeName).Index(i); i++;
            Map(m => m.AgentType).Index(i); i++;
            Map(m => m.ART).Index(i); i++;
            Map(m => m.ARTRange).Index(i); i++;
            Map(m => m.TimeTotal).Index(i); i++;
            Map(m => m.Calls).Index(i); i++;
            Map(m => m.CPM).Index(i); i++;
            Map(m => m.Errors).Index(i); i++;
            Map(m => m.EPM).Index(i); i++;
            Map(m => m.Exceptions).Index(i); i++;
            Map(m => m.EXCPM).Index(i); i++;
            Map(m => m.HttpErrors).Index(i); i++;
            Map(m => m.HTTPEPM).Index(i); i++;
            Map(m => m.ErrorsPercentage).Index(i); i++;
            Map(m => m.AvailAgent).Index(i); i++;
            Map(m => m.AvailMachine).Index(i); i++;
            Map(m => m.HasActivity).Index(i); i++;
            Map(m => m.IsAPMAgentUsed).Index(i); i++;
            Map(m => m.IsMachineAgentUsed).Index(i); i++;
            EPPlusCSVHelper.setISO8601DateFormat(Map(m => m.From), i); i++;
            EPPlusCSVHelper.setISO8601DateFormat(Map(m => m.To), i); i++;
            EPPlusCSVHelper.setISO8601DateFormat(Map(m => m.FromUtc), i); i++;
            EPPlusCSVHelper.setISO8601DateFormat(Map(m => m.ToUtc), i); i++;
            Map(m => m.Duration).Index(i); i++;

            Map(m => m.ApplicationID).Index(i); i++;
            Map(m => m.TierID).Index(i); i++;
            Map(m => m.NodeID).Index(i); i++;
            Map(m => m.DetailLink).Index(i); i++;
            Map(m => m.MetricGraphLink).Index(i); i++;
            Map(m => m.FlameGraphLink).Index(i); i++;
            Map(m => m.FlameChartLink).Index(i); i++;
            Map(m => m.ControllerLink).Index(i); i++;
            Map(m => m.ApplicationLink).Index(i); i++;
            Map(m => m.TierLink).Index(i); i++;
            Map(m => m.NodeLink).Index(i); i++;
            Map(m => m.MetricLink).Index(i); i++;
        }
    }
}
