//*******************************************************************
//  <auto-generated>
//       FleXtense : www.flextense.net
//       Version:1.0 Beta Release
//
//
//       Changes to this file may cause incorrect behavior and will be lost if
//       the code is regenerated.
//  <auto-generated>
//*******************************************************************

 package AerSysCo.Server
{

  public class ASCUser
  {
    private var userIdField:int = 0;
    private var userTypeIdField:int = 0;
    private var brandIdField:int = 0;
    private var loginField:String="";
    private var passwordField:String="";
    private var brandField:AerSysCo.Server.Brand;
    private var userTypeField:AerSysCo.Server.UserType;
    private var createdByUserField:String="";
    private var lastUpdateDateField:Date;
    private var dateCreatedField:Date;

    public function ASCUser()
    {
      this.brandField = new AerSysCo.Server.Brand();
      this.userTypeField = new AerSysCo.Server.UserType();

    }

    public function get userId():int
    {
        return this.userIdField;
    }
    public function set userId(value:int):void
    {
       this.userIdField = value;
    }
    public function get userTypeId():int
    {
        return this.userTypeIdField;
    }
    public function set userTypeId(value:int):void
    {
       this.userTypeIdField = value;
    }
    public function get brandId():int
    {
        return this.brandIdField;
    }
    public function set brandId(value:int):void
    {
       this.brandIdField = value;
    }
    public function get login():String
    {
        return this.loginField;
    }
    public function set login(value:String):void
    {
       this.loginField = value;
    }
    public function get password():String
    {
        return this.passwordField;
    }
    public function set password(value:String):void
    {
       this.passwordField = value;
    }
    public function get brand():AerSysCo.Server.Brand
    {
        return this.brandField;
    }
    public function set brand(value:AerSysCo.Server.Brand):void
    {
       this.brandField = value;
    }
    public function get userType():AerSysCo.Server.UserType
    {
        return this.userTypeField;
    }
    public function set userType(value:AerSysCo.Server.UserType):void
    {
       this.userTypeField = value;
    }
    public function get createdByUser():String
    {
        return this.createdByUserField;
    }
    public function set createdByUser(value:String):void
    {
       this.createdByUserField = value;
    }
    public function get lastUpdateDate():Date
    {
        return this.lastUpdateDateField;
    }
    public function set lastUpdateDate(value:Date):void
    {
       this.lastUpdateDateField = value;
    }
    public function get dateCreated():Date
    {
        return this.dateCreatedField;
    }
    public function set dateCreated(value:Date):void
    {
       this.dateCreatedField = value;
    }

  }
}