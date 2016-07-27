module CountriesAngular {
    angular.module("countryApp", ["ngResource"]).
        controller("countriesListController", ["$resource", Controllers.CountriesListController]);
}