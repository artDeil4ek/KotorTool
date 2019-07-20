using System;

namespace KotorTool_2._0.Services
{
    public interface I2Da
    {
        void CreateDataTable();
        Array GetRow(object rowNumber);
        string GetIndiceData(int rowNumber, int colNumber);
        string GetIndiceData(int rowNumber, string colName);
        string GetIndiceData(string rowName, int colNumber);
        string GetIndiceData(string rowName, string colName);
    }
}