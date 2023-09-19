scale([scale, scale, scale])
difference() {
	union() {
		cylinder(d1=68, d2=70, h=2);
		translate([0, 0, 2]) cylinder(d=70, h=40);

		// handles
		translate([0, -35, 41])
		cube([15, 8, 2], center=true);
		translate([0, 35, 41])
		cube([15, 8, 2], center=true);


	}
	translate([0, 0, 1]) cylinder(d=69, h=72); // cutout
}
