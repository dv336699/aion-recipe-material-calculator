﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3082
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Website
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
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="LogutovTestDb")]
	public partial class DbDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertItem(Item instance);
    partial void UpdateItem(Item instance);
    partial void DeleteItem(Item instance);
    partial void InsertRecipe(Recipe instance);
    partial void UpdateRecipe(Recipe instance);
    partial void DeleteRecipe(Recipe instance);
    partial void InsertRecipeItem(RecipeItem instance);
    partial void UpdateRecipeItem(RecipeItem instance);
    partial void DeleteRecipeItem(RecipeItem instance);
    #endregion
		
		public DbDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["Db"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DbDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DbDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Item> Items
		{
			get
			{
				return this.GetTable<Item>();
			}
		}
		
		public System.Data.Linq.Table<Recipe> Recipes
		{
			get
			{
				return this.GetTable<Recipe>();
			}
		}
		
		public System.Data.Linq.Table<RecipeItem> RecipeItems
		{
			get
			{
				return this.GetTable<RecipeItem>();
			}
		}
	}
	
	[Table(Name="Aion.Items")]
	public partial class Item : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Description;
		
		private byte _Level;
		
		private byte _Quality;
		
		private System.Xml.Linq.XElement _Data;
		
		private EntitySet<RecipeItem> _RecipeItems;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnLevelChanging(byte value);
    partial void OnLevelChanged();
    partial void OnQualityChanging(byte value);
    partial void OnQualityChanged();
    partial void OnDataChanging(System.Xml.Linq.XElement value);
    partial void OnDataChanged();
    #endregion
		
		public Item()
		{
			this._RecipeItems = new EntitySet<RecipeItem>(new Action<RecipeItem>(this.attach_RecipeItems), new Action<RecipeItem>(this.detach_RecipeItems));
			OnCreated();
		}
		
		[Column(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[Column(Storage="_Name", DbType="NVarChar(250) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_Description", DbType="NVarChar(250)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Name="[Level]", Storage="_Level", DbType="TinyInt NOT NULL")]
		public byte Level
		{
			get
			{
				return this._Level;
			}
			set
			{
				if ((this._Level != value))
				{
					this.OnLevelChanging(value);
					this.SendPropertyChanging();
					this._Level = value;
					this.SendPropertyChanged("Level");
					this.OnLevelChanged();
				}
			}
		}
		
		[Column(Storage="_Quality", DbType="TinyInt NOT NULL")]
		public byte Quality
		{
			get
			{
				return this._Quality;
			}
			set
			{
				if ((this._Quality != value))
				{
					this.OnQualityChanging(value);
					this.SendPropertyChanging();
					this._Quality = value;
					this.SendPropertyChanged("Quality");
					this.OnQualityChanged();
				}
			}
		}
		
		[Column(Storage="_Data", DbType="Xml NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Xml.Linq.XElement Data
		{
			get
			{
				return this._Data;
			}
			set
			{
				if ((this._Data != value))
				{
					this.OnDataChanging(value);
					this.SendPropertyChanging();
					this._Data = value;
					this.SendPropertyChanged("Data");
					this.OnDataChanged();
				}
			}
		}
		
		[Association(Name="Item_RecipeItem", Storage="_RecipeItems", ThisKey="Id", OtherKey="ItemId")]
		public EntitySet<RecipeItem> RecipeItems
		{
			get
			{
				return this._RecipeItems;
			}
			set
			{
				this._RecipeItems.Assign(value);
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
		
		private void attach_RecipeItems(RecipeItem entity)
		{
			this.SendPropertyChanging();
			entity.Item = this;
		}
		
		private void detach_RecipeItems(RecipeItem entity)
		{
			this.SendPropertyChanging();
			entity.Item = null;
		}
	}
	
	[Table(Name="Aion.Recipes")]
	public partial class Recipe : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Description;
		
		private byte _Skill;
		
		private byte _Race;
		
		private short _SkillLevel;
		
		private EntitySet<RecipeItem> _RecipeItems;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnSkillChanging(byte value);
    partial void OnSkillChanged();
    partial void OnRaceChanging(byte value);
    partial void OnRaceChanged();
    partial void OnSkillLevelChanging(short value);
    partial void OnSkillLevelChanged();
    #endregion
		
		public Recipe()
		{
			this._RecipeItems = new EntitySet<RecipeItem>(new Action<RecipeItem>(this.attach_RecipeItems), new Action<RecipeItem>(this.detach_RecipeItems));
			OnCreated();
		}
		
		[Column(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[Column(Storage="_Name", DbType="NVarChar(250) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_Description", DbType="NVarChar(250)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_Skill", DbType="TinyInt NOT NULL")]
		public byte Skill
		{
			get
			{
				return this._Skill;
			}
			set
			{
				if ((this._Skill != value))
				{
					this.OnSkillChanging(value);
					this.SendPropertyChanging();
					this._Skill = value;
					this.SendPropertyChanged("Skill");
					this.OnSkillChanged();
				}
			}
		}
		
		[Column(Storage="_Race", DbType="TinyInt NOT NULL")]
		public byte Race
		{
			get
			{
				return this._Race;
			}
			set
			{
				if ((this._Race != value))
				{
					this.OnRaceChanging(value);
					this.SendPropertyChanging();
					this._Race = value;
					this.SendPropertyChanged("Race");
					this.OnRaceChanged();
				}
			}
		}
		
		[Column(Storage="_SkillLevel", DbType="SmallInt NOT NULL")]
		public short SkillLevel
		{
			get
			{
				return this._SkillLevel;
			}
			set
			{
				if ((this._SkillLevel != value))
				{
					this.OnSkillLevelChanging(value);
					this.SendPropertyChanging();
					this._SkillLevel = value;
					this.SendPropertyChanged("SkillLevel");
					this.OnSkillLevelChanged();
				}
			}
		}
		
		[Association(Name="Recipe_RecipeItem", Storage="_RecipeItems", ThisKey="Id", OtherKey="RecipeId")]
		public EntitySet<RecipeItem> RecipeItems
		{
			get
			{
				return this._RecipeItems;
			}
			set
			{
				this._RecipeItems.Assign(value);
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
		
		private void attach_RecipeItems(RecipeItem entity)
		{
			this.SendPropertyChanging();
			entity.Recipe = this;
		}
		
		private void detach_RecipeItems(RecipeItem entity)
		{
			this.SendPropertyChanging();
			entity.Recipe = null;
		}
	}
	
	[Table(Name="Aion.RecipeItems")]
	public partial class RecipeItem : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _RecipeId;
		
		private byte _Type;
		
		private int _ItemId;
		
		private short _Quantity;
		
		private byte _OrderNum;
		
		private EntityRef<Item> _Item;
		
		private EntityRef<Recipe> _Recipe;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnRecipeIdChanging(int value);
    partial void OnRecipeIdChanged();
    partial void OnTypeChanging(byte value);
    partial void OnTypeChanged();
    partial void OnItemIdChanging(int value);
    partial void OnItemIdChanged();
    partial void OnQuantityChanging(short value);
    partial void OnQuantityChanged();
    partial void OnOrderNumChanging(byte value);
    partial void OnOrderNumChanged();
    #endregion
		
		public RecipeItem()
		{
			this._Item = default(EntityRef<Item>);
			this._Recipe = default(EntityRef<Recipe>);
			OnCreated();
		}
		
		[Column(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[Column(Storage="_RecipeId", DbType="Int NOT NULL")]
		public int RecipeId
		{
			get
			{
				return this._RecipeId;
			}
			set
			{
				if ((this._RecipeId != value))
				{
					if (this._Recipe.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRecipeIdChanging(value);
					this.SendPropertyChanging();
					this._RecipeId = value;
					this.SendPropertyChanged("RecipeId");
					this.OnRecipeIdChanged();
				}
			}
		}
		
		[Column(Storage="_Type", DbType="TinyInt NOT NULL")]
		public byte Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					this.OnTypeChanging(value);
					this.SendPropertyChanging();
					this._Type = value;
					this.SendPropertyChanged("Type");
					this.OnTypeChanged();
				}
			}
		}
		
		[Column(Storage="_ItemId", DbType="Int NOT NULL")]
		public int ItemId
		{
			get
			{
				return this._ItemId;
			}
			set
			{
				if ((this._ItemId != value))
				{
					if (this._Item.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnItemIdChanging(value);
					this.SendPropertyChanging();
					this._ItemId = value;
					this.SendPropertyChanged("ItemId");
					this.OnItemIdChanged();
				}
			}
		}
		
		[Column(Storage="_Quantity", DbType="SmallInt NOT NULL")]
		public short Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		[Column(Storage="_OrderNum", DbType="TinyInt NOT NULL")]
		public byte OrderNum
		{
			get
			{
				return this._OrderNum;
			}
			set
			{
				if ((this._OrderNum != value))
				{
					this.OnOrderNumChanging(value);
					this.SendPropertyChanging();
					this._OrderNum = value;
					this.SendPropertyChanged("OrderNum");
					this.OnOrderNumChanged();
				}
			}
		}
		
		[Association(Name="Item_RecipeItem", Storage="_Item", ThisKey="ItemId", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Item Item
		{
			get
			{
				return this._Item.Entity;
			}
			set
			{
				Item previousValue = this._Item.Entity;
				if (((previousValue != value) 
							|| (this._Item.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Item.Entity = null;
						previousValue.RecipeItems.Remove(this);
					}
					this._Item.Entity = value;
					if ((value != null))
					{
						value.RecipeItems.Add(this);
						this._ItemId = value.Id;
					}
					else
					{
						this._ItemId = default(int);
					}
					this.SendPropertyChanged("Item");
				}
			}
		}
		
		[Association(Name="Recipe_RecipeItem", Storage="_Recipe", ThisKey="RecipeId", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Recipe Recipe
		{
			get
			{
				return this._Recipe.Entity;
			}
			set
			{
				Recipe previousValue = this._Recipe.Entity;
				if (((previousValue != value) 
							|| (this._Recipe.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Recipe.Entity = null;
						previousValue.RecipeItems.Remove(this);
					}
					this._Recipe.Entity = value;
					if ((value != null))
					{
						value.RecipeItems.Add(this);
						this._RecipeId = value.Id;
					}
					else
					{
						this._RecipeId = default(int);
					}
					this.SendPropertyChanged("Recipe");
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
}
#pragma warning restore 1591
