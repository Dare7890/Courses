"use strict";

function isInteger(num){
	if (num == (num ^ 0))
		return true;
	else
		return false;
}

alert(isInteger(3));
alert(isInteger(-3.5));
alert(isInteger(3.5));