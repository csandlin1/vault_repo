package truetract.domain
{
    import truetract.utils.GeoPosition;
    
[Bindable]
[RemoteClass(alias="TractInc.TrueTract.Entity.TractTextObjectInfo")]
public class TractTextObject
{
    
    public var TractTextObjectId:int;
    public var TractId:int;
    public var Text:String;
    public var Easting:Number;
    public var Northing:Number;
    public var Rotation:Number = 0;

    public function get Position():GeoPosition
    {
        return new GeoPosition(Easting, Northing);
    }

    public function set Position(value:GeoPosition):void {
        Easting = value.Easting;
        Northing = value.Northing;
    }

    public function clone():TractTextObject
    {
        var clone:TractTextObject = new TractTextObject();
        clone.TractTextObjectId = TractTextObjectId;
        clone.TractId = TractId;
        clone.Text = Text;
        clone.Easting = Easting;
        clone.Northing = Northing;
        clone.Rotation = Rotation;

        return clone;
    }

    public function get hashString():String 
    {
        var result:String = "";
        
        result += Text.toString();
        result += Easting.toString();
        result += Northing.toString();
        result += Rotation.toString();

        return result;
    }

}
}