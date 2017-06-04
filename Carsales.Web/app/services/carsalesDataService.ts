module carsales.services {
    export class carsalesDataService {
        static $inject = ["$log", "$http", "$q", "$timeout"];
        constructor(
            private $log: ng.ILogService,
            private $http: ng.IHttpService,
            private $q: ng.IQService,
            private $timeout: ng.ITimeoutService) {
        }

        list: Array<models.Vehicle> = [];

        getAllVehicleData = (): ng.IPromise<any> => {

            this.$log.debug("GetAllVehicles");

            let deferred = this.$q.defer();
            this.$timeout(() => {
                this.list = [];
                this.list.push(new models.Vehicle(0, models.VehicleClass.Car, models.CarType.sedan, "Holden", "Commodore", "V6 Petrol", 4, 4));
                this.list.push(new models.Vehicle(1, models.VehicleClass.Car, models.CarType.hatchBack, "Holden", "Commodore", "V6 Petrol", 4, 4));
                this.list.push(new models.Vehicle(2, models.VehicleClass.Car, models.CarType.sedan, "Toyota", "Camry", "V4 Petrol", 4, 4));
                this.list.push(new models.Vehicle(3, models.VehicleClass.Car, models.CarType.sedan, "Toyota", "Camry", "V6 Petrol", 4, 4));
                this.list.push(new models.Vehicle(4, models.VehicleClass.Car, models.CarType.hatchBack, "Toyota", "Camry", "Hybrid", 4, 4));

                this.list.push(new models.Vehicle(5, models.VehicleClass.Bike, models.BikeType.road, "BMW", "BK3", "800cc Petrol", 2, 0));
                this.list.push(new models.Vehicle(6, models.VehicleClass.Bike, models.BikeType.road, "BMW", "BK3", "1200cc Petrol", 2, 0));
                this.list.push(new models.Vehicle(7, models.VehicleClass.Bike, models.BikeType.offRoad, "BMW", "OR3", "Diesel", 3, 0));
                this.list.push(new models.Vehicle(8, models.VehicleClass.Bike, models.BikeType.offRoad, "BMW", "OR3", "Petrol", 3, 0));
                
                deferred.resolve(this.list);
            }, 1000);
            return deferred.promise;
        }

        getVehicleData = (vClass, vehicleId): ng.IPromise<any> => {
            let deferred = this.$q.defer();
            this.$timeout(() => {
                let item = this.list.filter((v) => {
                    return (v.id === vehicleId && vClass === v.vehicleClassType)
                });
                return item[0];
            }, 500);
            return deferred.promise;
        }
    }

    angular.module('tsCarsalesApp')
        .service("carsalesDataService", ["$log", "$http", "$q", "$timeout", carsales.services.carsalesDataService]);

}