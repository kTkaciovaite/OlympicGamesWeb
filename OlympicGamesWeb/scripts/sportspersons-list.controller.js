var SportspersonsAngular;
(function (SportspersonsAngular) {
    var Controllers;
    (function (Controllers) {
        var SportspersonsListController = (function () {
            function SportspersonsListController($resource) {
                this.$resource = $resource;
                this.getSportspersons();
            }
            SportspersonsListController.prototype.submit = function (isValid) {
                if (!isValid) {
                    return;
                }
                var sportspersonsResource = this.$resource('/api/sportspersons');
                sportspersonsResource.save(this.sportspersons[0], function () {
                    return;
                });
            };
            SportspersonsListController.prototype.getSportspersons = function () {
                var sportspersonsResource = this.$resource('/api/sportspersons');
                this.sportspersons = sportspersonsResource.query();
            };
            return SportspersonsListController;
        }());
        Controllers.SportspersonsListController = SportspersonsListController;
    })(Controllers = SportspersonsAngular.Controllers || (SportspersonsAngular.Controllers = {}));
})(SportspersonsAngular || (SportspersonsAngular = {}));
//# sourceMappingURL=sportspersons-list.controller.js.map