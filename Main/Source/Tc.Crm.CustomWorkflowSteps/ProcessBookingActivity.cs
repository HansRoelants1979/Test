﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Activities;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;
using System.ServiceModel;

namespace Tc.Crm.CustomWorkflowSteps
{
    public class ProcessBookingActivity : CodeActivity
    {
        protected override void Execute(CodeActivityContext executionContext)
        {
            //Create the tracing service
            ITracingService tracingService = executionContext.GetExtension<ITracingService>();

            //Create the context
            IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
            IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);           
            try
            {
                PayloadBooking payloadBooking = new PayloadBooking(tracingService, service);
                ProcessBooking process = new ProcessBooking(payloadBooking);
                Response.Set(executionContext, process.ProcessPayload(BookingInfo.Get<string>(executionContext)));

            }
            catch (FaultException<OrganizationServiceFault> ex)
            {  
                throw new InvalidPluginExecutionException(ex.ToString());
            }
            catch (Exception ex)
            {   
                throw new InvalidPluginExecutionException(ex.ToString());
            }

        }


        [Input("String BookingInfo")]        
        public InArgument<string> BookingInfo { get; set; }

        [Output("String Response")]
        public OutArgument<string> Response { get; set; }
    }

   

}
