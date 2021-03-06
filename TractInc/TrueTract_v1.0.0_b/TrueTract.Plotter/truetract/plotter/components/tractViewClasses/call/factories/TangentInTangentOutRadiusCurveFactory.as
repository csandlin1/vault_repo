package truetract.plotter.components.tractViewClasses.call.factories
{
    import truetract.plotter.components.tractViewClasses.call.CallView;
    import truetract.plotter.components.tractViewClasses.call.propertyViews.CallPropertiesView;
    import truetract.plotter.components.tractViewClasses.call.propertyViews.TangentInTangentOutRadiusCPView;
    import truetract.plotter.domain.TractCall;
    import truetract.plotter.domain.callparams.ParamCollection;
    import truetract.plotter.domain.callparams.RadiusParam;
    import truetract.plotter.domain.callparams.TangentInBearingParam;
    import truetract.plotter.utils.GeoBearing;
    import truetract.plotter.utils.GeoCurve;
    import truetract.plotter.utils.UnitOfMeasure;
    import truetract.plotter.domain.callparams.TangentOutBearingParam;
    
    internal class TangentInTangentOutRadiusCurveFactory extends CurveFactory
    {
        private var m_tangentIn:GeoBearing;
        private var m_tangentOut:GeoBearing;        
        private var m_radius:Number;
        private var m_radiusUom:UnitOfMeasure;
        
        public function TangentInTangentOutRadiusCurveFactory(nextFactory:ICallViewFactory) {
            super(nextFactory);
        }
        
        override public function GetCallPropertiesView(call:TractCall):CallPropertiesView 
        {
            if (call.CallType != TractCall.CALL_TYPE_CURVE || !parseParams(call.Params)){
                
                return super.GetCallPropertiesView(call);
                
            } else {
                
                var result:TangentInTangentOutRadiusCPView = new TangentInTangentOutRadiusCPView();
                result.Model = call;
                result.tInBearingTxt.text = m_tangentIn.toInputString();
                result.tOutBearingTxt.text = m_tangentOut.toInputString();
                result.radiusTxt.text = m_radius.toString();
                result.radiusUom = m_radiusUom;
                return result;
            }
        }
        
        override protected function createGeoCurve():GeoCurve {
            var delta:Number = m_tangentOut.Azimuth - m_tangentIn.Azimuth;
            return new GeoCurve(m_radius * m_radiusUom.RateToOneFeet, delta, m_tangentIn);
        }
        
        override protected function parseParams(params:ParamCollection):Boolean 
        {
            var tangentInParam:TangentInBearingParam = TangentInBearingParam(
                params.GetParamByName(TangentInBearingParam.NAME));

            var tangentOutParam:TangentOutBearingParam = TangentOutBearingParam(
                params.GetParamByName(TangentOutBearingParam.NAME));
                
            var radiusParam:RadiusParam = RadiusParam(
                params.GetParamByName(RadiusParam.NAME));
                
            if (tangentInParam && tangentOutParam && radiusParam) {
            
                m_tangentIn = tangentInParam.Value;
                m_tangentOut = tangentOutParam.Value;                
                m_radius = radiusParam.Value;
                m_radiusUom = radiusParam.UOM;
                
                return true;
            } else {
                return false;
            }
        }
    }
}