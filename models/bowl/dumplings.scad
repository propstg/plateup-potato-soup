scale([scale, scale, scale])
translate([0, 0, 10]) {
	hull() {
		translate([-8, -6, 0]) sphere(d=12);
		translate([-5, -4, 2]) sphere(d=7);
	}
}
