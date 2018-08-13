function UpdateFlavorPurchased(target) {
    $('#CansSelectedFlavor').val($(target).children(":selected").text());
    var AvailableQuentity = target.value;
    if (AvailableQuentity > 0) {

        $('#btnCashPayment').removeAttr("disabled")
        $('#btnCcPayment').removeAttr("disabled");
    } else {
        $('#btnCashPayment').attr("disabled", "disabled");
        $('#btnCcPayment').attr("disabled", "disabled");
    }
}
function ValidatePayment(MethodToPay) {
    var RetVal = false;
    var reg = /^\d+$/;
    var DollarVal = $('#CansDollar').val();
    var CentsVal = $('#CansCents').val();

    var CansDollarDefined = $('#CansDollarDefined').val();
    var CansCentsDefined = $('#CansCentsDefined').val();

    if (reg.test(DollarVal) && reg.test(CentsVal)) {
        if (DollarVal === CansDollarDefined && CentsVal === CansCentsDefined) {
            $('#CansAmount').val(DollarVal + '.' + CentsVal);
            $('#MethodToPay').val(MethodToPay);
            RetVal = true;
        } else {
            alert("Amount of selected Flaver not matching with set price");
        }
    } else {
        alert("Amount is either empty or alphanumeric, please enter numeric value");
    }

    return RetVal;
}