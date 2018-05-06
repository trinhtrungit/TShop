﻿/// <reference path="../../../assets/admin/libs/angular/angular.js" />
(function (app) {
    app.factory("apiService", apiService);
    apiService.$inject = ['$http', 'notificationServices'];
    function apiService($http, notificationService) {
        return {
            get: get,
            post: post
        }
        function post(url, data, success, failure) {
            $http.post(url, data).then(function (result) {
                success(result);
            }, function (error) {
                if (error.status == 401) {
                    notificationServices.displayError("Authencation is required");
                } else if (failure != null){
                    failure(error);
                }
            });
        }
        function get(url, params, success, failure) {
            $http.get(url, params).then(function (result) {
                success(result);
            }, function (error) {
                failure(error);
            });
        }
    }
})(angular.module("TShop.Common"));