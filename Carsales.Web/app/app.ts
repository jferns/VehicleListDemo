/// <reference path="../node_modules/@types/angular/index.d.ts" />
/// <reference path="../node_modules/@types/angular-route/index.d.ts" />
/* jshint unused: false */
module carsales.app {
    angular.module("tsCarsalesApp", ['ngAria', 'ngRoute', 'ngSanitize'])
        .config(['$routeProvider', '$locationProvider', '$logProvider',
            function routes($routeProvider: ng.route.IRouteProvider,
                $locationProvider: ng.ILocationProvider,
                $logProvider: ng.ILogProvider) {

                $locationProvider.html5Mode({ enabled: true, requireBase: false });

                $logProvider.debugEnabled(true);

                $routeProvider
                    .when('/', {
                        templateUrl: '/app/views/default.html',
                        controller: ''
                    })
                    .when('/add/:type', {
                        templateUrl: '/app/views/add.html',
                        controller: ''
                    })
                    .when('/edit/:type/:id', {
                        templateUrl: '/app/views/edit.html',
                        controller: ''
                    })
                    .otherwise({
                        redirectTo: '/'
                    });
            }
        ]);
}