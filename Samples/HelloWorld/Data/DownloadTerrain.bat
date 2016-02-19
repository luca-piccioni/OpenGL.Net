
SET BASE_WWW=http://dds.cr.usgs.gov/srtm/version2_1/SRTM3/Eurasia

.\wget.exe %BASE_WWW%/N44E009.hgt.zip
.\wget.exe %BASE_WWW%/N44E010.hgt.zip
.\wget.exe %BASE_WWW%/N44E011.hgt.zip
.\wget.exe %BASE_WWW%/N45E009.hgt.zip
.\wget.exe %BASE_WWW%/N45E010.hgt.zip
.\wget.exe %BASE_WWW%/N45E011.hgt.zip
.\wget.exe %BASE_WWW%/N46E009.hgt.zip
.\wget.exe %BASE_WWW%/N44E010.hgt.zip
.\wget.exe %BASE_WWW%/N44E011.hgt.zip

FOR /L %%LAT IN (41,42,43,44,45,46,47) DO \
FOR /L %%LON IN (005,006,007,008,009,010,011) DO \
echo %%G

pause