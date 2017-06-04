/// <reference path="../../node_modules/@types/angular/index.d.ts" />
module carsales.controllers {

    export class carsListController {

        list: Array<models.Vehicle>;
        static $inject = ["carsalesDataService"];
        constructor(carsalesDataService: services.carsalesDataService) {
            this.list = [];
            carsalesDataService.getAllVehicleData()
                .then((list: Array<models.Vehicle>) => {
                    this.list = list;
                });
        }
    }

    angular.module('tsCarsalesApp')
        .controller("carsListController", ["carsalesDataService", carsales.controllers.carsListController]);

}