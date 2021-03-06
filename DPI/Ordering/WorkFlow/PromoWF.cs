using System;
using System.Collections;
using DPI.ClientComp;
using DPI.Interfaces;
using DPI.Components;

namespace DPI.Ordering
{
	public class PromoWF : IWorkflow
	{
	#region Data
		static WIP.WipStep[] steps; 
		static string name = "Promo";
		static string imageTag = null;//"images/subtable_CustInq.jpg";
	#endregion
	
	#region Properties
		public string Name { get { return name; }}
		public string ImageTag { get { return imageTag; }}
		public static WIP.WipStep Registration
		{
			get 
			{ 
				checkExist();
				return steps[0]; 
			}
		}
		public int Count	{ get { return steps.Length; }}
		public IWipStep FirstStep	{get { return Registration; }}
	#endregion
	
	#region Constructors		
		PromoWF()
		{
			ArrayList ar = new ArrayList();
			
			WIP.WipStep registration =	new WIP.WipStep(this, "registration", "PromoRegForm.aspx"); 
			ar.Add(registration);
			
			//
			WIP.WipStep confirmation = new WIP.WipStep(this, "Confirmation", "RegFormResponse.aspx");  
			ar.Add(confirmation);

			registration.SetNext(confirmation);						
 
			steps = new WIP.WipStep[ar.Count];
			ar.CopyTo(steps);
		}
	#endregion
	
	#region Methods
		public static IWipStep GetFirst()
		{
			if (steps == null)
				new PromoWF();

			return steps[0];
		}
		public int CurrStep(IWipStep curr)
		{
			for (int i  = 0; i < steps.Length; i++)
				if (steps[i] == curr)
					return ++i;
			
			throw new ArgumentException("Step is not found");
		}
		static void checkExist()
		{
			PromoWF wf;
			if (steps == null)
				wf = new PromoWF();
		}
	#endregion
	}
}			