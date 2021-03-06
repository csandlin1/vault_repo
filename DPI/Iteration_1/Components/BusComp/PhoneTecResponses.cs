using System;
using System.Xml;
using System.Text;
using System.Collections;

using DPI.Interfaces;
using DPI.Components;

namespace DPI.Components
{
//	public class PhoneTechResponseFactory
//	{
//	}
	
//	public class SimpleResp
//	{
//		bool pass;
//		string errMessage;
//
//		public bool Pass { get { return pass; }}
//		public string ErrMessage { get { return errMessage; }}
//		
//		public virtual DictionaryEntry[] Entries 
//		{ 
//			get 
//			{
//				ArrayList ar = new ArrayList();
//
//				DictionaryEntry de = new DictionaryEntry();
//				
//				de.Key = "Pass";
//				de.Value = Pass.ToString();
//
//				ar.Add(de);
//
//				de = new DictionaryEntry();
//				de.Key = "ErrMsg";
//				de.Value = errMessage;
//
//				ar.Add(de);
//
//				DictionaryEntry[] entries = new DictionaryEntry[ar.Count];
//				ar.CopyTo(entries);
//
//				return entries;
//			}
//		}
//		public SimpleResp(XmlNode xNode)
//		{
//			XmlTextReader xReader = new XmlTextReader(new System.IO.StringReader
//				(XMLUtility.InsertLineBreaks(xNode.OuterXml))); 			
//			
//			while (xReader.Read())
//			{
//				if (xReader.NodeType != XmlNodeType.Element)
//					continue;
//
//				switch (xReader.Name.Trim().ToLower())
//				{
//					case "returnvalue" :
//					{
//						pass = xReader.ReadInnerXml().Trim().ToLower() == "pass" ;
//						break;
//					}
//					case "errormessage" :
//					{
//						errMessage = xReader.ReadInnerXml().Trim();
//						break;
//					}
//				}		
//			}
//		}
//	}
	public class DpiSvcPlanDataResp : ISvcPlanDataResp
	{
		bool pass;
		string errMessage;
		string planStatus;
		string esn;
		string controlNumber;
		DateTime customerSince;
		DateTime startDate;
		DateTime expirationDate;
		string mdn;
		decimal cashBalance;
		string planType;
		string planName;
		string pinItemNumber;
		string airtimeUsedMins;
		string nWUsedMins;
		string webUsedMins;
		string textUsedMins;
		string threeGWebUsedMins;
		string threeGPictureUsedMins;
		string threeGPTTUsedMins;		
		
		#region ISvcPlanDataResp Members
		public bool Pass { get { return pass; }}
		public string ErrMessage { get { return errMessage; }}
		public string PlanStatus    { get { return planStatus; }}
		public string Esn			{ get { return esn; }}
		public string ControlNumber { get { return controlNumber; }}
		public DateTime CustomerSince { get { return customerSince; }}
		public DateTime StartDate				{ get { return StartDate; }}
		public DateTime ExpirationDate			{ get { return ExpirationDate; }}
		public string Mdn						{ get { return mdn; }}
		public decimal CashBalance				{ get { return cashBalance; }}
		public string PlanType					{ get { return planType; }}
		public string PlanName					{ get { return planName; }}
		public string PinItemNumber				{ get { return pinItemNumber; }}
		public string AirtimeUsedMins			{ get { return airtimeUsedMins; }}
		public string NWUsedMins				{ get { return nWUsedMins; }}
		public string WebUsedMins				{ get { return webUsedMins; }}
		public string TextUsedMins				{ get { return textUsedMins; }}
		public string ThreeGWebUsedMins			{ get { return threeGWebUsedMins; }}
		public string ThreeGPictureUsedMins		{ get { return threeGPictureUsedMins; }}
		public string ThreeGPTTUsedMins			{ get { return threeGPTTUsedMins; }}
		#endregion

		public DpiSvcPlanDataResp(XmlNode xNode)
		{
			XmlTextReader xReader = new XmlTextReader(new System.IO.StringReader
				(XMLUtility.InsertLineBreaks(xNode.OuterXml))); 

			while (xReader.Read())
			{
				if (xReader.NodeType != XmlNodeType.Element)
					continue;

				switch (xReader.Name.ToLower())
				{
					case "returnvalue" :
						pass = xReader.ReadInnerXml().Trim().ToLower() == "pass" ;
						break;
					
					case "errormessage" :
						errMessage = xReader.ReadInnerXml().Trim();
						break;
					
					case "planstatus" :
						planStatus = xReader.ReadInnerXml().Trim();
						break;
					
					case "esn" :
						esn = xReader.ReadInnerXml().Trim();
						break;
					
					case "controlnumber" :
						controlNumber = xReader.ReadInnerXml().Trim();
						break;
					
					case "customersince" :
						customerSince = ConvertDateTime(xReader.ReadInnerXml().Trim());
						break;
					
					case "startdate" :
						startDate = ConvertDateTime(xReader.ReadInnerXml());				
						break;
					
					case "expirationdate" :
						expirationDate = ConvertDateTime(xReader.ReadInnerXml());
						break;
					
					case "mdn" :
						mdn = xReader.ReadInnerXml().Trim();
						break;
						
					case "cashbalance" :
						cashBalance = decimal.Parse(xReader.ReadInnerXml().Trim());
						break;

					case "plantype" :
						planType = xReader.ReadInnerXml().Trim();
						break;
					
					case "planname" :
						planName = xReader.ReadInnerXml().Trim();
						break;
					
					case "pinitemnumber" :
						pinItemNumber = xReader.ReadInnerXml().Trim();
						break;
					
					case "nwusedmins" :
						nWUsedMins = xReader.ReadInnerXml().Trim();
						break;

					case "airtimeusedmins" :
						airtimeUsedMins = xReader.ReadInnerXml().Trim();
						break;
					
					case "webusedmins" :
						webUsedMins = xReader.ReadInnerXml().Trim();
						break;
					
					case "textusedmins" :
						textUsedMins = xReader.ReadInnerXml().Trim();
						break;
					
					case "threegwebusedmins" :
						threeGWebUsedMins = xReader.ReadInnerXml().Trim();
						break;
					
					case "threegpictureusedmins" :
						threeGPictureUsedMins = xReader.ReadInnerXml().Trim();
						break;
					case "threegpttusedmins" :
						threeGPTTUsedMins = xReader.ReadInnerXml().Trim();
						break;
				}
			}
		}
		static DateTime ConvertDateTime(string s)
		{
			return ConvertDateTime(s, DateTime.MinValue);
		}

