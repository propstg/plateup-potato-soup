scale([scale, scale, scale])
translate([0, 0, liquid_height - 2]) {
	translate([15, 15, 0]) rotate([15, 15, 15]) cube([7, 7, 7]);
	translate([5, 0, 0]) rotate([-15, 15, 15]) cube([7, 7, 7]);
	translate([15, -25, 0]) rotate([-15, 5, 15]) cube([8, 8, 8]);
	translate([-17, -5, 0]) rotate([-5, 5, 55]) cube([7, 7, 5]);
	translate([-12, 13, 1]) rotate([-25, 15, 0]) cube([9, 7, 5]);
	translate([-8, -20, 0]) rotate([15, 5, 0]) cube([9, 7, 5]);
	translate([-25, -18, 0]) rotate([15, 20, 0]) cube([8, 8, 5]);
color("red")
	translate([0, -32, 0]) rotate([15, 5, 50]) cube([7, 7, 5]);
}
