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

  public class SalesRepResult
  {
    private var resultField:AerSysCo.Server.RequestResult;
    private var salesRepField:AerSysCo.Server.SalesRep;

    public function SalesRepResult()
    {
      this.resultField = new AerSysCo.Server.RequestResult();
      this.salesRepField = new AerSysCo.Server.SalesRep();

    }

    public function get result():AerSysCo.Server.RequestResult
    {
        return this.resultField;
    }
    public function set result(value:AerSysCo.Server.RequestResult):void
    {
       this.resultField = value;
    }
    public function get salesRep():AerSysCo.Server.SalesRep
    {
        return this.salesRepField;
    }
    public function set salesRep(value:AerSysCo.Server.SalesRep):void
    {
       this.salesRepField = value;
    }

  }
}