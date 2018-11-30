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

        private ListViewItem item = null;

        public JsonPropertyForm() {
            InitializeComponent();
        }

        public JsonPropertyForm(ListViewItem item) {
            InitializeComponent();
            this.item = item;
        }

        private void JsonPropertyForm_Load(object sender, EventArgs e) {
            if (item != null) {
                
            }
        }
    }
}
