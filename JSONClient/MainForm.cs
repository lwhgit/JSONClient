using System;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace JSONClient {
    public partial class MainForm : Form, SocketClient.ISocketEventListener {

        private SocketClient socketClient = null;
        private SocketClientAdapter socketClientAdapter = null;

        private List<JsonData> savedJsonList = null;

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            socketClient = new SocketClient();
            socketClientAdapter = new SocketClientAdapter(this, socketClient);
            socketClientAdapter.SetSocketEventListener(this);
            socketClientAdapter.StartDataReceiveCorutine();

            savedJsonList = new List<JsonData>();
        }

        private void SendCurrentJson() {
            if (!socketClientAdapter.isSocketConnected()) {
                MessageBox.Show("Socket was closed.");
                return;
            }

            JObject jobj = new JObject();
            JsonData jsonData = new JsonData();

            for (int i = 0; i < currentJsonView.Items.Count; i++) {
                ListViewItem item = currentJsonView.Items[i];
                string name = item.SubItems[0].Text;
                string value = item.SubItems[1].Text;
                string type = item.SubItems[2].Text;

                if (type.Equals("string")) {
                    jobj.Add(name, value);
                } else if (type.Equals("int")) {
                    jobj.Add(name, int.Parse(value));
                } else if (type.Equals("double")) {
                    jobj.Add(name, double.Parse(value));
                }
                jsonData.AddProperty(name, value, type);
            }
            if (jobj.GetValue("request") == null) {
                MessageBox.Show("JSON must have 'request' property");
                return;
            }

            socketClientAdapter.Send(Encoding.UTF8.GetBytes(jobj.ToString()));
            AppendEventLog("Sent a json.");

            savedJsonListView.Items.Add(jobj.GetValue("request"));
            savedJsonList.Add(jsonData);
            currentJsonView.Items.Clear();
        }

        private void ShowAddPropertyDialog() {
            JsonPropertyForm form = new JsonPropertyForm(delegate (string name, object value, int type) {
                string[] arr = new string[3];
                arr[0] = name;
                arr[1] = value.ToString();

                if (type == JsonPropertyForm.TYPE_STRING) {
                    arr[2] = "string";
                } else if (type == JsonPropertyForm.TYPE_INT) {
                    arr[2] = "int";
                } else if (type == JsonPropertyForm.TYPE_DOUBLE) {
                    arr[2] = "double";
                }

                ListViewItem item = new ListViewItem(arr);
                currentJsonView.Items.Add(item);

            });
            form.ShowDialog();
        }

        private void AppendEventLog(string text) {
            eventLogView.Text += text + "\r\n";
        }

        private void SetJsonView(ListView jsonView, JsonData jsonData) {
            jsonView.Items.Clear();

            for (int i = 0; i < jsonData.GetPropertyCount(); i++) {
                JsonData.PropertyData propertyData = jsonData.GetProperty(i);
                jsonView.Items.Add(new ListViewItem(new string[] { propertyData.name, propertyData.value, propertyData.type }));
            }
        }

        public void OnConnected() {
            AppendEventLog("Connected.");
        }

        public void OnConnectionFailed() {
            AppendEventLog("Connection failed.");
        }

        public void OnDisconnected() {
            AppendEventLog("Disconnected.");
        }

        public void OnData(byte[] buffer) {
            string msg = Encoding.UTF8.GetString(buffer);
            JObject jobj = JObject.Parse(msg);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.Control && e.KeyCode == Keys.A) {
                ShowAddPropertyDialog();
            } else if (e.Control && e.Alt && e.Shift && e.KeyCode == Keys.S) {
                SendCurrentJson();
            }
        }

        private void connectButton_Click(object sender, EventArgs e) {
            if (socketClientAdapter.isSocketConnected()) {
                AppendEventLog("Socket is already connected.");
            } else {
                string ip = ipInput.Text;
                int port = int.Parse(portInput.Text);
                socketClientAdapter.Connect(ip, port);
            }
        }

        private void disconnectButton_Click(object sender, EventArgs e) {
            if (socketClientAdapter.isSocketConnected()) {
                socketClientAdapter.Disconnect();
                AppendEventLog("Disconnected.");
            } else {
                AppendEventLog("Socket is already closed.");
            }
        }

        private void addPropertyButton_Click(object sender, EventArgs e) {
            ShowAddPropertyDialog();
        }

        private void removePropertyButton_Click(object sender, EventArgs e) {
            if (currentJsonView.SelectedItems.Count > 0) {
                ListViewItem item = currentJsonView.SelectedItems[0];

                currentJsonView.Items.Remove(item);
            }
        }

        private void sendButton_Click(object sender, EventArgs e) {
            SendCurrentJson();
        }

        private void savedJsonListView_SelectedIndexChanged(object sender, EventArgs e) {
            int index = savedJsonListView.SelectedIndex;
            JsonData jsonData = savedJsonList[index];

            SetJsonView(savedJsonView, jsonData);
        }

        private void savedJsonListView_DoubleClick(object sender, EventArgs e) {
            int index = savedJsonListView.SelectedIndex;
            JsonData jsonData = savedJsonList[index];

            SetJsonView(currentJsonView, jsonData);
        }

        private void currentJsonView_DoubleClick(object sender, EventArgs e) {
            JsonPropertyForm form = new JsonPropertyForm(currentJsonView.SelectedItems[0], delegate (string name, object value, int type) {
                string[] arr = new string[3];
                arr[0] = name;
                arr[1] = value.ToString();

                if (type == JsonPropertyForm.TYPE_STRING) {
                    arr[2] = "string";
                } else if (type == JsonPropertyForm.TYPE_INT) {
                    arr[2] = "int";
                } else if (type == JsonPropertyForm.TYPE_DOUBLE) {
                    arr[2] = "double";
                }

                ListViewItem item = new ListViewItem(arr);
                currentJsonView.Items[currentJsonView.SelectedIndices[0]] = item;

            });
            form.ShowDialog();
        }

        public class JsonData {
            private List<PropertyData> propertyList = null;

            public JsonData() {
                propertyList = new List<PropertyData>();
            }

            public void AddProperty(string name, string value, string type) {
                propertyList.Add(new PropertyData(name, value, type));
            }

            public PropertyData GetProperty(int index) {
                return propertyList[index];
            }

            public int GetPropertyCount() {
                return propertyList.Count;
            }

            public class PropertyData {
                public string name = null;
                public string value = null;
                public string type = null;

                public PropertyData(string name, string value, string type) {
                    this.name = name;
                    this.value = value;
                    this.type = type;
                }
            }
        }
    }
}
