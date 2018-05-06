(function (app) {
    app.controller('ProductCategoryListController', ProductCategoryListController);
    ProductCategoryListController.$inject = ['$scope', 'apiService', 'notificationServices'];
    function ProductCategoryListController($scope, apiService, notificationServices) {
        $scope.ProductCategories = [];
        $scope.getProductCategories = getProductCategories;
        $scope.pageIndex = 0;
        $scope.totalPages = 0;
        $scope.keyWord = '';
        $scope.search = search;
        function search() {
            getProductCategories();
        }
        function getProductCategories(pageIndex) {
            pageIndex = pageIndex || 0;
            var config = {
                params: {
                    keyWord: $scope.keyWord,
                    pageIndex: pageIndex,
                    pageSize: 2
                }
            } 
            apiService.get('/api/productcategory/getall', config, function (result) {
                if (result.data.TotalCounts == 0) {
                    notificationServices.displayError("Kết quả tìm kiếm không có bản ghi nào.");
                } else {
                    if (result.data.PageIndex == 0 && $scope.keyWord != '') {
                        notificationServices.displaySuccess("Đã tìm thấy " + result.data.TotalCounts + " bản ghi.");
                    }
                }
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