#!/bin/bash
cp -r "$1/Libs/ANGLE" "$2/ANGLE/"

if [ "$3" == "x64" ]; then 
	cp "$1""Libs/gdal-x64/"*.dll "$2"
	cp "$1""Libs/gdal-csharp/"*.dll "$2"
else
	cp "$1""Libs/gdal-x86/"*.dll "$2"
	cp "$1""Libs/gdal-csharp/"*.dll "$2"
fi
