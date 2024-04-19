(function (app) {
    app.controller('rootController', rootController);

    rootController.$inject = ['$state', '$scope'];

    function rootController($state, $scope) {
        $scope.logOut = function () {
            //loginService.logOut();
            $state.go('login');
        }
        //$scope.authentication = authData.authenticationData;
        //$scope.sideBar = "/app/shared/views/sideBar.html";
        //authenticationService.validateRequest();
    }
})(angular.module('tedushop'));