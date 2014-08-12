var eggs2throw = angular.module('eggs2throw', []);

eggs2throw.controller('movieView', ['$scope', function ($scope) {
    $scope.movies = [{id : 0, title : 'Interloper'}, {id : 1, title : 'Starfox'}, {id : 2, title : 'Zelda Zombies'}];
}]);