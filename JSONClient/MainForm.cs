using System;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace JSONClient {
    public partial class MainForm : Form, SocketClient.ISocketEventListener {

        private SocketClient socketClient = null;
        private SocketClientAdapter socketClientAdapter = null;

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            socketClient = new SocketClient();
            socketClientAdapter = new SocketClientAdapter(this, socketClient);
            socketClientAdapter.SetSocketEventListener(this);
            socketClientAdapter.StartDataReceiveCorutine();
            
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

        private void AppendEventLog(string text) {
            eventLogView.Text += text + "\r\n";
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

        private void addPropertyButton_Click(object sender, EventArgs e) {
            JsonPropertyForm form = new JsonPropertyForm();
            form.ShowDialog();
        }

        private void RefreshSendJsonView() {

        }
    }
}
