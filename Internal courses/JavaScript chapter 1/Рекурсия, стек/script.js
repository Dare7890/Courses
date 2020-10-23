"use strict";

//Task1

function sumTo(n) {
    if (n != 1)
		return n + sumTo(n - 1);
	else
		return n;
}

alert(sumTo(5));

//Task2

function factorial(n) {
    if (n != 1)
		return n * factorial(n - 1);
	else
		return 1;
}

alert(factorial(5));