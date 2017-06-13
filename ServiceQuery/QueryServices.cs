using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ServiceProcess;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Management;
using Microsoft.Win32;
using System.Threading.Tasks;

namespace ServiceQuery
{
    public class QueryServices : Query
    {
        private ImportInfo info;
        private string selectedServer;
        private string place1, place2;
        private DataTable csvServer;
        private DataTable csvService;
        private DataTable csvServersAux;
        private DataTable csvServicesAux;
        private ManagementObject manager;
        private ManagementScope conection;
        private bool estado;
        private List<string> ServicesListTyp;
        private List<string> ServicesListTypAux;
        private List<string> ServersListTyp;
        private List<string> ServersListTypAux;

        public QueryServices()
        {
            info = new ImportInfo();
            estado = info.CheckBoxDefaultValue;
            LoadServersTable();
            LoadServicesTable(info.PathServices1);
            SetServersTyp();
        }

        #region Set ComboBox
        /*
         * Metodo encargado de proporcionar informacion para
         * los combobox de la clase WindowMain.
         * Recibe desde la clase WindowMain un parametro de tipo
         * string con la informacion del elemento seleccionado.
         * 
         * @selectedItem = parametro selecionado en el comboBox de la clase
         * windowMain
         * */
        public void SetComboBoxServer(string selectedServer)
        {
            
            csvServer = new DataTable();
            csvService = new DataTable();

            ServicesListTypAux = new List<string>();

            csvServer.Columns.Add("ServerTyp", typeof(string));
            csvServer.Columns.Add("ServerName", typeof(string));
            csvServer.Columns.Add("PlaceName", typeof(string));

            csvService.Columns.Add("ServerTyp", typeof(string));
            csvService.Columns.Add("ServiceName", typeof(string));
            csvService.Columns.Add("ServiceTyp", typeof(string));

            for (int i = 0; i < csvServersAux.Rows.Count; i++)
            {
                if(csvServersAux.Rows[i]["ServerTyp"].ToString().Equals(selectedServer))
                {
                    csvServer.ImportRow(csvServersAux.Rows[i]);
                }              
            }
            for (int j = 0; j < csvServicesAux.Rows.Count; j++)
            {
                if (csvServicesAux.Rows[j]["ServerTyp"].ToString().Equals(selectedServer))
                {
                    csvService.ImportRow(csvServicesAux.Rows[j]);
                    ServicesListTypAux.Add(csvServicesAux.Rows[j]["ServiceTyp"].ToString());
                }
            }

            SetServicesTyp();

            this.NotifyObs();
        }

        public void SetComboService(string path)
        {
            string csv_file = path;
            csvService = info.GetDataTableFromScV(csv_file);     
        }

        #endregion Set ComboBox

        #region Geters
        //Metodos set y get de la variable csvData
        public DataTable CsvServer
        {
            get
            {
                return csvServer;
            }
            set
            {
                this.csvServer = value;                
            }
        }

        public DataTable CsvService
        {
            get
            {
                return csvService;
            }
            set
            {
                this.csvService = value;               
            }
        }

        public string Place1
        { 
            get
            {
                return place1;
            }
        }
        
        public string Place2
        {
            get
            {
                return place2;
            }
        }


        public bool Estado
        {
            get
            {
                return estado;
            }
        }

        public List<string> GetServicesTyp
        {
            get
            {
                return ServicesListTyp;
            }
        }

        public List<string> GetServersTyp
        {
            get
            {
                return ServersListTyp;
            }
        }

        #endregion Geters


        #region Querys
        public String PingToServer(string server)
        {
            Ping ping = new Ping();
            int timeout = 20;
            try
            {
                if (ping.Send(server, timeout).Status == IPStatus.Success)
                {
                    return "The server " + server + " responded successfully ";
                }
                else
                {
                    return "Server " + server + " does not responding";
                }
            }
            catch(Exception ex)
            {
                return "Server " + server + " was not Found, " + ex.Message;
            }
        }

