(function (app) {
    app.controller('ProductCategoryListController', ProductCategoryListController);
    ProductCategoryListController.$inject = ['$scope', 'apiService'];
    function ProductCategoryListController($scope, apiService) {
        $scope.ProductCategories = [];
        $scope.getProductCategories = getProductCategories;
        $scope.pageIndex = 0;
        $scope.totalPages = 0;
        function getProductCategories(pageIndex) {
            pageIndex = pageIndex || 0;
            var config = {
                params: {
                    pageIndex: pageIndex,
                    pageSize: 2
                }
            } 
            apiService.get('/api/productcategory/getall', config, function (result) {
                $scope.ProductCategories = result.data.Items;
                $scope.pageIndex = result.data.PageIndex;
                $scope.totalPages = result.data.TotalPages;
                $scope.totalCounts = result.data.TotalCounts;
            }, function () {
                console.log("load product categories failed");
            });
        }
        $scope.getProductCategories();
    }
})(angular.module('TShop.ProductCategories'));