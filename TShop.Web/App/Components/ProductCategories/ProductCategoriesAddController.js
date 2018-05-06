(function (app) {
    app.controller("ProductCategoriesAddController", ProductCategoriesAddController);
    ProductCategoriesAddController.$inject = ['$scope', 'apiService', 'notificationServices', '$state'];

    function ProductCategoriesAddController($scope, apiService, notificationServices, $state) {
        $scope.productCategory = {
            CreateDate: new Date(),
            Status: true
        }
        // load parrent Categories
        function parentCategories() {
            apiService.get('/api/productcategory/getallcategories', null, function (result) {
                $scope.parentCategories = result.data;
            }, function () {
                console.log("Không thể lấy danh sách danh mục gốc.");
            });
        }
        parentCategories();
        // Add product category
        $scope.addProductCategory = addProductCategory;
        function addProductCategory() {
            apiService.post('/api/productcategory/add', $scope.productCategory, function (result) {
                notificationServices.displaySuccess(result.data.Name + " đã được thêm thành công");
                $state.go("ProductCategories");
            }, function () {
                notificationServices.displayError("Thêm không thành công");
            });
        }
    }
})(angular.module("TShop.ProductCategories"));