module SportspersonsAngular.Controllers {

    export class SportspersonsListController {
        constructor(private $resource: angular.resource.IResourceService) {
            this.getSportspersons();
        }

        public sportspersons: any;

        public submit(isValid: boolean) {
            if (!isValid) {
                return;
            }

            var sportspersonsResource = this.$resource('/api/sportspersons');
            sportspersonsResource.save(this.sportspersons[0], () => {
                return;
            });
        }

        public getSportspersons() {
            var sportspersonsResource = this.$resource('/api/sportspersons');
            this.sportspersons = sportspersonsResource.query();
        }
    }
}