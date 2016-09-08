/*
This file in the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkId=518007
*/
'use strict';
let fs = require('fs');
let spawn = require('child_process').spawn;

let gulp = require('gulp');
let $ = require('gulp-load-plugins')({ lazy: true });

gulp.task('setdb', function () {
    AddDbInfo();
});

gulp.task('removedb', function () {
    RemoveDbInfo();
});

gulp.task('run', () => {
    AddDbInfo();
    let dotnet = spawn('dotnet', ['run']);
    dotnet.stdout.pipe(process.stdout);
    dotnet.on('close', (code) => {
        RemoveDbInfo();
    })
});

gulp.task('build', () => {
    let dotnet = spawn('dotnet', ['build']);
    dotnet.stdout.pipe(process.stdout);
});

gulp.task('restore', () => {
    let dotnet = spawn('dotnet', ['restore']);
    dotnet.stdout.pipe(process.stdout);
});

gulp.task('db:update', () => {
    AddDbInfo();
    let dotnet = spawn('dotnet', ['ef', 'database', 'update']);
    dotnet.stdout.pipe(process.stdout);
    dotnet.on('close', (code) => {
        RemoveDbInfo();
    })
});


gulp.task('default', ['help']);
gulp.task('help', $.taskListing);

// basic functions
function AddDbInfo() {
    fs.readFile('dbinfo.txt', 'utf8', (err, dbinfo) => {
        fs.readFile('appsettings.json', 'utf8', (err, appSettings) => {
            var newAppSettings = appSettings.replace('{replace}', dbinfo);
            fs.writeFile('appsettings.json', newAppSettings, (err) => {
                if (err) throw err;
                console.log('done');
            });
        });
    });
}

function RemoveDbInfo() {
    fs.readFile('dbinfo.txt', 'utf8', (err, dbinfo) => {
        fs.readFile('appsettings.json', 'utf8', (err, appSettings) => {
            var newAppSettings = appSettings.replace(dbinfo, '{replace}');
            fs.writeFile('appsettings.json', newAppSettings, (err) => {
                if (err) throw err;
                console.log('done');
            });
        });
    });
}