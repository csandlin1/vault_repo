
    /*******************************************************************
    * WorkTransactionVanCheck.as
    * Copyright (C) 2006 Midnight Coders, LLC
    *
    * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
    * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
    * MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
    * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
    * LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
    * OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
    * WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
    ********************************************************************/
    
        package Dalworth.WebService.Web.vo
        {
        [Bindable]
        [RemoteClass(alias="Dalworth.WebService.Domain.WorkTransactionVanCheck")]
      public class WorkTransactionVanCheck
        {
          public function WorkTransactionVanCheck(){}
        
          
            public var CounterValue:Number;
          
            public var CounterName:String;
          
            public var ID:Number;
          
            public var WorkTransactionId:Number;
          
            public var OilChecked:Boolean;
          
            public var UnitClean:Boolean;
          
            public var VanClean:Boolean;
          
            public var SuppliesStocked:Boolean;
          
            public var OdometerReading:Number;
          
            public var HobbsReading:Number;
          
            public var SpecialNeeds:String;
          
        }
      
      }
      