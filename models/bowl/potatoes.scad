scale([scale, scale, scale])
translate([0, 0, 8]) {
	translate([5, -15, -1]) rotate([5, 5, 50]) cube([7, 7, 7]);
	translate([-10, 5, -1]) rotate([12, 5, -5]) cube([7, 7, 7]);
	translate([5, 0, 0]) rotate([-15, 15, 15]) cube([7, 7, 7]);
}
