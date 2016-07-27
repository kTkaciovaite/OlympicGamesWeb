module SportspersonsAngular {
    angular.module("sportspersonApp", ["ngResource"])
        .controller("sportspersonsListController", ["$resource", Controllers.SportspersonsListController]);
}