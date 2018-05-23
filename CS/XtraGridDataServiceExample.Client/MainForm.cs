using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using XtraGridDataServiceExample.Client.NorthwindGate;
using System.Data.Services.Client;
using System.Xml;
using DevExpress.XtraGrid.Views.Base;

namespace XtraGridDataServiceExample.Client {
    public partial class MainForm :XtraForm {
        NorthwindEntities Context;

        public MainForm() {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e) {
            Context = new NorthwindEntities(new Uri("http://localhost:12691/NorthwindGate.svc/"));
            Context.IgnoreResourceNotFoundException = true;
            Source.DataSource = Context.Products.ToList();
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e) {
            try {
                Context.SaveChanges();
            } catch (DataServiceRequestException ex) {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(ex.Response.First().Error.Message);
                XmlNodeList errors = doc.GetElementsByTagName("internalexception");
                if (errors.Count == 0)
                    errors = doc.GetElementsByTagName("error");
                if (XtraMessageBox.Show(this, errors[0]["message"].InnerText,
                    "Dx Sample", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        private void OnRowUpdated(object sender, RowObjectEventArgs e) {
            Context.UpdateObject(e.Row);
        }

        private void OnEmbeddedNavigatorButtonClick(object sender, NavigatorButtonClickEventArgs e) {
            switch (e.Button.ButtonType) {
                case NavigatorButtonType.Append:
                    e.Handled = true;
                    Context.AddObject("Products", Source.AddNew());
                    break;
                case NavigatorButtonType.Remove:
                    Context.DeleteObject(View.GetFocusedRow());
                    break;
            }
        }
    }
}
