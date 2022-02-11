using ExportReportToFile.Models;
using Microsoft.PowerBI.Api.Models;

namespace ExportReportToFile
{

  class Program
  {

    static void Main()
    {

      string workspaceName = "PMR";
      string powerBiReportName = "PortalFornecedor - Acessos - 90 dias";

      // get workspace info
      var workspace = PowerBiExportManager.GetWorkspace(workspaceName);

      // Export Power BI Report
      var powerBiReport = PowerBiExportManager.GetReport(workspace.Id, powerBiReportName);
      PowerBiExportManager.ExportPowerBIReport(workspace.Id, powerBiReport.Id, powerBiReportName, FileFormat.PDF);

    }
  }
}
