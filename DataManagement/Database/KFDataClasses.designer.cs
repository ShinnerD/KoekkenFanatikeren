﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataManagement.Database
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="generalDB")]
	public partial class KFDataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    partial void InsertEmployee(Employee instance);
    partial void UpdateEmployee(Employee instance);
    partial void DeleteEmployee(Employee instance);
    partial void InsertOrder(Order instance);
    partial void UpdateOrder(Order instance);
    partial void DeleteOrder(Order instance);
    partial void InsertOrder_Product(Order_Product instance);
    partial void UpdateOrder_Product(Order_Product instance);
    partial void DeleteOrder_Product(Order_Product instance);
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    partial void InsertProductGroup(ProductGroup instance);
    partial void UpdateProductGroup(ProductGroup instance);
    partial void DeleteProductGroup(ProductGroup instance);
    #endregion
		
		public KFDataClassesDataContext() : 
				base(global::DataManagement.Properties.Settings.Default.generalDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public KFDataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KFDataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KFDataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KFDataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Customer> Customers
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
		
		public System.Data.Linq.Table<Employee> Employees
		{
			get
			{
				return this.GetTable<Employee>();
			}
		}
		
		public System.Data.Linq.Table<Order> Orders
		{
			get
			{
				return this.GetTable<Order>();
			}
		}
		
		public System.Data.Linq.Table<Order_Product> Order_Products
		{
			get
			{
				return this.GetTable<Order_Product>();
			}
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
		
		public System.Data.Linq.Table<ProductGroup> ProductGroups
		{
			get
			{
				return this.GetTable<ProductGroup>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Customer_Id;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _Streetname;
		
		private string _City;
		
		private int _Zipcode;
		
		private int _Phonenumber;
		
		private string _Email;
		
		private EntitySet<Order> _Orders;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustomer_IdChanging(int value);
    partial void OnCustomer_IdChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnStreetnameChanging(string value);
    partial void OnStreetnameChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnZipcodeChanging(int value);
    partial void OnZipcodeChanged();
    partial void OnPhonenumberChanging(int value);
    partial void OnPhonenumberChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    #endregion
		
		public Customer()
		{
			this._Orders = new EntitySet<Order>(new Action<Order>(this.attach_Orders), new Action<Order>(this.detach_Orders));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Customer_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Customer_Id
		{
			get
			{
				return this._Customer_Id;
			}
			set
			{
				if ((this._Customer_Id != value))
				{
					this.OnCustomer_IdChanging(value);
					this.SendPropertyChanging();
					this._Customer_Id = value;
					this.SendPropertyChanged("Customer_Id");
					this.OnCustomer_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Streetname", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Streetname
		{
			get
			{
				return this._Streetname;
			}
			set
			{
				if ((this._Streetname != value))
				{
					this.OnStreetnameChanging(value);
					this.SendPropertyChanging();
					this._Streetname = value;
					this.SendPropertyChanged("Streetname");
					this.OnStreetnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Zipcode", DbType="Int NOT NULL")]
		public int Zipcode
		{
			get
			{
				return this._Zipcode;
			}
			set
			{
				if ((this._Zipcode != value))
				{
					this.OnZipcodeChanging(value);
					this.SendPropertyChanging();
					this._Zipcode = value;
					this.SendPropertyChanged("Zipcode");
					this.OnZipcodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phonenumber", DbType="Int NOT NULL")]
		public int Phonenumber
		{
			get
			{
				return this._Phonenumber;
			}
			set
			{
				if ((this._Phonenumber != value))
				{
					this.OnPhonenumberChanging(value);
					this.SendPropertyChanging();
					this._Phonenumber = value;
					this.SendPropertyChanged("Phonenumber");
					this.OnPhonenumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Order", Storage="_Orders", ThisKey="Customer_Id", OtherKey="Customer_Id")]
		public EntitySet<Order> Orders
		{
			get
			{
				return this._Orders;
			}
			set
			{
				this._Orders.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Orders(Order entity)
		{
			this.SendPropertyChanging();
			entity.Customer = this;
		}
		
		private void detach_Orders(Order entity)
		{
			this.SendPropertyChanging();
			entity.Customer = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employee")]
	public partial class Employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Employee_Id;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _Address;
		
		private int _Phonenumber;
		
		private int _Salary;
		
		private EntitySet<Order> _Orders;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmployee_IdChanging(int value);
    partial void OnEmployee_IdChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnPhonenumberChanging(int value);
    partial void OnPhonenumberChanged();
    partial void OnSalaryChanging(int value);
    partial void OnSalaryChanged();
    #endregion
		
		public Employee()
		{
			this._Orders = new EntitySet<Order>(new Action<Order>(this.attach_Orders), new Action<Order>(this.detach_Orders));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Employee_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Employee_Id
		{
			get
			{
				return this._Employee_Id;
			}
			set
			{
				if ((this._Employee_Id != value))
				{
					this.OnEmployee_IdChanging(value);
					this.SendPropertyChanging();
					this._Employee_Id = value;
					this.SendPropertyChanged("Employee_Id");
					this.OnEmployee_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phonenumber", DbType="Int NOT NULL")]
		public int Phonenumber
		{
			get
			{
				return this._Phonenumber;
			}
			set
			{
				if ((this._Phonenumber != value))
				{
					this.OnPhonenumberChanging(value);
					this.SendPropertyChanging();
					this._Phonenumber = value;
					this.SendPropertyChanged("Phonenumber");
					this.OnPhonenumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="Int NOT NULL")]
		public int Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				if ((this._Salary != value))
				{
					this.OnSalaryChanging(value);
					this.SendPropertyChanging();
					this._Salary = value;
					this.SendPropertyChanged("Salary");
					this.OnSalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Employee_Order", Storage="_Orders", ThisKey="Employee_Id", OtherKey="Employee_Id")]
		public EntitySet<Order> Orders
		{
			get
			{
				return this._Orders;
			}
			set
			{
				this._Orders.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Orders(Order entity)
		{
			this.SendPropertyChanging();
			entity.Employee = this;
		}
		
		private void detach_Orders(Order entity)
		{
			this.SendPropertyChanging();
			entity.Employee = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Order]")]
	public partial class Order : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Order_Id;
		
		private int _Customer_Id;
		
		private int _Employee_Id;
		
		private string _To_Firstname;
		
		private string _To_Lastname;
		
		private int _To_Phonenumber;
		
		private string _To_Street;
		
		private string _To_City;
		
		private int _To_Zipcode;
		
		private System.DateTime _DateOfSending;
		
		private EntitySet<Order_Product> _Order_Products;
		
		private EntityRef<Customer> _Customer;
		
		private EntityRef<Employee> _Employee;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrder_IdChanging(int value);
    partial void OnOrder_IdChanged();
    partial void OnCustomer_IdChanging(int value);
    partial void OnCustomer_IdChanged();
    partial void OnEmployee_IdChanging(int value);
    partial void OnEmployee_IdChanged();
    partial void OnTo_FirstnameChanging(string value);
    partial void OnTo_FirstnameChanged();
    partial void OnTo_LastnameChanging(string value);
    partial void OnTo_LastnameChanged();
    partial void OnTo_PhonenumberChanging(int value);
    partial void OnTo_PhonenumberChanged();
    partial void OnTo_StreetChanging(string value);
    partial void OnTo_StreetChanged();
    partial void OnTo_CityChanging(string value);
    partial void OnTo_CityChanged();
    partial void OnTo_ZipcodeChanging(int value);
    partial void OnTo_ZipcodeChanged();
    partial void OnDateOfSendingChanging(System.DateTime value);
    partial void OnDateOfSendingChanged();
    #endregion
		
		public Order()
		{
			this._Order_Products = new EntitySet<Order_Product>(new Action<Order_Product>(this.attach_Order_Products), new Action<Order_Product>(this.detach_Order_Products));
			this._Customer = default(EntityRef<Customer>);
			this._Employee = default(EntityRef<Employee>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Order_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Order_Id
		{
			get
			{
				return this._Order_Id;
			}
			set
			{
				if ((this._Order_Id != value))
				{
					this.OnOrder_IdChanging(value);
					this.SendPropertyChanging();
					this._Order_Id = value;
					this.SendPropertyChanged("Order_Id");
					this.OnOrder_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Customer_Id", DbType="Int NOT NULL")]
		public int Customer_Id
		{
			get
			{
				return this._Customer_Id;
			}
			set
			{
				if ((this._Customer_Id != value))
				{
					if (this._Customer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCustomer_IdChanging(value);
					this.SendPropertyChanging();
					this._Customer_Id = value;
					this.SendPropertyChanged("Customer_Id");
					this.OnCustomer_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Employee_Id", DbType="Int NOT NULL")]
		public int Employee_Id
		{
			get
			{
				return this._Employee_Id;
			}
			set
			{
				if ((this._Employee_Id != value))
				{
					if (this._Employee.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEmployee_IdChanging(value);
					this.SendPropertyChanging();
					this._Employee_Id = value;
					this.SendPropertyChanged("Employee_Id");
					this.OnEmployee_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_To_Firstname", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string To_Firstname
		{
			get
			{
				return this._To_Firstname;
			}
			set
			{
				if ((this._To_Firstname != value))
				{
					this.OnTo_FirstnameChanging(value);
					this.SendPropertyChanging();
					this._To_Firstname = value;
					this.SendPropertyChanged("To_Firstname");
					this.OnTo_FirstnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_To_Lastname", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string To_Lastname
		{
			get
			{
				return this._To_Lastname;
			}
			set
			{
				if ((this._To_Lastname != value))
				{
					this.OnTo_LastnameChanging(value);
					this.SendPropertyChanging();
					this._To_Lastname = value;
					this.SendPropertyChanged("To_Lastname");
					this.OnTo_LastnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_To_Phonenumber", DbType="Int NOT NULL")]
		public int To_Phonenumber
		{
			get
			{
				return this._To_Phonenumber;
			}
			set
			{
				if ((this._To_Phonenumber != value))
				{
					this.OnTo_PhonenumberChanging(value);
					this.SendPropertyChanging();
					this._To_Phonenumber = value;
					this.SendPropertyChanged("To_Phonenumber");
					this.OnTo_PhonenumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_To_Street", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string To_Street
		{
			get
			{
				return this._To_Street;
			}
			set
			{
				if ((this._To_Street != value))
				{
					this.OnTo_StreetChanging(value);
					this.SendPropertyChanging();
					this._To_Street = value;
					this.SendPropertyChanged("To_Street");
					this.OnTo_StreetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_To_City", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string To_City
		{
			get
			{
				return this._To_City;
			}
			set
			{
				if ((this._To_City != value))
				{
					this.OnTo_CityChanging(value);
					this.SendPropertyChanging();
					this._To_City = value;
					this.SendPropertyChanged("To_City");
					this.OnTo_CityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_To_Zipcode", DbType="Int NOT NULL")]
		public int To_Zipcode
		{
			get
			{
				return this._To_Zipcode;
			}
			set
			{
				if ((this._To_Zipcode != value))
				{
					this.OnTo_ZipcodeChanging(value);
					this.SendPropertyChanging();
					this._To_Zipcode = value;
					this.SendPropertyChanged("To_Zipcode");
					this.OnTo_ZipcodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateOfSending", DbType="DateTime NOT NULL")]
		public System.DateTime DateOfSending
		{
			get
			{
				return this._DateOfSending;
			}
			set
			{
				if ((this._DateOfSending != value))
				{
					this.OnDateOfSendingChanging(value);
					this.SendPropertyChanging();
					this._DateOfSending = value;
					this.SendPropertyChanged("DateOfSending");
					this.OnDateOfSendingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_Order_Product", Storage="_Order_Products", ThisKey="Order_Id", OtherKey="Order_Id")]
		public EntitySet<Order_Product> Order_Products
		{
			get
			{
				return this._Order_Products;
			}
			set
			{
				this._Order_Products.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Order", Storage="_Customer", ThisKey="Customer_Id", OtherKey="Customer_Id", IsForeignKey=true)]
		public Customer Customer
		{
			get
			{
				return this._Customer.Entity;
			}
			set
			{
				Customer previousValue = this._Customer.Entity;
				if (((previousValue != value) 
							|| (this._Customer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Customer.Entity = null;
						previousValue.Orders.Remove(this);
					}
					this._Customer.Entity = value;
					if ((value != null))
					{
						value.Orders.Add(this);
						this._Customer_Id = value.Customer_Id;
					}
					else
					{
						this._Customer_Id = default(int);
					}
					this.SendPropertyChanged("Customer");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Employee_Order", Storage="_Employee", ThisKey="Employee_Id", OtherKey="Employee_Id", IsForeignKey=true)]
		public Employee Employee
		{
			get
			{
				return this._Employee.Entity;
			}
			set
			{
				Employee previousValue = this._Employee.Entity;
				if (((previousValue != value) 
							|| (this._Employee.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Employee.Entity = null;
						previousValue.Orders.Remove(this);
					}
					this._Employee.Entity = value;
					if ((value != null))
					{
						value.Orders.Add(this);
						this._Employee_Id = value.Employee_Id;
					}
					else
					{
						this._Employee_Id = default(int);
					}
					this.SendPropertyChanged("Employee");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Order_Products(Order_Product entity)
		{
			this.SendPropertyChanging();
			entity.Order = this;
		}
		
		private void detach_Order_Products(Order_Product entity)
		{
			this.SendPropertyChanging();
			entity.Order = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Order_Product")]
	public partial class Order_Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Junction_Id;
		
		private int _Order_Id;
		
		private int _Product_Id;
		
		private int _Product_Count;
		
		private EntityRef<Order> _Order;
		
		private EntityRef<Product> _Product;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnJunction_IdChanging(int value);
    partial void OnJunction_IdChanged();
    partial void OnOrder_IdChanging(int value);
    partial void OnOrder_IdChanged();
    partial void OnProduct_IdChanging(int value);
    partial void OnProduct_IdChanged();
    partial void OnProduct_CountChanging(int value);
    partial void OnProduct_CountChanged();
    #endregion
		
		public Order_Product()
		{
			this._Order = default(EntityRef<Order>);
			this._Product = default(EntityRef<Product>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Junction_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Junction_Id
		{
			get
			{
				return this._Junction_Id;
			}
			set
			{
				if ((this._Junction_Id != value))
				{
					this.OnJunction_IdChanging(value);
					this.SendPropertyChanging();
					this._Junction_Id = value;
					this.SendPropertyChanged("Junction_Id");
					this.OnJunction_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Order_Id", DbType="Int NOT NULL")]
		public int Order_Id
		{
			get
			{
				return this._Order_Id;
			}
			set
			{
				if ((this._Order_Id != value))
				{
					if (this._Order.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnOrder_IdChanging(value);
					this.SendPropertyChanging();
					this._Order_Id = value;
					this.SendPropertyChanged("Order_Id");
					this.OnOrder_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_Id", DbType="Int NOT NULL")]
		public int Product_Id
		{
			get
			{
				return this._Product_Id;
			}
			set
			{
				if ((this._Product_Id != value))
				{
					if (this._Product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProduct_IdChanging(value);
					this.SendPropertyChanging();
					this._Product_Id = value;
					this.SendPropertyChanged("Product_Id");
					this.OnProduct_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_Count", DbType="Int NOT NULL")]
		public int Product_Count
		{
			get
			{
				return this._Product_Count;
			}
			set
			{
				if ((this._Product_Count != value))
				{
					this.OnProduct_CountChanging(value);
					this.SendPropertyChanging();
					this._Product_Count = value;
					this.SendPropertyChanged("Product_Count");
					this.OnProduct_CountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_Order_Product", Storage="_Order", ThisKey="Order_Id", OtherKey="Order_Id", IsForeignKey=true)]
		public Order Order
		{
			get
			{
				return this._Order.Entity;
			}
			set
			{
				Order previousValue = this._Order.Entity;
				if (((previousValue != value) 
							|| (this._Order.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Order.Entity = null;
						previousValue.Order_Products.Remove(this);
					}
					this._Order.Entity = value;
					if ((value != null))
					{
						value.Order_Products.Add(this);
						this._Order_Id = value.Order_Id;
					}
					else
					{
						this._Order_Id = default(int);
					}
					this.SendPropertyChanged("Order");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Order_Product", Storage="_Product", ThisKey="Product_Id", OtherKey="Product_Id", IsForeignKey=true)]
		public Product Product
		{
			get
			{
				return this._Product.Entity;
			}
			set
			{
				Product previousValue = this._Product.Entity;
				if (((previousValue != value) 
							|| (this._Product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Product.Entity = null;
						previousValue.Order_Products.Remove(this);
					}
					this._Product.Entity = value;
					if ((value != null))
					{
						value.Order_Products.Add(this);
						this._Product_Id = value.Product_Id;
					}
					else
					{
						this._Product_Id = default(int);
					}
					this.SendPropertyChanged("Product");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Product")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Product_Id;
		
		private int _ProductGroup_Id;
		
		private string _ProductName;
		
		private int _Price;
		
		private string _Material;
		
		private string _Colour;
		
		private string _Grip;
		
		private EntitySet<Order_Product> _Order_Products;
		
		private EntityRef<ProductGroup> _ProductGroup;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProduct_IdChanging(int value);
    partial void OnProduct_IdChanged();
    partial void OnProductGroup_IdChanging(int value);
    partial void OnProductGroup_IdChanged();
    partial void OnProductNameChanging(string value);
    partial void OnProductNameChanged();
    partial void OnPriceChanging(int value);
    partial void OnPriceChanged();
    partial void OnMaterialChanging(string value);
    partial void OnMaterialChanged();
    partial void OnColourChanging(string value);
    partial void OnColourChanged();
    partial void OnGripChanging(string value);
    partial void OnGripChanged();
    #endregion
		
		public Product()
		{
			this._Order_Products = new EntitySet<Order_Product>(new Action<Order_Product>(this.attach_Order_Products), new Action<Order_Product>(this.detach_Order_Products));
			this._ProductGroup = default(EntityRef<ProductGroup>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Product_Id
		{
			get
			{
				return this._Product_Id;
			}
			set
			{
				if ((this._Product_Id != value))
				{
					this.OnProduct_IdChanging(value);
					this.SendPropertyChanging();
					this._Product_Id = value;
					this.SendPropertyChanged("Product_Id");
					this.OnProduct_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductGroup_Id", DbType="Int NOT NULL")]
		public int ProductGroup_Id
		{
			get
			{
				return this._ProductGroup_Id;
			}
			set
			{
				if ((this._ProductGroup_Id != value))
				{
					if (this._ProductGroup.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProductGroup_IdChanging(value);
					this.SendPropertyChanging();
					this._ProductGroup_Id = value;
					this.SendPropertyChanged("ProductGroup_Id");
					this.OnProductGroup_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductName", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string ProductName
		{
			get
			{
				return this._ProductName;
			}
			set
			{
				if ((this._ProductName != value))
				{
					this.OnProductNameChanging(value);
					this.SendPropertyChanging();
					this._ProductName = value;
					this.SendPropertyChanged("ProductName");
					this.OnProductNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Int NOT NULL")]
		public int Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Material", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Material
		{
			get
			{
				return this._Material;
			}
			set
			{
				if ((this._Material != value))
				{
					this.OnMaterialChanging(value);
					this.SendPropertyChanging();
					this._Material = value;
					this.SendPropertyChanged("Material");
					this.OnMaterialChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Colour", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Colour
		{
			get
			{
				return this._Colour;
			}
			set
			{
				if ((this._Colour != value))
				{
					this.OnColourChanging(value);
					this.SendPropertyChanging();
					this._Colour = value;
					this.SendPropertyChanged("Colour");
					this.OnColourChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Grip", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Grip
		{
			get
			{
				return this._Grip;
			}
			set
			{
				if ((this._Grip != value))
				{
					this.OnGripChanging(value);
					this.SendPropertyChanging();
					this._Grip = value;
					this.SendPropertyChanged("Grip");
					this.OnGripChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Order_Product", Storage="_Order_Products", ThisKey="Product_Id", OtherKey="Product_Id")]
		public EntitySet<Order_Product> Order_Products
		{
			get
			{
				return this._Order_Products;
			}
			set
			{
				this._Order_Products.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ProductGroup_Product", Storage="_ProductGroup", ThisKey="ProductGroup_Id", OtherKey="ProductGroup_Id", IsForeignKey=true)]
		public ProductGroup ProductGroup
		{
			get
			{
				return this._ProductGroup.Entity;
			}
			set
			{
				ProductGroup previousValue = this._ProductGroup.Entity;
				if (((previousValue != value) 
							|| (this._ProductGroup.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ProductGroup.Entity = null;
						previousValue.Products.Remove(this);
					}
					this._ProductGroup.Entity = value;
					if ((value != null))
					{
						value.Products.Add(this);
						this._ProductGroup_Id = value.ProductGroup_Id;
					}
					else
					{
						this._ProductGroup_Id = default(int);
					}
					this.SendPropertyChanged("ProductGroup");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Order_Products(Order_Product entity)
		{
			this.SendPropertyChanging();
			entity.Product = this;
		}
		
		private void detach_Order_Products(Order_Product entity)
		{
			this.SendPropertyChanging();
			entity.Product = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ProductGroup")]
	public partial class ProductGroup : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProductGroup_Id;
		
		private string _ProductGroupName;
		
		private EntitySet<Product> _Products;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProductGroup_IdChanging(int value);
    partial void OnProductGroup_IdChanged();
    partial void OnProductGroupNameChanging(string value);
    partial void OnProductGroupNameChanged();
    #endregion
		
		public ProductGroup()
		{
			this._Products = new EntitySet<Product>(new Action<Product>(this.attach_Products), new Action<Product>(this.detach_Products));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductGroup_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ProductGroup_Id
		{
			get
			{
				return this._ProductGroup_Id;
			}
			set
			{
				if ((this._ProductGroup_Id != value))
				{
					this.OnProductGroup_IdChanging(value);
					this.SendPropertyChanging();
					this._ProductGroup_Id = value;
					this.SendPropertyChanged("ProductGroup_Id");
					this.OnProductGroup_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductGroupName", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
		public string ProductGroupName
		{
			get
			{
				return this._ProductGroupName;
			}
			set
			{
				if ((this._ProductGroupName != value))
				{
					this.OnProductGroupNameChanging(value);
					this.SendPropertyChanging();
					this._ProductGroupName = value;
					this.SendPropertyChanged("ProductGroupName");
					this.OnProductGroupNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ProductGroup_Product", Storage="_Products", ThisKey="ProductGroup_Id", OtherKey="ProductGroup_Id")]
		public EntitySet<Product> Products
		{
			get
			{
				return this._Products;
			}
			set
			{
				this._Products.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Products(Product entity)
		{
			this.SendPropertyChanging();
			entity.ProductGroup = this;
		}
		
		private void detach_Products(Product entity)
		{
			this.SendPropertyChanging();
			entity.ProductGroup = null;
		}
	}
}
#pragma warning restore 1591
