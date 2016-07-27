module ArticlesAngular.Controllers {

    export class ArticlesListController {
        constructor(private $resource: angular.resource.IResourceService) {
            this.getArticles();
        }

        public articles: any; // any - kai nežinau koks čia kintamasis bus

        public submit(isValid: boolean) {
            if (!isValid) {
                return;
            }

            var articlesResource = this.$resource('/api/articles');
            articlesResource.save(this.articles[0], () => {
                return;
            });
        }

        public getArticles() {
            var articlesResource = this.$resource('/api/articles');
            this.articles = articlesResource.query();
        }

        //public getArticle(articleId : any) {
        //    var articlesResource = this.$resource('/api/articles/:id', { id: '@id' });
        //    var article = articlesResource.get({ id: articleId });

        //    return article;
        //}
    }
}