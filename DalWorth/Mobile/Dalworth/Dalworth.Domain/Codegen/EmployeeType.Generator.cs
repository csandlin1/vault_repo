
    using System;
    using System.Data;
    using System.Collections.Generic;
    using Dalworth.Data;
    using Dalworth.SDK;
    using System.Xml;
    using System.Xml.Serialization;
    using System.Text;
  
      namespace Dalworth.Domain
      {


      public partial class EmployeeType : DomainObject
      {

      #region Store


      #region Insert

      private const String SqlInsert = "Insert Into [EmployeeType] ( " +
      
        " ID, " +
      
        " Type, " +
      
        " Description " +
      
      ") Values (" +
      
        " @ID, " +
      
        " @Type, " +
      
        " @Description " +
      
      ")";

      public static void Insert(EmployeeType employeeType, IDbTransaction transaction)
      {
      using(IDbCommand dbCommand = Database.PrepareCommand(SqlInsert, transaction))
      {
      
        Database.PutParameter(dbCommand,"@ID", employeeType.ID);
      
        Database.PutParameter(dbCommand,"@Type", employeeType.Type);
      
        Database.PutParameter(dbCommand,"@Description", employeeType.Description);
      

      dbCommand.ExecuteNonQuery();
      }
      }

      public static void Insert(EmployeeType employeeType)
      {
        Insert(employeeType, null);
      }

      public static void Insert(List<EmployeeType>  employeeTypeList, IDbTransaction transaction)
      {
      using(IDbCommand dbCommand = Database.PrepareCommand(SqlInsert, transaction))
      {
      bool parametersAdded = false;

      foreach(EmployeeType employeeType in  employeeTypeList)
      {
      if(!parametersAdded)
      {
      
        Database.PutParameter(dbCommand,"@ID", employeeType.ID);
      
        Database.PutParameter(dbCommand,"@Type", employeeType.Type);
      
        Database.PutParameter(dbCommand,"@Description", employeeType.Description);
      
      parametersAdded = true;
      }
      else
      {

      
        Database.UpdateParameter(dbCommand,"@ID",employeeType.ID);
      
        Database.UpdateParameter(dbCommand,"@Type",employeeType.Type);
      
        Database.UpdateParameter(dbCommand,"@Description",employeeType.Description);
      
      }

      dbCommand.ExecuteNonQuery();
      }
      }
      }

      public static void Insert(List<EmployeeType>  employeeTypeList)
      {
      Insert(employeeTypeList, null);
      }

      #endregion

      #region Update


      private const String SqlUpdate = "Update [EmployeeType] Set "
      
        + " Type = @Type, "
      
        + " Description = @Description "
      
        + " Where "
        
          + " ID = @ID "
        
      ;

      public static void Update(EmployeeType employeeType, IDbTransaction transaction)
      {
      using(IDbCommand dbCommand = Database.PrepareCommand(SqlUpdate, transaction))
      {
      
        Database.PutParameter(dbCommand,"@ID", employeeType.ID);
      
        Database.PutParameter(dbCommand,"@Type", employeeType.Type);
      
        Database.PutParameter(dbCommand,"@Description", employeeType.Description);
      

      dbCommand.ExecuteNonQuery();
      }
      }

      public static void Update(EmployeeType employeeType)
      {
      Update(employeeType, null);
      }

      #endregion

      #region FindByPrimaryKey

      private const String SqlSelectByPk = "Select "

      
        + " ID, "
      
        + " Type, "
      
        + " Description "
      

      + " From [EmployeeType] "

      
        + " Where "
        
          + " ID = @ID "
        
      ;

      public static EmployeeType FindByPrimaryKey(
      int iD, IDbTransaction transaction
      )
      {
      using(IDbCommand dbCommand = Database.PrepareCommand(SqlSelectByPk, transaction))
      {
      
        Database.PutParameter(dbCommand,"@ID", iD);
      

      using(IDataReader dataReader = dbCommand.ExecuteReader())
      {
      if(dataReader.Read())
      return Load(dataReader);
      }
      }
      throw new DataNotFoundException("EmployeeType not found, search by primary key");

      }

      public static EmployeeType FindByPrimaryKey(
      int iD
      )
      {
      return FindByPrimaryKey(
      iD
      ,null);
      }

      #endregion

      #region Exists

      public static bool Exists(EmployeeType employeeType, IDbTransaction transaction)
      {

      using(IDbCommand dbCommand = Database.PrepareCommand(SqlSelectByPk, transaction))
      {
      
        Database.PutParameter(dbCommand,"@ID",employeeType.ID);
      

      using(IDataReader dataReader = dbCommand.ExecuteReader())
      {
      return dataReader.Read();
      }
      }
      }

      public static bool Exists(EmployeeType employeeType)
      {
      return Exists(employeeType, null);
      }
      #endregion

      #region IsContainsData

      public static bool IsContainsData(IDbTransaction transaction)
      {
      String sql = "select 1 from EmployeeType";

      using(IDbCommand dbCommand = Database.PrepareCommand(sql, transaction))
      {
      using (IDataReader reader = dbCommand.ExecuteReader(CommandBehavior.SingleRow))
      {
      return reader.Read();
      }
      }
      }

      public static bool IsContainsData()
      {
      return IsContainsData(null);
      }

      #endregion

      #region Load

      public static EmployeeType Load(IDataReader dataReader)
      {
      EmployeeType employeeType = new EmployeeType();

      employeeType.ID = dataReader.GetInt32(0);
          employeeType.Type = dataReader.GetString(1);
          
            if(!dataReader.IsDBNull(2))
            employeeType.Description = dataReader.GetString(2);
          

      return employeeType;
      }

      #endregion

      #region Delete
      private const String SqlDelete = "Delete From [EmployeeType] "

      
        + " Where "
        
          + " ID = @ID "
        
      ;
      public static void Delete(EmployeeType employeeType, IDbTransaction transaction)
      {

      using(IDbCommand dbCommand = Database.PrepareCommand(SqlDelete, transaction))
      {

      
        Database.PutParameter(dbCommand,"@ID", employeeType.ID);
      


      dbCommand.ExecuteNonQuery();
      }
      }

      public static void Delete(EmployeeType employeeType)
      {
      Delete(employeeType, null);
      }

      #endregion

      #region Clear

      private const String SqlDeleteAll = "Delete From [EmployeeType] ";

      public static void Clear(IDbTransaction transaction)
      {
      using(IDbCommand dbCommand = Database.PrepareCommand(SqlDeleteAll, transaction))
      {
      dbCommand.ExecuteNonQuery();
      }
      }

      public static void Clear()
      {
      Clear(null);
      }

      #endregion

      #region Find
      private const String SqlSelectAll = "Select "

      
        + " ID, "
      
        + " Type, "
      
        + " Description "
      

      + " From [EmployeeType] ";
      public static List<EmployeeType> Find(IDbTransaction transaction)
      {
      using(IDbCommand dbCommand = Database.PrepareCommand(SqlSelectAll, transaction))
      {
      List<EmployeeType> rv = new List<EmployeeType>();

      using(IDataReader dataReader = dbCommand.ExecuteReader())
      {
      while(dataReader.Read())
      {
      rv.Add(Load(dataReader));
      }

      }

      return rv;
      }

      }

      public static List<EmployeeType> Find()
      {
        return Find(null);
      }

      #endregion

      #region Import from file

      public static int Import(String xmlFilePath)
      {
      List<EmployeeType> itemsList = Load(xmlFilePath);

      if(itemsList.Count != 0)
      Insert(itemsList);

      return itemsList.Count;
      }

      #endregion

      #region Export to file
      public static int Export(String xmlFilePath)
      {

      List<EmployeeType> itemsList = Find();

      if (itemsList.Count == 0)
      return 0;


      XmlWriter xmlWriter = new XmlTextWriter(xmlFilePath, Encoding.UTF8);
      XmlSerializer xmlSerializer = new XmlSerializer(typeof(EmployeeType));

      xmlWriter.WriteStartDocument();
      xmlWriter.WriteStartElement("Root");

      foreach(EmployeeType item in itemsList)
      xmlSerializer.Serialize(xmlWriter, item);

      xmlWriter.WriteEndElement();
      xmlWriter.WriteEndDocument();

      xmlWriter.Flush();
      xmlWriter.Close();

      return itemsList.Count;


      }
      #endregion

      #region Load from file

      public static List<EmployeeType>
      Load(String xmlFilePath)
      {
      XmlSerializer xmlSerializer = new XmlSerializer(typeof(EmployeeType));
      XmlDocument xmlDocument = new XmlDocument();

      xmlDocument.Load(xmlFilePath);

      List<EmployeeType> itemsList
      = new List<EmployeeType>();

      foreach (XmlNode xmlNode in xmlDocument.DocumentElement.ChildNodes)
      {
      Object deserializedObject = xmlSerializer.Deserialize(
      new XmlNodeReader(xmlNode));

      if (deserializedObject is EmployeeType)
      itemsList.Add(deserializedObject as EmployeeType);
      }

      return itemsList;
      }

      #endregion

      #endregion


      #region Biz
      

      #region Fields
      
        protected int m_iD;
      
        protected String m_type;
      
        protected String m_description;
      
      #endregion

      #region Constructors
      public EmployeeType(
      int 
          iD
      )
      {
      
        m_iD = iD;
      
      }

      


        public EmployeeType(
        int 
          iD,String 
          type,String 
          description
        )
        {
        
          m_iD = iD;
        
          m_type = type;
        
          m_description = description;
        
        }


      
      #endregion

      
        [XmlElement]
        public int ID
        {
        get { return m_iD;}
        set { m_iD = value; }
        }
      
        [XmlElement]
        public String Type
        {
        get { return m_type;}
        set { m_type = value; }
        }
      
        [XmlElement]
        public String Description
        {
        get { return m_description;}
        set { m_description = value; }
        }
      
      }
      #endregion
      }

    