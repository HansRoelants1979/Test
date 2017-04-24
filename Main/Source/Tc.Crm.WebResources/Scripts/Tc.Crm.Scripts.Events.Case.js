﻿//<script src ="scripts/es6promise.js" type ="text/javascript"></script>
//<script src ="scripts/Tc.Crm.Scripts.Common.js" type ="text/javascript"></script>

if (typeof (Tc) === "undefined") {
    Tc = {
        __namespace: true
    };
}
if (typeof (Tc.Crm) === "undefined") {
    Tc.Crm = {
        __namespace: true
    };
}
if (typeof (Tc.Crm.Scripts) === "undefined") {
    Tc.Crm.Scripts = {
        __namespace: true
    };
}
if (typeof (Tc.Crm.Scripts.Events) === "undefined") {
    Tc.Crm.Scripts.Events = {
        __namespace: true
    };
}

Tc.Crm.Scripts.Events.Case = (function () {
    "use strict";

    var CASE_TYPE_CONTROL_BOOKINGREF = "tc_bookingreference";
    var CASE_BOOKING_NUMBER = "tc_bookingid";
    var CASE_SOURCE_MARKET_ID = "tc_sourcemarketid";
    var CASE_SOURCE_MARKET_CURRENCY = "transactioncurrencyid";
    var CASE_ENTITY_NAME = "incident";
    var CASE_BOOKING_ENTITY_NAME = "tc_booking"
    var CASE_SOURCE_MARKET_ENTITY_NAME = "tc_country"
    var FORM_MODE_CREATE = 1;
    var FORM_MODE_UPDATE = 2;

    var GetTheSourceMarketCurrency = function () {

        
        console.log("Get The Source Market Currency - Start");
        if (Xrm.Page.getControl(CASE_TYPE_CONTROL_BOOKINGREF).getAttribute().getValue() == true) {


            if (Xrm.Page.getControl(CASE_BOOKING_NUMBER).getAttribute().getValue() != null) {
                var sourceMarketId;
                var Currencyid;
                var BookingId = Xrm.Page.getControl(CASE_BOOKING_NUMBER).getAttribute().getValue()[0].id;
                if (BookingId != null) {

                    BookingId = BookingId.replace("{", "").replace("}", "");
                    debugger;

                    var SourceMarketReceivedPromise = getBooking(BookingId).then(
                        function (bookingResponse) {
                            var booking = JSON.parse(bookingResponse.response);

                            sourceMarketId = booking._tc_sourcemarketid_value;
                            if (sourceMarketId != null) {
                                return getSourceMarketCurrency(sourceMarketId);
                            }

                            else {
                                alert("Source Market is not associated with Booking");
                                throw new Error("Source Market is not associated with Booking");
                            }


                        }).catch(function (err) {

                            throw new Error("Source Market is not associated with Booking");                        

                        });

                    var SourceMarketCurrency = SourceMarketReceivedPromise.then(
                   function (sourceMarketResponse) {
                       var sourceMarket = JSON.parse(sourceMarketResponse.response);

                       Currencyid = sourceMarket._transactioncurrencyid_value;

                       if (Currencyid != null) {
                           return getSourceMarketCurrencyname(Currencyid);
                       }
                       else {
                           alert("Currency is not associated with SourceMarket");
                           throw new Error("Currency is not associated with SourceMarket");
                       }
                       

                   }).catch(function (err) {
                       throw new Error("Source Market is not associated with Booking");
                   });

                    SourceMarketCurrency.then(
                   function (sourceMarketCurrencyNameResponse) {
                       var Currency = JSON.parse(sourceMarketCurrencyNameResponse.response);

                       if (Currency != null && Currency.currencyname != null && Currencyid != null) {
                           var currencyReference = [];
                           currencyReference[0] = {};
                           currencyReference[0].id = Currencyid;
                           currencyReference[0].entityType = "transactioncurrency"; //YTODO: test
                           currencyReference[0].name = Currency.currencyname;

                           Xrm.Page.getControl(CASE_SOURCE_MARKET_CURRENCY).getAttribute().setValue(currencyReference);
                       }


                   }).catch(function (err) {

                       throw new Error("Currency  is not associated with Source Market");

                   });

                }

            }

        }
        else {
            if (Xrm.Page.getControl(CASE_SOURCE_MARKET_ID).getAttribute().getValue() != null) {
                var Currencyid;
                var SourceMarketId = Xrm.Page.getControl(CASE_SOURCE_MARKET_ID).getAttribute().getValue()[0].id;
                if (SourceMarketId != null) {

                    SourceMarketId = SourceMarketId.replace("{", "").replace("}", "");

                    var SourceMarketCurrency = getSourceMarketCurrency(SourceMarketId).then(
                        function (sourceMarketResponse) {
                            var sourceMarket = JSON.parse(sourceMarketResponse.response);

                            Currencyid = sourceMarket._transactioncurrencyid_value;

                            if (Currencyid != null) {
                                return getSourceMarketCurrencyname(Currencyid);
                            }

                            else {
                                alert("Currency is not associated with SourceMarket");
                                throw new Error("Currency is not associated with SourceMarket");
                            }

                            alert("success");
                        }).catch(function (err) {

                            throw new Error("Currency  is not associated with Source Market");

                            
                        });


                    SourceMarketCurrency.then(
                       function (sourceMarketCurrencyNameResponse) {
                           var Currency = JSON.parse(sourceMarketCurrencyNameResponse.response);

                           if (Currency != null && Currency.currencyname != null && Currencyid != null) {
                               var currencyReference = [];
                               currencyReference[0] = {};
                               currencyReference[0].id = Currencyid;
                               currencyReference[0].entityType = "transactioncurrency"; //YTODO: test
                               currencyReference[0].name = Currency.currencyname;

                               Xrm.Page.getControl(CASE_SOURCE_MARKET_CURRENCY).getAttribute().setValue(currencyReference);
                           }


                       }).catch(function (err) {

                           throw new Error("Currency  is not associated with Source Market");

                           //Exception Handling functionality, we can get exception message by using [err.message]

                       });

                }

            }
        }

        console.log("Get The Source Market Currency - End");
    }


    function getBooking(bookingId) {

        var query = "?$select=_tc_sourcemarketid_value";
        var entityName = "tc_booking";
        var id = bookingId;
        return Tc.Crm.Scripts.Common.GetById(entityName, id, query);

    }

    function getSourceMarketCurrency(sourcMarketId) {
        var query = "?$select=_transactioncurrencyid_value";        
        var entityName = "tc_countrie";
        return Tc.Crm.Scripts.Common.GetById(entityName, sourcMarketId, query);
    }


    function getSourceMarketCurrencyname(Currencyid) {
        var query = "?$select=currencyname";
        var entityName = "transactioncurrencie";
        return Tc.Crm.Scripts.Common.GetById(entityName, Currencyid, query);
    }
    function MandatoryMetConditions() {
        debugger;
     
        if (Xrm.Page.getControl("tc_bookingreference").getAttribute().getValue() == true) {
            if (Xrm.Page.getControl("tc_mandatoryconditionsmet").getAttribute().getValue() == false) {
                if (Xrm.Page.getControl("tc_casetypeid").getAttribute().getValue() != null) {
                    if (Xrm.Page.getControl("tc_casetypeid").getAttribute().getValue()[0].name == "Complaint") {
                        if (Xrm.Page.getControl("tc_resortofficeid").getAttribute().getValue() != null &&
                            Xrm.Page.getControl("tc_datereported").getAttribute().getValue() != null &&
                            Xrm.Page.getControl("tc_istheholidaystoppingshorterthanplanned").getAttribute().getValue() != null &&
                            Xrm.Page.getControl("tc_3rdpartyresponserequired").getAttribute().getValue() != null &&
                            Xrm.Page.getControl("tc_preferredmethodofcommunication").getAttribute().getValue() != null &&
                            Xrm.Page.getControl("caseorigincode").getAttribute().getValue() != null
                            ) {
                            Xrm.Page.getControl("tc_mandatoryconditionsmet").getAttribute().setValue(true);
                            Xrm.Page.data.entity.save();
                        }
                    }
                }
            }
        }

        else {
            if (Xrm.Page.getControl("tc_casetypeid").getAttribute().getValue() != null) {
                if (Xrm.Page.getControl("tc_mandatoryconditionsmet").getAttribute().getValue() == false) {
                    if (Xrm.Page.getControl("tc_casetypeid").getAttribute().getValue()[0].name == "Complaint") {
                        if (Xrm.Page.getControl("tc_resortofficeid").getAttribute().getValue() != null &&
                            Xrm.Page.getControl("tc_datereported").getAttribute().getValue() != null &&
                            Xrm.Page.getControl("tc_istheholidaystoppingshorterthanplanned").getAttribute().getValue() != null &&
                            Xrm.Page.getControl("tc_3rdpartyresponserequired").getAttribute().getValue() != null &&
                            Xrm.Page.getControl("tc_preferredmethodofcommunication").getAttribute().getValue() != null &&
                            Xrm.Page.getControl("caseorigincode").getAttribute().getValue() != null &&
                            Xrm.Page.getControl("tc_sourcemarketid").getAttribute().getValue() != null &&
                            Xrm.Page.getControl("tc_brandid").getAttribute().getValue() != null &&
                            Xrm.Page.getControl("tc_destinationid").getAttribute().getValue() != null &&
                            Xrm.Page.getControl("tc_locationid").getAttribute().getValue() != null &&
                            Xrm.Page.getControl("tc_gateway").getAttribute().getValue() != null
                            ) {

                            Xrm.Page.getControl("tc_mandatoryconditionsmet").getAttribute().setValue(true);
                            Xrm.Page.data.entity.save();
                        }
                    }
                }
            }
        }
    }


    // public methods
    return {
        OnLoad: function () {

        },
        OnCaseSave: function () {

        },
        OnCaseFieldChange: function () {
            GetTheSourceMarketCurrency();
        },
        OnCaseFieldChangeMandatoryMetConditions: function () {
            MandatoryMetConditions();
        }
    };
})();