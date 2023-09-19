rm -rf stl
mkdir stl
echo "pot"
"C:\Program Files\OpenSCAD\openscad.exe" -o stl/pot.stl -D scale=0.01 --render ./pot.scad
echo "liquid"
"C:\Program Files\OpenSCAD\openscad.exe" -o stl/liquid.stl -D liquid_height=30 -D scale=0.01 --render ./liquid.scad
echo "foam"
"C:\Program Files\OpenSCAD\openscad.exe" -o stl/foam.stl -D liquid_height=30 -D scale=0.01 --render ./foam.scad
echo "potatoes"
"C:\Program Files\OpenSCAD\openscad.exe" -o stl/potatoes.stl -D liquid_height=30 -D scale=0.01 --render ./potatoes.scad
echo "dumplings"
"C:\Program Files\OpenSCAD\openscad.exe" -o stl/dumplings-0.stl -D liquid_height=30 -D dumpling_index=0 -D scale=0.01 --render ./dumplings.scad
"C:\Program Files\OpenSCAD\openscad.exe" -o stl/dumplings-1.stl -D liquid_height=30 -D dumpling_index=1 -D scale=0.01 --render ./dumplings.scad
"C:\Program Files\OpenSCAD\openscad.exe" -o stl/dumplings-2.stl -D liquid_height=30 -D dumpling_index=2 -D scale=0.01 --render ./dumplings.scad