        /**
         * 
         * */
        public ServiceController GetServiceQuery(string serviceName, string serverName)
        {
            ServiceController scServices;
            try
            {
                scServices = new ServiceController(serviceName, serverName);
                return scServices;
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show( ex.Message);
                return null;
            }
            catch(InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }


        public string StartModeService(string serverName, string serviceName)
        {
            string mode = "";
            try
            {
                conection = ConectToServer(serverName);

                SelectQuery wmiQuery = new SelectQuery("SELECT * FROM Win32_Service WHERE Name='" + serviceName + "'");
                var searcher = new ManagementObjectSearcher(conection, wmiQuery);
                var results = searcher.Get();

                foreach (ManagementObject service in results)
                {
                    mode = service["StartMode"].ToString();
                }
            }
            catch(Exception ex)
            {
                mode = " ";
            }
            
            return mode;
        }



        public void StopService(string nameService, string nameServer)
        {
            ServiceController sc = new ServiceController(nameService, nameServer);

            try
            {
                //determina el tiempo de espera para status
                //TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                if (sc != null && sc.Status == ServiceControllerStatus.Running)
                {
                    sc.Stop();
                }
                //sc.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
                sc.Close();
            }
            catch(Exception ex)
            {
                sc.Close();
            }
        }


        public void StartService(string nameService, string nameServer)
        {
            ServiceController sc = new ServiceController(nameService, nameServer);           
            try
            {
                //TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                if (sc != null && sc.Status == ServiceControllerStatus.Stopped)
                {
                    sc.Start();
                }
                else { }
                //sc.WaitForStatus(ServiceControllerStatus.Running, timeout);
                sc.Close();
            }
            catch (Exception ex)
            {
                sc.Close();
            }
        }


        public void RestartService(string nameService, string nameServer)
        {
            ServiceController sc = new ServiceController(nameService, nameServer);

            try
            {
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                if (sc != null && sc.Status == ServiceControllerStatus.Running)
                {
                    sc.Stop();
                    sc.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
                    sc.Start();
                    //sc.WaitForStatus(ServiceControllerStatus.Running, timeout);
                }
                else if (sc != null && sc.Status == ServiceControllerStatus.Stopped)
                { }

                //sc.Close();
            }
            catch (Exception ex)
            {
                sc.Close();
            }
        }

        /**
         * Recive un valor de tipo int desde los
         * botones de la clase WindowMain y
         * decide que tarea va a realizar.
         * */
        public void DetectingTask(string nameService, string nameServer, int task)
        {
            int value = task;
            switch (value)
            {
                case 0:
                    StartService(nameService, nameServer);
                    break;
                case 1:
                    StopService(nameService, nameServer);
                    break;
                case 2:
                    RestartService(nameService, nameServer);
                    break;
            }
        }

        /**
         * metodo utilizado para cambiar el Start-Mode de los servicios
         * de windows
         * @param task : tarea a realizar(Enable, Disabled)
         * */
        public void HandlingService(string nameService, string nameServer, string task)
        {
            
                conection = ConectToServer(nameServer);

                SelectQuery wmiQuery = new SelectQuery("SELECT * FROM Win32_Service WHERE Name='" + nameService + "'");
                var searcher = new ManagementObjectSearcher(conection, wmiQuery);
                var results = searcher.Get();

                foreach (ManagementObject mo in results)
                {
                    ManagementBaseObject inParams = mo.GetMethodParameters("ChangeStartMode");
                    inParams["startmode"] = task;
                    ManagementBaseObject outParams = mo.InvokeMethod("ChangeStartMode", inParams, null);
                    task = mo.Properties["StartMode"].Value.ToString().Trim();
                }
           
        }
        #endregion

        #region Load Csv


        /**
         * Metodo encargado de guardar la informacion correspondiente 
         * a los nombres de los servidores en una variable de tipo Table
         * */
        public void LoadServersTable()
        {
            csvServersAux = info.GetDataTableFromScV(info.PathServers1);
        }

        public void LoadServicesTable(string path)
        {
            csvServicesAux = info.GetDataTableFromScV(path);
        }

        public void SetServicesTyp()
        {
            ServicesListTyp = new List<string>();
            ServicesListTyp = ServicesListTypAux.Distinct().ToList();     
        }

        public void SetServersTyp()
        {
            LoadServersTable();
            ServersListTypAux = new List<string>();
            for (int i = 0; i < csvServersAux.Rows.Count; i++)
            {
                ServersListTypAux.Add(csvServersAux.Rows[i]["ServerTyp"].ToString());
            }
            ServersListTyp = ServersListTypAux.Distinct().ToList();
        }

        #endregion

    }
}
