/// <reference path="../assets/admin/libs/angular/angular.js" />
(function () {
    angular.module("TShop", ['TShop.Product','TShop.ProductCategories', 'TShop.Common']).config(config);
    config.$inject = ['$stateProvider', '$urlRouterProvider']
    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('home', {
            url: '/Admin',
            templateUrl: '/App/Components/Home/HomeView.html',
            controller: 'HomeController'
        });
        $urlRouterProvider.otherwise('/Admin')
    }
})();