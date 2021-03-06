
    using System;
    using System.Data;
    using System.Collections.Generic;
    using Dalworth.Server.Data;
    using Dalworth.Server.SDK;
    using System.Xml;
    using System.Xml.Serialization;
    using System.Text;
  
      namespace Dalworth.Server.Domain
      {


      public partial class ProjectTypeQbItem : DomainObject, ICloneable
      {

      #region Store


      #region Insert

      private const String SqlInsert = "Insert Into ProjectTypeQbItem ( " +
      
        " ProjectTypeId, " +
      
        " QbItemListId " +
      
      ") Values (" +
      
        " ?ProjectTypeId, " +
      
        " ?QbItemListId " +
      
      ")";

      public static void Insert(ProjectTypeQbItem projectTypeQbItem, IDbConnection connection)
      {
      using(IDbCommand dbCommand = Database.PrepareCommand(SqlInsert, connection))
      {
      
        Database.PutParameter(dbCommand,"?ProjectTypeId", projectTypeQbItem.ProjectTypeId);
      
        Database.PutParameter(dbCommand,"?QbItemListId", projectTypeQbItem.QbItemListId);
      

      dbCommand.ExecuteNonQuery();

      

      }
      }

      public static void Insert(ProjectTypeQbItem projectTypeQbItem)
      {
        Insert(projectTypeQbItem, null);
      }


      public static void Insert(List<ProjectTypeQbItem>  projectTypeQbItemList, IDbConnection connection)
      {
      using(IDbCommand dbCommand = Database.PrepareCommand(SqlInsert, connection))
      {
      bool parametersAdded = false;

      foreach(ProjectTypeQbItem projectTypeQbItem in  projectTypeQbItemList)
      {
      if(!parametersAdded)
      {
      
        Database.PutParameter(dbCommand,"?ProjectTypeId", projectTypeQbItem.ProjectTypeId);
      
        Database.PutParameter(dbCommand,"?QbItemListId", projectTypeQbItem.QbItemListId);
      
      parametersAdded = true;
      }
      else
      {

      
        Database.UpdateParameter(dbCommand,"?ProjectTypeId",projectTypeQbItem.ProjectTypeId);
      
        Database.UpdateParameter(dbCommand,"?QbItemListId",projectTypeQbItem.QbItemListId);
      
      }

      dbCommand.ExecuteNonQuery();

      

      }
      }
      }

      public static void Insert(List<ProjectTypeQbItem>  projectTypeQbItemList)
      {
        Insert(projectTypeQbItemList, null);
    }

    #endregion

    #region Update


    private const String SqlUpdate = "Update ProjectTypeQbItem Set "
      
        + " Where "
        
          + " ProjectTypeId = ?ProjectTypeId and  "
        
          + " QbItemListId = ?QbItemListId "
        
      ;

      public static void Update(ProjectTypeQbItem projectTypeQbItem, IDbConnection connection)
      {
      using(IDbCommand dbCommand = Database.PrepareCommand(SqlUpdate, connection))
      {
      
        Database.PutParameter(dbCommand,"?ProjectTypeId", projectTypeQbItem.ProjectTypeId);
      
        Database.PutParameter(dbCommand,"?QbItemListId", projectTypeQbItem.QbItemListId);
      

      dbCommand.ExecuteNonQuery();
      }
      }

      public static void Update(ProjectTypeQbItem projectTypeQbItem)
      {
        Update(projectTypeQbItem, null);
      }

      #endregion

      #region FindByPrimaryKey

      private const String SqlSelectByPk = "Select "

      
        + " ProjectTypeId, "
      
        + " QbItemListId "
      

      + " From ProjectTypeQbItem "

      
        + " Where "
        
          + " ProjectTypeId = ?ProjectTypeId and  "
        
          + " QbItemListId = ?QbItemListId "
        
      ;

      public static ProjectTypeQbItem FindByPrimaryKey(
      int projectTypeId,String qbItemListId, IDbConnection connection
      )
      {
      using(IDbCommand dbCommand = Database.PrepareCommand(SqlSelectByPk, connection))
      {
      
        Database.PutParameter(dbCommand,"?ProjectTypeId", projectTypeId);
      
        Database.PutParameter(dbCommand,"?QbItemListId", qbItemListId);
      

      using(IDataReader dataReader = dbCommand.ExecuteReader())
      {
      if(dataReader.Read())
      return Load(dataReader);
      }
      }
      throw new DataNotFoundException("ProjectTypeQbItem not found, search by primary key");

      }

      public static ProjectTypeQbItem FindByPrimaryKey(
      int projectTypeId,String qbItemListId
      )
      {
      return FindByPrimaryKey(
      projectTypeId,qbItemListId, null
      );
      }


      #endregion

      #region Exists

      public static bool Exists(ProjectTypeQbItem projectTypeQbItem, IDbConnection connection)
      {

      using(IDbCommand dbCommand = Database.PrepareCommand(SqlSelectByPk, connection))
      {
      
        Database.PutParameter(dbCommand,"?ProjectTypeId",projectTypeQbItem.ProjectTypeId);
      
        Database.PutParameter(dbCommand,"?QbItemListId",projectTypeQbItem.QbItemListId);
      

      using(IDataReader dataReader = dbCommand.ExecuteReader())
      {
      return dataReader.Read();
      }
      }
      }

      public static bool Exists(ProjectTypeQbItem projectTypeQbItem)
      {
      return Exists(projectTypeQbItem, null);
      }

      #endregion

      #region IsContainsData

      public static bool IsContainsData(IDbConnection connection)
      {
      String sql = "select * from ProjectTypeQbItem limit 1";

      using(IDbCommand dbCommand = Database.PrepareCommand(sql, connection))
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

      public static ProjectTypeQbItem Load(IDataReader dataReader, int offset)
      {
      ProjectTypeQbItem projectTypeQbItem = new ProjectTypeQbItem();

      projectTypeQbItem.ProjectTypeId = dataReader.GetInt32(0 + offset);
          projectTypeQbItem.QbItemListId = dataReader.GetString(1 + offset);
          

      return projectTypeQbItem;
      }

      public static ProjectTypeQbItem Load(IDataReader dataReader)
      {
      return Load(dataReader, 0);
      }


      #endregion

      #region Delete
      private const String SqlDelete = "Delete From ProjectTypeQbItem "

      
        + " Where "
        
          + " ProjectTypeId = ?ProjectTypeId and  "
        
          + " QbItemListId = ?QbItemListId "
        
      ;
      public static void Delete(ProjectTypeQbItem projectTypeQbItem, IDbConnection connection)
      {

      using(IDbCommand dbCommand = Database.PrepareCommand(SqlDelete, connection))
      {

      
        Database.PutParameter(dbCommand,"?ProjectTypeId", projectTypeQbItem.ProjectTypeId);
      
        Database.PutParameter(dbCommand,"?QbItemListId", projectTypeQbItem.QbItemListId);
      


      dbCommand.ExecuteNonQuery();
      }
      }

      public static void Delete(ProjectTypeQbItem projectTypeQbItem)
      {
        Delete(projectTypeQbItem, null);
    }

    #endregion

    #region Clear

    private const String SqlDeleteAll = "Delete From ProjectTypeQbItem ";

      public static void Clear(IDbConnection connection)
      {
      using(IDbCommand dbCommand = Database.PrepareCommand(SqlDeleteAll, connection))
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

      
        + " ProjectTypeId, "
      
        + " QbItemListId "
      

      + " From ProjectTypeQbItem ";
      public static List<ProjectTypeQbItem> Find(IDbConnection connection)
      {
      using(IDbCommand dbCommand = Database.PrepareCommand(SqlSelectAll, connection))
      {
      List<ProjectTypeQbItem> rv = new List<ProjectTypeQbItem>();

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

      public static List<ProjectTypeQbItem> Find()
      {
      return Find(null);
      }


      #endregion

      #region Import from file

      public static int Import(String xmlFilePath)
      {
      List<ProjectTypeQbItem> itemsList = Load(xmlFilePath);

      if(itemsList.Count != 0)
      Insert(itemsList);

      return itemsList.Count;
      }

      #endregion

      #region ValueEquals

      public bool ValueEquals (ProjectTypeQbItem obj)
      {
      if (obj == null)
      return false;

      if (ReferenceEquals(this, obj))
      return true;

      return ProjectTypeId == obj.ProjectTypeId && QbItemListId == obj.QbItemListId;
      }

      #endregion

      #region Export to file
      
      public static int Export(String xmlFilePath)
      {

      List<ProjectTypeQbItem> itemsList = Find();

      if (itemsList.Count == 0)
      return 0;


      XmlWriter xmlWriter = new XmlTextWriter(xmlFilePath, Encoding.UTF8);
      XmlSerializer xmlSerializer = new XmlSerializer(typeof(ProjectTypeQbItem));

      xmlWriter.WriteStartDocument();
      xmlWriter.WriteStartElement("Root");

      foreach(ProjectTypeQbItem item in itemsList)
      xmlSerializer.Serialize(xmlWriter, item);

      xmlWriter.WriteEndElement();
      xmlWriter.WriteEndDocument();

      xmlWriter.Flush();
      xmlWriter.Close();

      return itemsList.Count;


      }
      #endregion

      #region Load from file

      public static List<ProjectTypeQbItem>
      Load(String xmlFilePath)
      {
      XmlSerializer xmlSerializer = new XmlSerializer(typeof(ProjectTypeQbItem));
      XmlDocument xmlDocument = new XmlDocument();

      xmlDocument.Load(xmlFilePath);

      List<ProjectTypeQbItem> itemsList
      = new List<ProjectTypeQbItem>();

      foreach (XmlNode xmlNode in xmlDocument.DocumentElement.ChildNodes)
      {
      Object deserializedObject = xmlSerializer.Deserialize(
      new XmlNodeReader(xmlNode));

      if (deserializedObject is ProjectTypeQbItem)
      itemsList.Add(deserializedObject as ProjectTypeQbItem);
      }

      return itemsList;
      }

      #endregion

      #endregion


      #region Biz
      

      #region Fields
      
        protected int m_projectTypeId;
      
        protected String m_qbItemListId;
      
      #endregion

      #region Constructors
      public ProjectTypeQbItem(
      int 
          projectTypeId,String 
          qbItemListId
      ) : this()
      {
      
        m_projectTypeId = projectTypeId;
      
        m_qbItemListId = qbItemListId;
      
      }

      
      #endregion

      
        [XmlElement]
        public int ProjectTypeId
        {
        get { return m_projectTypeId;}
        set { m_projectTypeId = value; }
        }
      
        [XmlElement]
        public String QbItemListId
        {
        get { return m_qbItemListId;}
        set { m_qbItemListId = value; }
        }
      

      public static int FieldsCount
      {
      get { return 2; }
      }


      public object Clone()
      {
      return MemberwiseClone();
      }

      }
      #endregion

      }

    