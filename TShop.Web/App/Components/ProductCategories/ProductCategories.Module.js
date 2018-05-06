(function () {
    angular.module("TShop.ProductCategories", ['TShop.Common']).config(config);
    config.$inject = ['$stateProvider', '$urlRouterProvider']
    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('ProductCategories', {
            url: '/ProductCategories',
            templateUrl: '/app/components/ProductCategories/ProductCategoryListView.html',
            controller: 'ProductCategoryListController'
        }).state('addProductCategories', {
            url: '/addProductCategories',
            templateUrl: '/app/components/ProductCategories/ProductCategoriesAddView.html',
            controller: 'ProductCategoriesAddController'
        })
    }
})();