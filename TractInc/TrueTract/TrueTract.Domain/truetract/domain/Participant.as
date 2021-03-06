package truetract.domain
{
    import flash.events.EventDispatcher;

    [Bindable]
	[RemoteClass(alias="TractInc.TrueTract.Entity.ParticipantInfo")]
    public class Participant extends EventDispatcher
    {
        public var ParticipantID:int;
        public var DocID:int;
        public var AsNamed:String = "";
        public var FirstName:String = "";
        public var MiddleName:String = "";
        public var LastName:String = "";
        public var IsSeler:Boolean = false;
 
        public function get FullName():String
        {
            var result:String = FirstName;
            
            if (MiddleName.length > 0)
                result += " " + MiddleName ;

            if (LastName.length > 0)
                result += " " + LastName ;

            return result;
        }
        
        public function clone():Participant
        {
            var clone:Participant = new Participant();
            clone.ParticipantID = ParticipantID;
            clone.DocID = DocID;
            clone.AsNamed = AsNamed;
            clone.FirstName = FirstName;
            clone.LastName = LastName;
            clone.MiddleName = MiddleName;
            clone.IsSeler = IsSeler;

            return clone;
        }
    }
}