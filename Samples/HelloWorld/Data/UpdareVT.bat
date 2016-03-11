dir /b *.hgt > TerrainFileList.txt

.\gdalbuildvrt.exe Terrain.vrt -input_file_list TerrainFileList.txt
.\gdaladdo.exe -r average Terrain.vrt 2 4 8 16 32 64 128 256 512 1024 2048 4096 8192 16384

pause