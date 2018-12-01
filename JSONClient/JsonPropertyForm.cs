using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace JSONClient {
    public partial class JsonPropertyForm : Form {
        public static int TYPE_STRING = 0;
        public static int TYPE_INT = 1;
        public static int TYPE_DOUBLE = 2;

        public delegate void ResultDelegate(string name, object value, int type);
        private ResultDelegate resultDelegate = null;
        private ListViewItem item = null;

        public JsonPropertyForm(ResultDelegate resultDelegate) {
            InitializeComponent();
            this.resultDelegate = resultDelegate;
        }

        public JsonPropertyForm(ListViewItem item, ResultDelegate resultDelegate) {
            InitializeComponent();
            this.item = item;
            this.resultDelegate = resultDelegate;
        }

        private void Finish() {
            try {
                string name = nameInput.Text;
                string value = valueInput.Text;

                if (name.Length == 0 || value.Length == 0) {
                    throw new Exception();
                }

                if (stringTypeButton.Checked) {
                    resultDelegate(name, value, JsonPropertyForm.TYPE_STRING);
                } else if (intTypeButton.Checked) {
                    resultDelegate(name, int.Parse(value), JsonPropertyForm.TYPE_INT);
                } else if (doubleTypeButton.Checked) {
                    resultDelegate(name, double.Parse(value), JsonPropertyForm.TYPE_DOUBLE);
                }
                Close();
            } catch (FormatException) {
                MessageBox.Show("Cannot convert value to this type.");
            } catch (Exception) {
                MessageBox.Show("Canot do this process.");
            }
        }

        private void JsonPropertyForm_Load(object sender, EventArgs e) {
            if (item != null) {
                string name = item.SubItems[0].Text;
                string value = item.SubItems[1].Text;
                string type = item.SubItems[2].Text;

                nameInput.Text = name;
                valueInput.Text = value;

                if (type.Equals("string")) {
                    stringTypeButton.Checked = true;
                } else if (type.Equals("int")) {
                    intTypeButton.Checked = true;
                } else if (type.Equals("double")) {
                    doubleTypeButton.Checked = true;
                }

            }
        }

        private void nameInput_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Tab) {
                valueInput.Focus();
            }
        }
        
        private void okButton_Click(object sender, EventArgs e) {
            Finish();
        }

        private void JsonPropertyForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                Finish();
            }
        }
    }
}
