module carsales.models {

    export enum VehicleClass {
        Car = 1,
        Bike = 2
    }

    export enum CarType {
        sedan = 0x0001,
        hatchBack = 0x0002
    }

    export enum BikeType {
        road = 0x0100,
        offRoad = 0x0200
    }

    export class VehicleModel {
        name: string;
        engines: Array<string> = [];
        doors: Array<number> = [3, 4, 5];
        wheels: Array<number> = [4];
    }

    export class Vehicle {

        id: number;

        vehicleClass: VehicleClass;
        vehicleClassType: string;

        image: string;

        name: string;
        make: string;
        model: string;
        engine: string;
        doors: Number;
        wheels: Number;

        vehicleType: number;

        constructor(id:number,
            cl: VehicleClass,
            vt: any,
            //nm: string,
            mk: string,
            mdl: string,
            eng: string,
            whls: number,
            drs: number = 0
        ) {
            this.id = id;
            this.vehicleClass = cl;
            if (this.vehicleClass === VehicleClass.Car) {
                this.image = "car";
                this.vehicleClassType = "Car";
            }
            else {
                this.image = "bike";
                this.vehicleClassType = "Bike";
            }
            this.vehicleType = vt;

            this.make = mk;
            this.model = mdl;
            this.engine = eng;
            this.name = mk + " - " + mdl + " - " + eng;
            if (vt === CarType.sedan) {
                this.name += " (Sedan)";
            }
            else if (vt === CarType.hatchBack) {
                this.name += " (Hatch)";
            }
            else if (vt === BikeType.road) {
                this.name += " (Road Bike)";
            }
            else if (vt === BikeType.offRoad) {
                this.name += " (Off-Road Bike)";
            }
            this.wheels = whls;

            this.doors = drs;
        }
    }
}