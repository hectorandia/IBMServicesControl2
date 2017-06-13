using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Microsoft.VisualBasic.FileIO;
using System.Configuration;
using System.Windows.Forms;

namespace ServiceQuery
{
    class ImportInfo
    {
        //variable donde se guarda el archivo csv en formato de tabla
        private DataTable csvData;


        private string pathServers1;

        private string pathServices1;

        private bool checkBoxDefaultValue;

        public ImportInfo()
        {
            LoadCsvFiles();
            checkBoxDefaultValue = Convert.ToBoolean(ConfigurationManager.AppSettings["checkBoxDefaultValue"]);
        }
        
        /*
         * Metodo encargado de convertir un archivo csv en un DataTable.
         * El parametro csv_file_path recibe la ubicacion del documento.
         * */
        public DataTable GetDataTableFromScV(string csv_file_path)
        {
            csvData = new DataTable();
            try
            {
                using (TextFieldParser csvReader = new TextFieldParser(csv_file_path))
                {
                    csvReader.SetDelimiters(new string[] { ";" });
                    csvReader.HasFieldsEnclosedInQuotes = true;
                    //Read column names
                    string[] colFields = csvReader.ReadFields();
                    foreach (string column in colFields)
                    {
                        DataColumn datecolumn = new DataColumn(column);
                        datecolumn.AllowDBNull = true;
                        csvData.Columns.Add(datecolumn);
                    }
                    while (!csvReader.EndOfData)
                    {
                        string[] fieldData = csvReader.ReadFields();
                        //Making empty value as null
                        for (int i = 0; i < fieldData.Length; i++)
                        {
                            if (fieldData[i] == "")
                            {
                                fieldData[i] = null;
                            }
                        }
                        csvData.Rows.Add(fieldData);
                    }
                }
            }
            catch (Exception ex)
            {


            }
            return csvData;
        }

        public void LoadCsvFiles()
        {
            try
            {

                //
                //Variables de tipo string, donde se guarda la hubicacion de cada archivo 
                //csv especificada en el archivo App.config
                //
                pathServers1 = ConfigurationManager.AppSettings["pathServers1"];
                pathServices1 = ConfigurationManager.AppSettings["pathServices1"];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        //
        //Metodos get para las variables de tipo string donde se almacena la ubicacion
        //de cada archivo CSV
        //
        public string PathServers1
        {
            get
            {
                return pathServers1; //Retorna una lista con los nombres de los servicios
            }
        }

        public string PathServices1
        {
            get
            {
                return pathServices1; //Retorna una lista con los nombres de los servicios
            }
        }


        public bool CheckBoxDefaultValue
        {
            get
            {
                return checkBoxDefaultValue;
            }
        }

    }
}
