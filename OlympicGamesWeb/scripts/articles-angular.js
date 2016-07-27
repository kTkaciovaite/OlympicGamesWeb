var ArticlesAngular;
(function (ArticlesAngular) {
    angular.module("articleApp", ["ngResource"])
        .controller("articlesListController", ["$resource", ArticlesAngular.Controllers.ArticlesListController]);
})(ArticlesAngular || (ArticlesAngular = {}));
//# sourceMappingURL=articles-angular.js.map