var CountriesAngular;
(function (CountriesAngular) {
    var Controllers;
    (function (Controllers) {
        var CountriesListController = (function () {
            function CountriesListController($resource) {
                this.$resource = $resource;
                this.getCountries();
            }
            CountriesListController.prototype.submit = function (isValid) {
                if (!isValid) {
                    return;
                }
                var countriesResource = this.$resource('/api/countriesapi');
                countriesResource.save(this.countries[0], function () {
                    return;
                });
            };
            CountriesListController.prototype.getCountries = function () {
                var countriesResource = this.$resource('/api/countriesapi');
                this.countries = countriesResource.query();
            };
            return CountriesListController;
        }());
        Controllers.CountriesListController = CountriesListController;
    })(Controllers = CountriesAngular.Controllers || (CountriesAngular.Controllers = {}));
})(CountriesAngular || (CountriesAngular = {}));
//# sourceMappingURL=countries-list.controller.js.map