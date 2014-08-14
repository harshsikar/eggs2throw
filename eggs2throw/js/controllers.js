var eggs2throw = angular.module('eggs2throw', ['ngResource']);

eggs2throw.controller('movieView', ['$scope', 'ajaxService', function ($scope, ajaxService) {
    $scope.movies = ajaxService.getEvent().jData();
    console.log($scope.movies);
}]);