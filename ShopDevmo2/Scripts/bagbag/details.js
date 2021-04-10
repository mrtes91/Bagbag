var app = angular.module('myApp', ['ngSanitize']);

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
  var id = $location.search().id;
  // id = parseInt(id);
  $scope.name = data[id].name;
  $scope.feature = data[id].feature;
  $scope.price = data[id].price;
  $scope.dimensions = data[id].dimensions;
  $scope.description = data[id].description;
  $scope.guarantee = data[id].guarantee;
  $scope.srcImage1 = data[id].pic1;
  $scope.srcImage2 = data[id].pic2;
  $scope.srcImage3 = data[id].pic3;
  $scope.srcImage4 = data[id].pic4;
  $scope.srcImage5 = data[id].pic5;
  $scope.srcImage6 = data[id].pic6;
});

// $(document).ready(function () {
//   $('.mot').click(function () {
//     $('#full-modal').css('display', 'block');
//   });
// });

// $(document).ready(function () {
//   $('.close-modal').click(function () {
//     $('#full-modal').css('display', 'none');
//   });
// });
// $(document).ready(function () {
//   $('.accept').click(function () {
//     $('#full-modal').css('display', 'none');
//   });
// });
