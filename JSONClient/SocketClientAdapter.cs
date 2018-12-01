using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace JSONClient {
    public class SocketClientAdapter {
        private SocketClient socketClient = null;

        private SocketEventBridge realEventListener = null;

        private Queue<byte[]> queueForSend = null;

        private Thread connectThread = null;
        private Thread dataSendThread = null;
        private Thread dataReceiveThread = null;

        public SocketClientAdapter(Form form, SocketClient socketClient) {
            this.socketClient = socketClient;

            queueForSend = new Queue<byte[]>();

            realEventListener = new SocketEventBridge(form);
            socketClient.SetSocketEventListener(realEventListener);

            dataSendThread = new Thread(DataSendThread);
            dataSendThread.IsBackground = true;
            dataSendThread.Start();
        }

        public void SetSocketEventListener(SocketClient.ISocketEventListener listener) {
            realEventListener.SetEventListener(listener);
        }

        public void Connect(string ip, int port) {
            connectThread = new Thread(delegate() {
                socketClient.Connect(ip, port);
            });
            connectThread.IsBackground = true;
            connectThread.Start();
        }

        public void Disconnect() {
            connectThread.Interrupt();
            dataReceiveThread.Interrupt();
            Thread thread = new Thread(delegate () {
                socketClient.Disconnect();
            });
            thread.IsBackground = true;
            thread.Start();
        }

        public bool isSocketConnected() {
            return socketClient.isSocketConnected();
        }

        public void Send(byte[] buffer) {
            queueForSend.Enqueue(buffer);
        }

        public void StartDataReceiveCorutine() {
            dataReceiveThread = new Thread(socketClient.DataReceiveCorutine);
            dataReceiveThread.IsBackground = true;
            dataReceiveThread.Start();
        }

        public void DataSendThread() {
            while (true) {
                if (queueForSend.Count > 0) {
                    socketClient.Send(queueForSend.Dequeue());
                }
            }
        }

        private class SocketEventBridge : SocketClient.ISocketEventListener {
            private Form form = null;

            private SocketClient.ISocketEventListener eventListener = null;


            public SocketEventBridge(Form form) {
                this.form = form;
            }

            public void SetEventListener(SocketClient.ISocketEventListener listener) {
                eventListener = listener;
            }

            public void OnConnected() {
                if (eventListener != null) {
                    form.Invoke(new Action(delegate () {
                        eventListener.OnConnected();
                    }));
                }
            }

            public void OnConnectionFailed() {
                if (eventListener != null) {
                    form.Invoke(new Action(delegate () {
                        eventListener.OnConnectionFailed();
                    }));
                }
            }

            public void OnData(byte[] buffer) {
                if (eventListener != null) {
                    form.Invoke(new Action(delegate () {
                        eventListener.OnData(buffer);
                    }));
                }
            }

            public void OnDisconnected() {
                if (eventListener != null) {
                    form.Invoke(new Action(delegate () {
                        eventListener.OnDisconnected();
                    }));
                }
            }
        }
    }
}
