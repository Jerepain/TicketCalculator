REM http://www.imagemagick.org/script/binary-releases.php

for %%c in (284 142 71 107 89 600 300 150 225 188 1240 620 310 465 388 176 88 44 66 55 256 48 24 16 200 100 75 63 50 96 36 30) do (
	convert -size %%c %1.svg %%cx%%c.png
)