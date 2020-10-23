"use strict";

//Task1

var firstValue = prompt("Введите первое значение", '');
var secondValue = prompt("Введите второе значение", '');

alert(+firstValue + +secondValue);

//Task2

var fi = (1 + Math.sqrt(5))/2;

function fibBinet(n){
	return Math.round(Math.pow(fi, n) / Math.sqrt(5));
}

alert(fibBinet(77));

//Task3

var min = 4;
var max = 10;

alert(Math.random() * (max - min) + min);

//Task3

var min = 4;
var max = 10;

alert(Math.floor(Math.random() * (max - min + 1) + min));