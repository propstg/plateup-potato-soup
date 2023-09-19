scale([scale, scale, scale])
translate([0, 0, liquid_height]) {
	if (dumpling_index == -1 || dumpling_index == 0) {
		hull() {
			translate([3, -10, 0]) sphere(d=12);
			translate([6, -12, 0]) sphere(d=8);
		}
	}
	color("red")
	if (dumpling_index == -1 || dumpling_index == 1) {
		hull() {
			translate([9, 18, 0]) sphere(d=12);
			translate([5, 18, 2]) sphere(d=7);
		}
	}
	if (dumpling_index == -1 || dumpling_index == 2) {
		hull() {
			translate([-17, 10, 0]) sphere(d=12);
			translate([-17, 14, 2]) sphere(d=6);
		}
	}
}
