using ExportReportToFile.Models;
using Microsoft.PowerBI.Api.Models;

namespace ExportReportToFile
{

    class Program
    {
        // REMEBER TO SET ENVIRONMENT VARIABLE
        // "environmentVariables": {
        // "redirect-uri": "https:/localhost:44300",
        // "public-application-id": "000000000000000000000000000",
        // "confidential-application-secret": "000000000000000000000000000000000=",
        // "confidential-application-id": "000000000000000000000000000",
        // "tenant-name": "00000000000000000000000000000000",
        // "export-folder-path": "\\ExportReportToFile\\Exports"

        static void Main()
        {

            string workspaceName = "PMR";
            string powerBiReportName = "TestReport";

            // get workspace info
            var workspace = PowerBiExportManager.GetWorkspace(workspaceName);

            // Export Power BI Report
            var powerBiReport = PowerBiExportManager.GetReport(workspace.Id, powerBiReportName);
            PowerBiExportManager.ExportPowerBIReport(workspace.Id, powerBiReport.Id, powerBiReportName, FileFormat.PDF);

        }
    }
}
