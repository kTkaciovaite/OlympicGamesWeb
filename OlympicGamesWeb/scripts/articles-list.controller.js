var ArticlesAngular;
(function (ArticlesAngular) {
    var Controllers;
    (function (Controllers) {
        var ArticlesListController = (function () {
            function ArticlesListController($resource) {
                this.$resource = $resource;
                this.getArticles();
            }
            ArticlesListController.prototype.submit = function (isValid) {
                if (!isValid) {
                    return;
                }
                var articlesResource = this.$resource('/api/articles');
                articlesResource.save(this.articles[0], function () {
                    return;
                });
            };
            ArticlesListController.prototype.getArticles = function () {
                var articlesResource = this.$resource('/api/articles');
                this.articles = articlesResource.query();
            };
            return ArticlesListController;
        }());
        Controllers.ArticlesListController = ArticlesListController;
    })(Controllers = ArticlesAngular.Controllers || (ArticlesAngular.Controllers = {}));
})(ArticlesAngular || (ArticlesAngular = {}));
//# sourceMappingURL=articles-list.controller.js.map