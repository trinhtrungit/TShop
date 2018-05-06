/// <reference path="../../../assets/admin/libs/angular/angular.js" />
(function (app) {
    app.factory("notificationServices", notificationServices);
    function notificationServices() {
        toastr.options = {
            "closeButton": false,
            "debug": false,
            "newestOnTop": false,
            "progressBar": false,
            "positionClass": "toast-top-right",
            "preventDuplicates": false,
            "onclick": null,
            "showDuration": "300",
            "hideDuration": "1000",
            "timeOut": "5000",
            "extendedTimeOut": "1000",
            "showEasing": "swing",
            "hideEasing": "linear",
            "showMethod": "fadeIn",
            "hideMethod": "fadeOut"
        }
        function displaySuccess(message) {
            toastr.success(message);
        }
        function displayWarning(message) {
            toastr.warning(message);
        }
        function displayError(error) {
            if (Array.isArray(error)) {
                error.each(function (err) {
                    toastr.error(err);
                });
            } else {
                toastr.error(error);
            }
        }
        function displayRemove(message) {
            toastr.remove(message);
        }
        return {
            displaySuccess : displaySuccess, 
            displayWarning: displayWarning,
            displayError: displayError,
            displayRemove: displayRemove
        }
    }

})(angular.module("TShop.Common"));