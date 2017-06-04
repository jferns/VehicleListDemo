module.exports = function (grunt) {

    'use strict';

    require('load-grunt-tasks')(grunt);

    grunt.initConfig({

        config: {
            jsroot: 'js/',
            cssroot: 'css/',
            lessroot: 'less/',
            confoutput: 'conf/'
        },

        less: {
            dev: {
                files: {
                    'content/css/site.css': ['content/less/site.less']
                }
            },
            production: {
                options: { cleancss: true },
                files: {
                    'content/css/site.css': ['content/less/site.less']
                }
            }
        },

        bowercopy: {
            options: {
                srcPrefix: 'bower_components',
                report: true,
                clean: false
            },
            dev: {
                options: {
                    destPrefix: 'content'
                },
                files: {
                    '<%= config.jsroot %>/angular.js': 'angular/angular.js',
                    '<%= config.jsroot %>/angular-aria.js': 'angular-aria/angular-aria.js',
                    '<%= config.jsroot %>/angular-route.js': 'angular-route/angular-route.js',

                    '<%= config.jsroot %>/angular-sanitize.js': 'angular-sanitize/angular-sanitize.js',
                    '<%= config.jsroot %>/angular-resource.js': 'angular-resource/angular-resource.js',
                    '<%= config.jsroot %>/bootstrap.min.js': 'bootstrap/dist/js/bootstrap.min.js',

                    '<%= config.jsroot %>/jquery.js': 'jquery/jquery.js',
                    '<%= config.jsroot %>/ui-bootstrap-tpls.js': 'angular-bootstrap/ui-bootstrap-tpls.js',

                    '<%= config.cssroot %>/bootstrap.css': 'bootstrap/dist/css/bootstrap.css',
                }
            }
        },

        jshint: {
            options: {
                jshintrc: '<%= config.confoutput %>.jshintrc',
                reporter: require('jshint-stylish'),
                ignores: [
                    'app/xxxxxx/**/*.js'
                ]
            },
            files: {
                src: [
                    'app/**/*.js'
                ]
            }
        },

        clean: {
            coverage: ['coverage']
        },

        auto_install: {
            local: {}
        },

        requirejs: {
            compile: {
                options: {
                    baseUrl: 'public',
                    mainConfigFile: 'public/js/main.js',
                    dir: '.public',
                    optimize: 'uglify',
                    modules: [
                        { name: 'js/main' }
                    ]
                }
            }
        },

        karma: {

            options: {
                frameworks: ['mocha', 'requirejs', 'chai'],
                reporters: ['spec'],
                files: [
                    { pattern: 'public/components/**/*.js', included: false },
                    { pattern: 'public/js/**/*.js', included: false },
                    { pattern: 'test/browser/utils.js', included: false },
                    { pattern: 'test/browser/unit/**/*.js', included: false },
                    'test/browser/main.js'
                ]
            },

            unit: {
                options: {
                    port: 9999,
                    browsers: ['PhantomJS'],
                    autoWatch: false,
                    singleRun: true
                }
            }

            /*integration: {
                ...
            }*/
        }
    });

    grunt.registerTask('do-less-dev', ['less:dev']);

    grunt.registerTask('build', [
        'auto_install'
        , 'bowercopy:dev'
        , 'do-less-dev'
        , 'jshint'
    ]);

};

// [1] Not using server-side controllers in order to simplify things