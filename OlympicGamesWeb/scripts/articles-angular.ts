module ArticlesAngular {
    angular.module("articleApp", ["ngResource"])
        .controller("articlesListController", ["$resource", Controllers.ArticlesListController]);
}