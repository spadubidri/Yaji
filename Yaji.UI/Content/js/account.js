

function signin(formID) {
    // Checking for client side validations before Submiting
    debugger;
    var _oData = {
        type: "POST",
        url: "http://localhost:1879/Account/Login/Signin",
        data: getFormData(formID),
        success: processEventsSummaryListings,
        error: function () {

        },
        complete: null,
        dataType: "html"
    };
    submitAjax(_oData);

}

function loadNewDevalayaListings() {
    // Checking for client side validations before Submiting
    debugger;
            var _oData = {
                type: "GET",
                url: "http://localhost:1879/devalaya/devalaya/NewDevalayaListings",
                data: "",
                success: processDevalayaSummaryListings,
                error: function () {

                },
                complete: null,
                dataType: "html"
            };
            submitAjax(_oData);
}

function processDevalayaSummaryListings(data) {
    
    $("#devalayaListing").html(data);
    
}


function processEventsSummaryListings(data) {
    $("#eventsListing").html(data);
}

function submitAjax(oData) {
    // debugger;
    if ((typeof (oData) != "undefined")) {
        if ((typeof (oData.type) != "undefined") && (typeof (oData.url) != "undefined") && (typeof (oData.data) != "undefined") && (typeof (oData.success) == "function")) {
            var onErrorMethod;
            if ((oData.error == "undefined") || (typeof (oData.error) != "function")) {
                onErrorMethod = function () { showErrorValidationSummary([generalErrorMessage]); }
            }
            else {
                onErrorMethod = oData.error;
            }

            $.ajax({
                type: oData.type,
                url: oData.url,
                data: oData.data,
                beforeSend: oData.beforeSend,
                success: oData.success,
                error: onErrorMethod,
                complete: oData.complete
            });
        }
    }
    return false;
}
