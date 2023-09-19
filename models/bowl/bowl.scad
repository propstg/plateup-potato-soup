scale([scale, scale, scale]) {
	difference() {
		cylinder(d1=30, d2=40, h=15, $fn=8);
		translate([0, 0, 1])
		cylinder(d1=30, d2=40, h=15, $fn=8);
	}
}
