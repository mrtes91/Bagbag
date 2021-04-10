var app = angular.module('myApp', []); // bỏ 'ngSanitize' trong []

app.config(function ($locationProvider) {
  $locationProvider.html5Mode({
    enabled: true,
    requireBase: false,
  });
});

app.controller('myController', function ($scope, $location, $sce) {
  $scope.trustSrc = function (src) {
    return $sce.trustAsResourceUrl(src);
  };
  $scope.bags = data;

  var feature = $location.search().feature;
  var brand = $location.search().brand;
  var sex = $location.search().sex;

  var search = {};

  search.feature = feature;
  search.brand = brand;
  search.sex = sex;

  $scope.search = search;

  $scope.srcDetails = 'details.html?id=';
  $scope.srcImage = 'images_final/product/pic1.jpg';
});

// var queryString = window.location.search;
// var urlParams = new URLSearchParams(queryString);
// var feature = urlParams.get('feature') == null ? '' : urlParams.get('feature');
// var brand = urlParams.get('brand') == null ? '' : urlParams.get('brand');
// var sex = urlParams.get('sex') == null ? '' : urlParams.get('sex');

// $scope.search = function (item) {
//   if ($scope.searchBag == undefined) {
//     return true;
//   } else {
//     if (
//       item.name.toLowerCase().indexOf($scope.searchBag.toLowerCase()) != -1 ||
//       item.brand.toLowerCase().indexOf($scope.searchBag.toLowerCase()) != -1 ||
//       item.color.toLowerCase().indexOf($scope.searchBag.toLowerCase()) != -1 ||
//       item.sex.toLowerCase().indexOf($scope.searchBag.toLowerCase()) != -1 ||
//       item.manufacturer.toLowerCase().indexOf($scope.searchBag.toLowerCase()) != -1
//     ) {
//       return true;
//     }
//   }
//   return false;
// };
