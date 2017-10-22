var schem1 = angular.module('schemodal', ['ui.grid']);


schem1.controller('MyCtrl', ['$scope', function ($scope) {
    $scope.myData = [{ name: "Moroni", due: 50 },
    { name: "Tiancum", due: 43 },
    { name: "Jacob", due: 27 },
    { name: "Nephi", due: 29 },
    { name: "Enos", due: 34 }];
    $scope.gridOptions = { data: 'myData' };
}]);


  

//app.controller('MainCtrl', ['$scope', function ($scope) {
  
//  $scope.myData = [
//    {
//        "firstName": "Cox",
//        "lastName": "Carney",
//        "company": "Enormo",
//        "employed": true
//    },
//    {
//        "firstName": "Lorraine",
//        "lastName": "Wise",
//        "company": "Comveyer",
//        "employed": false
//    },
//    {
//        "firstName": "Nancy",
//        "lastName": "Waters",
//        "company": "Fuelton",
//        "employed": false
//    }
//];
//}]);