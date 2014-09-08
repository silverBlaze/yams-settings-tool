using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace YAMSDatabaseSettings {
    internal class YamsData : IDisposable {

        private string connection;
        private SqlCeConnection dbConn = null;

        public YamsData(string connString) {
            connection = connString;
            dbConn = new SqlCeConnection(connection);
        }

        public void Dispose() {
            if (dbConn != null) {
                dbConn.Dispose();
            }
        }

        public void GetYamsSettingsData(DataTable dt) {
            string[] items;
            dt.Rows.Clear();
            if(dbConn.State != ConnectionState.Open)
                dbConn.Open();
            using (var q = new SqlCeCommand("SELECT SettingName, SettingValue FROM YAMSSettings;", dbConn)) {
                SqlCeDataReader rdr = q.ExecuteReader();
                while (rdr.Read()) {
                    items = new string[] { rdr.GetString(0), rdr.GetString(1) };
                    dt.Rows.Add(items);
                }
            }
        }

        public void GetServerSettingsData(DataTable dt, int serverId) {
            string[] items;
            dt.Rows.Clear();
            if(dbConn.State != ConnectionState.Open)
                dbConn.Open();
            using (var q = new SqlCeCommand("SELECT SettingName, SettingValue, ServerID FROM MCSettings WHERE ServerID = @serverId;", dbConn)) {
                q.Parameters.Add("@serverId", serverId);
                SqlCeDataReader rdr = q.ExecuteReader();
                while (rdr.Read()) {
                    items = new string[] { rdr.GetString(0), rdr.GetString(1) };
                    dt.Rows.Add(items);
                }
            }
        }

        public void LoadServerList(ComboBox ddl) {
            ddl.Items.Clear();
            if (dbConn.State != ConnectionState.Open)
                dbConn.Open();
            ServerListItem item;
            using (var q = new SqlCeCommand("SELECT ServerID, ServerTitle FROM MCServers;", dbConn)) {
                SqlCeDataReader rdr = q.ExecuteReader();
                while (rdr.Read()) {
                    item = new ServerListItem() { ID = rdr.GetInt32(0), Name = rdr.GetString(1) };
                    ddl.Items.Add(item);
                }
            }
        }

        public void DeleteServerSetting(string remove, int serverId) {
            if (dbConn.State != ConnectionState.Open)
                dbConn.Open();
            using (var q = new SqlCeCommand("DELETE FROM MCSettings WHERE SettingName = @key AND ServerID = @serverId;", dbConn)) {
                q.Parameters.Add("@key", remove);
                q.Parameters.Add("@serverId", serverId);
                q.ExecuteNonQuery();
            }
        }

        public void DeleteYamsSetting(string remove) {
            if (dbConn.State != ConnectionState.Open)
                dbConn.Open();
            using (var q = new SqlCeCommand("DELETE FROM YAMSSettings WHERE SettingName = @key;", dbConn)) {
                q.Parameters.Add("@key", remove);
                q.ExecuteNonQuery();
            }
        }

        public void UpdateServerSetting(string key, string value, int serverId) {
            if (dbConn.State != ConnectionState.Open)
                dbConn.Open();
            using (var q = new SqlCeCommand("UPDATE MCSettings SET SettingValue = @value WHERE SettingName = @key AND ServerID = @serverId;", dbConn)) {
                q.Parameters.Add("@value", value);
                q.Parameters.Add("@key", key);
                q.Parameters.Add("@serverId", serverId);
                q.ExecuteNonQuery();
            }
        }

        public void UpdateYamsSetting(string key, string value) {
            if(dbConn.State != ConnectionState.Open)
                dbConn.Open();
            using (var q = new SqlCeCommand("UPDATE YAMSSettings SET SettingValue = @value WHERE SettingName = @key;", dbConn)) {
                q.Parameters.Add("@value", value);
                q.Parameters.Add("@key", key);
                q.ExecuteNonQuery();
            }
        }

        public TableSettingsData GetServerTableData(int serverId) {
            var retval = new TableSettingsData();
            if (dbConn.State != ConnectionState.Open)
                dbConn.Open();
            using (var q = new SqlCeCommand("SELECT ServerID, ServerTitle, ServerWrapperMode, ServerEnableOptimisations, ServerAssignedMemory, ServerAutostart, ServerType, ServerLogonMode, ServerCustomJar, ServerWebBody FROM MCServers WHERE ServerID = @serverId;", dbConn)) {
                q.Parameters.Add("@serverId", serverId);
                SqlCeDataReader rdr = q.ExecuteReader();
                rdr.Read();
                retval.ServerID = rdr.GetInt32(0);
                if (!rdr.IsDBNull(1)) 
                    retval.ServerTitle = rdr.GetString(1);
                if (!rdr.IsDBNull(2)) 
                    retval.ServerWrapperMode = rdr.GetBoolean(2).ToString().ToLower();
                if (!rdr.IsDBNull(3))
                    retval.ServerEnableOptimisations = rdr.GetBoolean(3).ToString().ToLower();
                if (!rdr.IsDBNull(4))
                    retval.ServerAssignedMemory = rdr.GetInt32(4).ToString();
                if (!rdr.IsDBNull(5))
                    retval.ServerAutostart = rdr.GetBoolean(5).ToString().ToLower();
                if (!rdr.IsDBNull(6))
                    retval.ServerType = rdr.GetString(6);
                if (!rdr.IsDBNull(7))
                    retval.ServerLogonMode = rdr.GetString(7);
                if (!rdr.IsDBNull(8))
                    retval.ServerCustomJar = rdr.GetString(8);
                if (!rdr.IsDBNull(9))
                    retval.ServerWebBody = rdr.GetString(9);
            }
            return retval;
        }

        public void UpdateServerTableData(int serverId, TableSettingsData data) {
            if (dbConn.State != ConnectionState.Open)
                dbConn.Open();

            bool wrapperMode = false;
            bool enableOptimisations = false;
            int assignedMemory = 0;
            bool autostart = false;

            if (!bool.TryParse(data.ServerWrapperMode, out wrapperMode)
             || !bool.TryParse(data.ServerEnableOptimisations, out enableOptimisations)
             || !Int32.TryParse(data.ServerAssignedMemory, out assignedMemory)
             || !bool.TryParse(data.ServerAutostart, out autostart)) {
                throw new Exception("Cannot parse field value");
            }

            using (var q = new SqlCeCommand("UPDATE MCServers SET ServerTitle = @title, ServerWrapperMode = @wrapperMode, ServerEnableOptimisations = @enableOptimisations, ServerAssignedMemory = @assignedMemory, ServerAutostart = @autostart, ServerType = @serverType, ServerLogonMode = @logonMode, ServerCustomJar = @customJar, ServerWebBody = @webBody WHERE ServerID = @serverId;", dbConn)) {
                q.Parameters.Add("@title", data.ServerTitle ?? (object)DBNull.Value);
                q.Parameters.Add("@wrapperMode", wrapperMode);
                q.Parameters.Add("@enableOptimisations", enableOptimisations);
                q.Parameters.Add("@assignedMemory", assignedMemory);
                q.Parameters.Add("@autostart", autostart);
                q.Parameters.Add("@serverType", data.ServerType ?? (object)DBNull.Value);
                q.Parameters.Add("@logonMode", data.ServerLogonMode ?? (object)DBNull.Value);
                q.Parameters.Add("@customJar", data.ServerCustomJar ?? (object)DBNull.Value);
                q.Parameters.Add("@webBody", data.ServerWebBody ?? (object)DBNull.Value);
                q.Parameters.Add("@serverId", serverId);

                q.ExecuteNonQuery();
            }
        }
    }

    public class ServerListItem {
        public string Name { get; set; }
        public int ID { get; set; }
        public override string ToString() {
            return Name;
        }
    }

    public class TableSettingsData {
        public int ServerID { get; set; }
        public string ServerTitle { get; set; }
        public string ServerWrapperMode { get; set; }
        public string ServerEnableOptimisations { get; set; }
        public string ServerAssignedMemory { get; set; }
        public string ServerAutostart { get; set; }
        public string ServerType { get; set; }
        public string ServerLogonMode { get; set; }
        public string ServerCustomJar { get; set; }
        public string ServerWebBody { get; set; }
    }
}
