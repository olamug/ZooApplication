using AnimalsConsoleApp.Interface;
using System;
using System.IO;
using System.Text.Json;

namespace AnimalsConsoleApp.Services
{
    class LogService
    {
        public void AddLogDataToLogFile(Type AddedItemType, Guid ID)
        {
            var logFile = @"C:\Users\kuber\source\repos\ZooSimulator\AnimalsConsoleApp\Services\log.txt";
            var logData = GetLogData(AddedItemType, ID);
            if (File.Exists(logFile))
            {
                File.AppendAllText(logFile, logData);
            }
            else
            {
                Console.WriteLine("The log file does not exist and will be created.");
                File.AppendAllText(logFile, logData);
            }
        }

        public string GetLogData(Type AddedItemType, Guid ID)
        {
            var logDateTime = DateTime.Now.ToString();
            var itemType = AddedItemType.ToString();
            var id = ID.ToString();
            var logDataToSave = JsonSerializer.Serialize(logDateTime + " : " + itemType + " ID " + id + "\n");
            return logDataToSave;
        }
    }
}
