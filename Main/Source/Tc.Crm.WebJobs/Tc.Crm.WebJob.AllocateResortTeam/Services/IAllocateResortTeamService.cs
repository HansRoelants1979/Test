﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tc.Crm.WebJob.AllocateResortTeam.Models;

namespace Tc.Crm.WebJob.AllocateResortTeam.Services
{
    public interface IAllocateResortTeamService:IDisposable
    {
        void Run();
        void GetBookingAllocations();        
        BookingAllocationResortTeamRequest PrepareResortTeamRequest(BookingAllocationResponse bookingAllocationResponse);
        IList<BookingAllocationResortTeamRequest> ProcessAllocationResponse(IList<BookingAllocationResponse> bookingAllocationResponses);
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
        IList<Guid> GetDestinationGateways();
        void AddResortTeamRequest(BookingAllocationResponse bookingResponse, IList<BookingAllocationResortTeamRequest> bookingAllocationResortTeamRequest);
        string WriteAllocationResponseLog(BookingAllocationResponse bookingAllocationResponse);
        CustomerResortTeamRequest PrepareCustomerResortTeamRequest(BookingAllocationResponse bookingResponse);        
        BookingResortTeamRequest PrepareBookingResortTeamRequest(BookingAllocationResponse bookingResponse);
        bool ValidForProcessing(BookingAllocationResponse bookingResponse, List<Guid> processedCustomers, string responseLog);
    }
}
