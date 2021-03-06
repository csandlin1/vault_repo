
package com.dalworth.servman.domain
{
    [Bindable]
    [RemoteClass(alias="Servman.Domain.PartnerProjectType")]
    public class PartnerProjectType
    {
        public function PartnerProjectType()
        {
        }
      
        private var _id:int;
        public function get id():int { return _id; }
        public function set id(value:int):void 
        {
            _id = value;
        }
      
        private var _businessPartnerId:int;
        public function get businessPartnerId():int { return _businessPartnerId; }
        public function set businessPartnerId(value:int):void 
        {
            _businessPartnerId = value;
        }
      
        private var _name:String;
        public function get name():String { return _name; }
        public function set name(value:String):void 
        {
            _name = value;
        }
      
    }
}
      