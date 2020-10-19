"use strict";

//Task1

function checkAge(age) {
    return (age > 18) ? true : confirm('Родители разрешили?');
}

// function checkAge(age) {
    // return (age > 18) || confirm('Родители разрешили?');
// }

checkAge(15);

//Task2

function min(a,b){
	return (a > b) ? alert(a) : alert(b);
}

min(2, 4);

//Task3

function pow(x, n){
	var result = 1;
	for (var i = 0; i < n; i++){
		result *= x;
	}
	return result;
}

var x, n;

x = prompt("Введите значение", '');
n = prompt("Введите значение", '');

alert(pow(x, n));