module CountriesAngular.Controllers {

    export class CountriesListController {

        constructor(private $resource: angular.resource.IResourceService) {
            this.getCountries();
        }

        public countries: any;

        public submit(isValid: boolean) {
            if (!isValid) {
                return;
            }

            var countriesResource = this.$resource('/api/countriesapi');
            countriesResource.save(this.countries[0], () => {
                return;
            });
        }

        public getCountries() {
            var countriesResource = this.$resource('/api/countriesapi');
            this.countries = countriesResource.query();
        }
    }
}