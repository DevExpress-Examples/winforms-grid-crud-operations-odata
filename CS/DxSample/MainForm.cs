using DevExpress.Data;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DxSample.Service.Models;
using System;
using System.Linq;

namespace DxSample {
    public partial class MainForm : XtraForm {
        Default.Container Context = new Default.Container(new Uri("http://localhost:50936/"));

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            this.customerBindingSource.DataSource = this.Context.Customers.ToList();
            this.orderBindingSource.DataSource = this.Context.Orders.ToList();
        }

        private void GridView_RowUpdated(object sender, RowObjectEventArgs e) {
            if (e.RowHandle == GridControl.NewItemRowHandle)
                this.Context.AddToOrders((Order)e.Row);
            else this.Context.UpdateObject(e.Row);
        }

        private void GridView_RowDeleted(object sender, RowDeletedEventArgs e) {
            this.Context.DeleteObject(e.Row);
        }

        private void SaveButton_ItemClick(object sender, ItemClickEventArgs e) {
            this.Context.SaveChanges();
        }
    }
}
