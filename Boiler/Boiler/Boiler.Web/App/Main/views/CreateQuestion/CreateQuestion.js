var controllerId = 'app.views.createquestion';
var app = angular.module('app');
app.controller(controllerId, ['$scope', 'createquestionService', function ($scope, createquestionService) {
    createquestionService.getCategories()
     .then(function (data) {
         $scope.categories = data;
     });

    createquestionService.getQuestionTypes()
        .then(function (data) {
            $scope.categories = data;
        });
}
]);

app.service('createquestionService', function ($http, $q) {
    this.getCategories = function () {
        var response = $http({
            method: "GET",
            url: "/CreateQuestion/GetCategories",
            dataType: "json"

        });
        return response;
    }

    this.getQuestionTypes = function () {
        var response = $http({
            method: "GET",
            url: "/CreateQuestion/GetQuestionTypes",
            dataType: "json"

        });
        return response;
    }

    //var data;
    //return {
    //    getCategories: function () {
    //        debugger;
    //        var deferred = $q.defer();
    //        if (data) { deferred.resolve(data); }
    //        else {
    //            $http({ method: 'GET', url: "/CreateQuestion/GetCategories" })
    //                .success(function (data) { data = data; deferred.resolve(data); })
    //                .error(deferred.reject)
    //        }
    //        return deferred.promise;
    //    },
    //};
});

