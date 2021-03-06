//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// Created via this command line: "C:\Users\admin\AppData\Roaming\MscrmTools\XrmToolBox\Plugins\CrmSvcUtil Ref\crmsvcutil.exe" /url:"https://thomascookdev.api.crm4.dynamics.com/XRMServices/2011/Organization.svc" /generateActions /out:"C:\Users\admin\AppData\Roaming\MscrmTools\XrmToolBox\Settings\CrmSvcUtil Ref\Actions.cs" /namespace:"CrmEarlyBound" /codecustomization:"DLaB.CrmSvcUtilExtensions.Action.CustomizeCodeDomService,DLaB.CrmSvcUtilExtensions" /codegenerationservice:"DLaB.CrmSvcUtilExtensions.Action.CustomCodeGenerationService,DLaB.CrmSvcUtilExtensions" /codewriterfilter:"DLaB.CrmSvcUtilExtensions.Action.CodeWriterFilterService,DLaB.CrmSvcUtilExtensions" /metadataproviderservice:"DLaB.CrmSvcUtilExtensions.BaseMetadataProviderService,DLaB.CrmSvcUtilExtensions" /username:"debarata.majumber@thomascook.com" /password:"************" 
//------------------------------------------------------------------------------

namespace CrmEarlyBound
{
	
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/tc/")]
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("tc_ProcessBooking")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.2.1.8676")]
	public partial class tc_ProcessBookingRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public string BookingInfo
		{
			get
			{
				if (this.Parameters.Contains("BookingInfo"))
				{
					return ((string)(this.Parameters["BookingInfo"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["BookingInfo"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityReference Target
		{
			get
			{
				if (this.Parameters.Contains("Target"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["Target"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["Target"] = value;
			}
		}
		
		public tc_ProcessBookingRequest()
		{
			this.RequestName = "tc_ProcessBooking";
			this.BookingInfo = default(string);
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/tc/")]
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("tc_ProcessBooking")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.2.1.8676")]
	public partial class tc_ProcessBookingResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public tc_ProcessBookingResponse()
		{
		}
		
		public string Response
		{
			get
			{
				if (this.Results.Contains("Response"))
				{
					return ((string)(this.Results["Response"]));
				}
				else
				{
					return default(string);
				}
			}
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/tc/")]
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("tc_ProcessSurvey")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.2.1.8676")]
	public partial class tc_ProcessSurveyRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public string SurveyResponseInfo
		{
			get
			{
				if (this.Parameters.Contains("SurveyResponseInfo"))
				{
					return ((string)(this.Parameters["SurveyResponseInfo"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["SurveyResponseInfo"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityReference Target
		{
			get
			{
				if (this.Parameters.Contains("Target"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["Target"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["Target"] = value;
			}
		}
		
		public tc_ProcessSurveyRequest()
		{
			this.RequestName = "tc_ProcessSurvey";
			this.SurveyResponseInfo = default(string);
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/tc/")]
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("tc_ProcessSurvey")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.2.1.8676")]
	public partial class tc_ProcessSurveyResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public tc_ProcessSurveyResponse()
		{
		}
		
		public string Response
		{
			get
			{
				if (this.Results.Contains("Response"))
				{
					return ((string)(this.Results["Response"]));
				}
				else
				{
					return default(string);
				}
			}
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/new/")]
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("new_DGTestVars")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.2.1.8676")]
	public partial class new_DGTestVarsRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public string SourceMarketIn
		{
			get
			{
				if (this.Parameters.Contains("SourceMarketIn"))
				{
					return ((string)(this.Parameters["SourceMarketIn"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["SourceMarketIn"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityReference Target
		{
			get
			{
				if (this.Parameters.Contains("Target"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["Target"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["Target"] = value;
			}
		}
		
		public new_DGTestVarsRequest()
		{
			this.RequestName = "new_DGTestVars";
			this.Target = default(Microsoft.Xrm.Sdk.EntityReference);
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/new/")]
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("new_DGTestVars")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.2.1.8676")]
	public partial class new_DGTestVarsResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public new_DGTestVarsResponse()
		{
		}
		
		public string SourceMarketOut
		{
			get
			{
				if (this.Results.Contains("SourceMarketOut"))
				{
					return ((string)(this.Results["SourceMarketOut"]));
				}
				else
				{
					return default(string);
				}
			}
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/tc/")]
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("tc_QueueIdentifier")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.2.1.8676")]
	public partial class tc_QueueIdentifierRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public string QueueName
		{
			get
			{
				if (this.Parameters.Contains("QueueName"))
				{
					return ((string)(this.Parameters["QueueName"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["QueueName"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityReference Case
		{
			get
			{
				if (this.Parameters.Contains("Case"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["Case"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["Case"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityReference Target
		{
			get
			{
				if (this.Parameters.Contains("Target"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["Target"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["Target"] = value;
			}
		}
		
		public tc_QueueIdentifierRequest()
		{
			this.RequestName = "tc_QueueIdentifier";
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/tc/")]
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("tc_QueueIdentifier")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.2.1.8676")]
	public partial class tc_QueueIdentifierResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public tc_QueueIdentifierResponse()
		{
		}
		
		public Microsoft.Xrm.Sdk.EntityReference Queue
		{
			get
			{
				if (this.Results.Contains("Queue"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Results["Queue"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/tc/")]
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("tc_TcCompensationEmailPaymentTypes")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.2.1.8676")]
	public partial class tc_TcCompensationEmailPaymentTypesRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public bool BACS
		{
			get
			{
				if (this.Parameters.Contains("BACS"))
				{
					return ((bool)(this.Parameters["BACS"]));
				}
				else
				{
					return default(bool);
				}
			}
			set
			{
				this.Parameters["BACS"] = value;
			}
		}
		
		public bool Cash
		{
			get
			{
				if (this.Parameters.Contains("Cash"))
				{
					return ((bool)(this.Parameters["Cash"]));
				}
				else
				{
					return default(bool);
				}
			}
			set
			{
				this.Parameters["Cash"] = value;
			}
		}
		
		public bool NonFinancial
		{
			get
			{
				if (this.Parameters.Contains("NonFinancial"))
				{
					return ((bool)(this.Parameters["NonFinancial"]));
				}
				else
				{
					return default(bool);
				}
			}
			set
			{
				this.Parameters["NonFinancial"] = value;
			}
		}
		
		public bool Voucher
		{
			get
			{
				if (this.Parameters.Contains("Voucher"))
				{
					return ((bool)(this.Parameters["Voucher"]));
				}
				else
				{
					return default(bool);
				}
			}
			set
			{
				this.Parameters["Voucher"] = value;
			}
		}
		
		public bool CHAPS
		{
			get
			{
				if (this.Parameters.Contains("CHAPS"))
				{
					return ((bool)(this.Parameters["CHAPS"]));
				}
				else
				{
					return default(bool);
				}
			}
			set
			{
				this.Parameters["CHAPS"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityReference Target
		{
			get
			{
				if (this.Parameters.Contains("Target"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["Target"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["Target"] = value;
			}
		}
		
		public tc_TcCompensationEmailPaymentTypesRequest()
		{
			this.RequestName = "tc_TcCompensationEmailPaymentTypes";
			this.Target = default(Microsoft.Xrm.Sdk.EntityReference);
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/tc/")]
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("tc_TcCompensationEmailPaymentTypes")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.2.1.8676")]
	public partial class tc_TcCompensationEmailPaymentTypesResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public tc_TcCompensationEmailPaymentTypesResponse()
		{
		}
		
		public string BACSvar
		{
			get
			{
				if (this.Results.Contains("BACSvar"))
				{
					return ((string)(this.Results["BACSvar"]));
				}
				else
				{
					return default(string);
				}
			}
		}
		
		public string CASHvar
		{
			get
			{
				if (this.Results.Contains("CASHvar"))
				{
					return ((string)(this.Results["CASHvar"]));
				}
				else
				{
					return default(string);
				}
			}
		}
		
		public string CHAPSvar
		{
			get
			{
				if (this.Results.Contains("CHAPSvar"))
				{
					return ((string)(this.Results["CHAPSvar"]));
				}
				else
				{
					return default(string);
				}
			}
		}
		
		public string NONFINANCIALvar
		{
			get
			{
				if (this.Results.Contains("NONFINANCIALvar"))
				{
					return ((string)(this.Results["NONFINANCIALvar"]));
				}
				else
				{
					return default(string);
				}
			}
		}
		
		public string VOUCHERvar
		{
			get
			{
				if (this.Results.Contains("VOUCHERvar"))
				{
					return ((string)(this.Results["VOUCHERvar"]));
				}
				else
				{
					return default(string);
				}
			}
		}
	}
}
