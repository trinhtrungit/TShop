/// <reference path="../../../assets/admin/libs/angular/angular.js" />
(function (app) {
    app.filter('statusFilter', function () {
        return function (input) {
            return input ? "Kích hoạt" : "Chưa kích hoạt";
        }
    });
})(angular.module('TShop.Common'));