		static DateTime ConvertDateTime(string s, DateTime def)
		{
			if (s.Trim().Length == 0)
				return def;

			return DateTime.Parse(s);	
		}
		
	}
//	public class CheckActivationResp : SimpleResp
//	{
//		string msid;
//		string mdn;
//		string csa;
//		string msl;
//		string brand;
//		string model;
//		string returnStatus;
//
//		public string MSID        { get { return msid; }}
//		public string MDN         { get { return mdn; }}
//		public string CSA         { get { return csa; }}
//		public string MSL         { get { return msl; }}
//		public string Brand       { get { return brand; }}
//		public string Model       { get { return model; }}
//		public string Status      { get { return returnStatus; }}
//		public string PhoneNumber { get { return MDN; }}
//		
//		public override DictionaryEntry[] Entries 
//		{ 
//			get 
//			{
//				ArrayList ar = new ArrayList();
//				
//				DictionaryEntry de = new DictionaryEntry();
//				
//				de.Key = Const.MSL;
//				de.Value = msl;
//
//				ar.Add(de);
//
//				de = new DictionaryEntry();
//				de.Key = Const.MDN;
//				de.Value = mdn;
//
//				ar.Add(de);
//
//				de = new DictionaryEntry();
//				de.Key = Const.MSID;
//				de.Value = msid;
//
//				ar.Add(de);
//
//				DictionaryEntry[] entries = new DictionaryEntry[ar.Count];
//				ar.CopyTo(entries);
//
//				return entries;
//			}
//		}
//		public CheckActivationResp(XmlNode xNode) : base(xNode)
//		{
//			XmlTextReader xReader = new XmlTextReader(new System.IO.StringReader
//														(XMLUtility.InsertLineBreaks(xNode.OuterXml))); 
//
//			while (xReader.Read())
//			{
//				if (xReader.NodeType != XmlNodeType.Element)
//					continue;
//
//				switch (xReader.Name.ToLower())
//				{
//					case "msid" :
//					{
//						msid = xReader.ReadInnerXml();
//						break;
//					}
//					case "mdn" :
//					{
//						mdn = xReader.ReadInnerXml();
//						break;
//					}
//					case "csa" :
//					{
//						csa = xReader.ReadInnerXml();
//						break;
//					}
//					case "msl" :
//					{
//						msl = xReader.ReadInnerXml();
//						break;
//					}
//					case "brand" :
//					{
//						brand = xReader.ReadInnerXml();
//						break;
//					}
//					case "model" :
//					{
//						model = xReader.ReadInnerXml();
//						break;
//					}
//					case "returnstatus" :
//					{
//						returnStatus = xReader.ReadInnerXml().Trim();
//						break;
//					}
//				}
//			}
//		}
//	}
//
//	public class ActivatePhoneXml : XElement
//	{
//		public ActivatePhoneXml(string newESN, string pin, string zip, string acct, string pw)
//		{
//			name = "request";
//			SetupElmnts(newESN, pin, zip, acct, pw);
//		} 
//
//		/*		Implementation		*/
//		void SetupElmnts(string newESN, string pin, string zip, string acct, string pw)
//		{
//			children = new XElement[5];
//			int i = 0;
//
//			children[i++] = new XElement("NewESN",   newESN);
//			children[i++] = new XElement("Pin",		 pin);
//			children[i++] = new XElement("Zip",   zip);
//			children[i++] = new XElement("Account", acct);
//			children[i++] = new XElement("Password",  pw);			
//		}		
//	}
//	public class CheckActivationXml : XElement
//	{
//		public CheckActivationXml(string newESN, string acct, string pw)
//		{
//			name = "request";
//			SetupElmnts(newESN, acct, pw);
//		} 
//
//		/*		Implementation		*/
//		void SetupElmnts(string newESN, string acct, string pw)
//		{
//			children = new XElement[3];
//			int i = 0;
//
//			children[i++] = new XElement("NewESN",   newESN);			
//			children[i++] = new XElement("Account", acct);
//			children[i++] = new XElement("Password",  pw);			
//		}		
//	}
//	public class ReplenishServicePlanXml : XElement
//	{
//		public ReplenishServicePlanXml(string pin, string phone, string acct, string pw)
//		{
//			name = "request";
//			SetupElmnts(pin, phone, acct, pw);
//		} 
//
//		/*		Implementation		*/
//		void SetupElmnts(string pin, string phone, string acct, string pw)
//		{
//			children = new XElement[4];
//			int i = 0;
//
//			children[i++] = new XElement("Pin",		 pin);
//			children[i++] = new XElement("Phone",   phone);
//			children[i++] = new XElement("Account", acct);
//			children[i++] = new XElement("Password",  pw);			
//		}		
//	}
}