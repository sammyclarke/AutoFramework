﻿using Excel;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace AutoFramework.Helpers
{
    class ExcelHelpers
    {
        private static List<Datacollection> dataCol = new List<Datacollection>();

        public static void PopulateInCollection(string fileName)
        {
            DataTable table = ExcelToDataTable(fileName);

            //Iterate through the rows and columns of the table
            for (int row = 1; row <= table.Rows.Count; row++)
            {
                for (int col = 0; col < table.Columns.Count; col++)
                {
                    Datacollection dtTable = new Datacollection()
                    {
                        rowNumber = row,
                        colName = table.Columns[col].ColumnName,
                        colValue = table.Rows[row - 1][col].ToString()

                    };
                    //add all the details for each row
                    dataCol.Add(dtTable);
                }
            }
        }
        private static DataTable ExcelToDataTable(string fileName)
        {
            //open file and returns as stream
            FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
            //create opemxmlreader via ExcelReaderFactory
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream); //.xlsx
            //set the first row as column name
            excelReader.IsFirstRowAsColumnNames = true;
            //return as DataSet
            DataSet result = excelReader.AsDataSet();
            //get all the tables
            DataTableCollection table = result.Tables;
            //store it in DataTable
            DataTable resultTable = table["sheet1"];
            return resultTable;
        }
    }

    public class Datacollection
    {
        public int rowNumber { get; set; }
        public string colName { get; set; }
        public string colValue { get; set; }
    }


}
