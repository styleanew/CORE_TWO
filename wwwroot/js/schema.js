var schem1 = angular.module('schemodal', ['ngTouch', 'ui.grid']);


schem1.controller('gridCtrl', ['$scope', function ($scope) {
    $scope.myData = [{ 'name': "Moroni", "due": "50" },
    { "name": "Tiancum", "due": "43" }
    ];
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