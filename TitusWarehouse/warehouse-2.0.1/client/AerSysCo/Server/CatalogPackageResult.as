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

  public class CatalogPackageResult
  {
    private var resultField:AerSysCo.Server.RequestResult;
    private var packField:AerSysCo.Server.CatalogPackage;

    public function CatalogPackageResult()
    {
      this.resultField = new AerSysCo.Server.RequestResult();
      this.packField = new AerSysCo.Server.CatalogPackage();

    }

    public function get result():AerSysCo.Server.RequestResult
    {
        return this.resultField;
    }
    public function set result(value:AerSysCo.Server.RequestResult):void
    {
       this.resultField = value;
    }
    public function get pack():AerSysCo.Server.CatalogPackage
    {
        return this.packField;
    }
    public function set pack(value:AerSysCo.Server.CatalogPackage):void
    {
       this.packField = value;
    }

  }
}