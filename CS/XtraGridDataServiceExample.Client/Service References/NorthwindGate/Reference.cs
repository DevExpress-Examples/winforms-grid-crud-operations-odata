//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17626
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 6/21/2012 11:30:43 AM
namespace XtraGridDataServiceExample.Client.NorthwindGate
{
    
    /// <summary>
    /// There are no comments for NorthwindEntities in the schema.
    /// </summary>
    public partial class NorthwindEntities : global::System.Data.Services.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new NorthwindEntities object.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public NorthwindEntities(global::System.Uri serviceRoot) : 
                base(serviceRoot)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            if (typeName.StartsWith("NorthwindModel", global::System.StringComparison.Ordinal))
            {
                return this.GetType().Assembly.GetType(string.Concat("XtraGridDataServiceExample.Client.NorthwindGate", typeName.Substring(14)), false);
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            if (clientType.Namespace.Equals("XtraGridDataServiceExample.Client.NorthwindGate", global::System.StringComparison.Ordinal))
            {
                return string.Concat("NorthwindModel.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// There are no comments for Products in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Product> Products
        {
            get
            {
                if ((this._Products == null))
                {
                    this._Products = base.CreateQuery<Product>("Products");
                }
                return this._Products;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Product> _Products;
        /// <summary>
        /// There are no comments for Products in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToProducts(Product product)
        {
            base.AddObject("Products", product);
        }
    }
    /// <summary>
    /// There are no comments for NorthwindModel.Product in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ProductID
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Products")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("ProductID")]
    public partial class Product : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Product object.
        /// </summary>
        /// <param name="productID">Initial value of ProductID.</param>
        /// <param name="productName">Initial value of ProductName.</param>
        /// <param name="discontinued">Initial value of Discontinued.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Product CreateProduct(int productID, string productName, bool discontinued)
        {
            Product product = new Product();
            product.ProductID = productID;
            product.ProductName = productName;
            product.Discontinued = discontinued;
            return product;
        }
        /// <summary>
        /// There are no comments for Property ProductID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int ProductID
        {
            get
            {
                return this._ProductID;
            }
            set
            {
                this.OnProductIDChanging(value);
                this._ProductID = value;
                this.OnProductIDChanged();
                this.OnPropertyChanged("ProductID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _ProductID;
        partial void OnProductIDChanging(int value);
        partial void OnProductIDChanged();
        /// <summary>
        /// There are no comments for Property ProductName in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ProductName
        {
            get
            {
                return this._ProductName;
            }
            set
            {
                this.OnProductNameChanging(value);
                this._ProductName = value;
                this.OnProductNameChanged();
                this.OnPropertyChanged("ProductName");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ProductName;
        partial void OnProductNameChanging(string value);
        partial void OnProductNameChanged();
        /// <summary>
        /// There are no comments for Property SupplierID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> SupplierID
        {
            get
            {
                return this._SupplierID;
            }
            set
            {
                this.OnSupplierIDChanging(value);
                this._SupplierID = value;
                this.OnSupplierIDChanged();
                this.OnPropertyChanged("SupplierID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _SupplierID;
        partial void OnSupplierIDChanging(global::System.Nullable<int> value);
        partial void OnSupplierIDChanged();
        /// <summary>
        /// There are no comments for Property CategoryID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CategoryID
        {
            get
            {
                return this._CategoryID;
            }
            set
            {
                this.OnCategoryIDChanging(value);
                this._CategoryID = value;
                this.OnCategoryIDChanged();
                this.OnPropertyChanged("CategoryID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CategoryID;
        partial void OnCategoryIDChanging(global::System.Nullable<int> value);
        partial void OnCategoryIDChanged();
        /// <summary>
        /// There are no comments for Property QuantityPerUnit in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string QuantityPerUnit
        {
            get
            {
                return this._QuantityPerUnit;
            }
            set
            {
                this.OnQuantityPerUnitChanging(value);
                this._QuantityPerUnit = value;
                this.OnQuantityPerUnitChanged();
                this.OnPropertyChanged("QuantityPerUnit");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _QuantityPerUnit;
        partial void OnQuantityPerUnitChanging(string value);
        partial void OnQuantityPerUnitChanged();
        /// <summary>
        /// There are no comments for Property UnitPrice in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<decimal> UnitPrice
        {
            get
            {
                return this._UnitPrice;
            }
            set
            {
                this.OnUnitPriceChanging(value);
                this._UnitPrice = value;
                this.OnUnitPriceChanged();
                this.OnPropertyChanged("UnitPrice");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<decimal> _UnitPrice;
        partial void OnUnitPriceChanging(global::System.Nullable<decimal> value);
        partial void OnUnitPriceChanged();
        /// <summary>
        /// There are no comments for Property UnitsInStock in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<short> UnitsInStock
        {
            get
            {
                return this._UnitsInStock;
            }
            set
            {
                this.OnUnitsInStockChanging(value);
                this._UnitsInStock = value;
                this.OnUnitsInStockChanged();
                this.OnPropertyChanged("UnitsInStock");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<short> _UnitsInStock;
        partial void OnUnitsInStockChanging(global::System.Nullable<short> value);
        partial void OnUnitsInStockChanged();
        /// <summary>
        /// There are no comments for Property UnitsOnOrder in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<short> UnitsOnOrder
        {
            get
            {
                return this._UnitsOnOrder;
            }
            set
            {
                this.OnUnitsOnOrderChanging(value);
                this._UnitsOnOrder = value;
                this.OnUnitsOnOrderChanged();
                this.OnPropertyChanged("UnitsOnOrder");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<short> _UnitsOnOrder;
        partial void OnUnitsOnOrderChanging(global::System.Nullable<short> value);
        partial void OnUnitsOnOrderChanged();
        /// <summary>
        /// There are no comments for Property ReorderLevel in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<short> ReorderLevel
        {
            get
            {
                return this._ReorderLevel;
            }
            set
            {
                this.OnReorderLevelChanging(value);
                this._ReorderLevel = value;
                this.OnReorderLevelChanged();
                this.OnPropertyChanged("ReorderLevel");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<short> _ReorderLevel;
        partial void OnReorderLevelChanging(global::System.Nullable<short> value);
        partial void OnReorderLevelChanged();
        /// <summary>
        /// There are no comments for Property Discontinued in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public bool Discontinued
        {
            get
            {
                return this._Discontinued;
            }
            set
            {
                this.OnDiscontinuedChanging(value);
                this._Discontinued = value;
                this.OnDiscontinuedChanged();
                this.OnPropertyChanged("Discontinued");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private bool _Discontinued;
        partial void OnDiscontinuedChanging(bool value);
        partial void OnDiscontinuedChanged();
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}