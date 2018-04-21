(function () {
    angular.module("TShop.Product", ['TShop.Common']).config(config);
    config.$inject = ['$stateProvider', '$urlRouterProvider']
    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('Products', {
            url: '/Products',
            templateUrl: '/app/components/Products/ProductListView.html',
            controller: 'ProductListController'
        }).state('Products_Add', {
            url: '/Products_Add',
            templateUrl: '/app/components/Products/ProductAddView.html',
            controller: 'ProductAddController'
        });
    }
})();