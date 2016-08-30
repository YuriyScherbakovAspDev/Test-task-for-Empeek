var app = angular.module('DiscInspector', []);


app.controller('DiscInspectorInitController', function ($scope, $http) {
    var init = $http.get("api/Disc/GetDiscInfo")
    .then(function (response) { $scope.DiscInfo = response.data; });

    $scope.getDeeper = function (path) {
        var getDeeper = $http.get("api/Disc/GetDiscInfo?path=" + path)
                .then(function (response) {
                    $scope.DiscInfo = response.data;
                });
    }
    $scope.getUpper = function (path) {
        var getUpper = $http.post("api/Disc/GetDiscInfoUP?path=" + path)
                .then(function (response) {
                    $scope.DiscInfo = response.data;
                });
    }
});