rm -rf stl
mkdir stl
echo "bowl"
"C:\Program Files\OpenSCAD\openscad.exe" -o stl/bowl.stl -D scale=0.01 --render ./bowl.scad
echo "liquid"
"C:\Program Files\OpenSCAD\openscad.exe" -o stl/liquid.stl -D scale=0.01 --render ./liquid.scad
echo "potatoes"
"C:\Program Files\OpenSCAD\openscad.exe" -o stl/potatoes.stl -D scale=0.01 --render ./potatoes.scad
echo "dumplings"
"C:\Program Files\OpenSCAD\openscad.exe" -o stl/dumplings.stl -D scale=0.01 --render ./dumplings.scad
