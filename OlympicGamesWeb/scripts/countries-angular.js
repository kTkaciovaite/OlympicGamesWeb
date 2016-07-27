var CountriesAngular;
(function (CountriesAngular) {
    angular.module("countryApp", ["ngResource"]).
        controller("countriesListController", ["$resource", CountriesAngular.Controllers.CountriesListController]);
})(CountriesAngular || (CountriesAngular = {}));
//# sourceMappingURL=countries-angular.js.map