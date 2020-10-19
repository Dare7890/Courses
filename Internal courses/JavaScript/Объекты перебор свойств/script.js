"use strict";

//Task1

function isEmpty(obj){
	for (var key in obj)
		return false;
	return true;
}

var schedule = {};

alert( isEmpty(schedule) );

//Task2

var salaries = {
  "Вася": 100,
  "Петя": 300,
  "Даша": 250
};

var max = 0;
var name = "";
for (var salar in salaries){
	if (salaries[salar] > max){
		max = salaries[salar];
	name = salar;}
}
alert(name);

//Task3

var menu = {
  width: 200,
  height: 300,
  title: "My menu"
};

function multiplyNumeric(obj){
	for (var num in obj){
		if (isNumeric(obj[num])){
			obj[num] *= 2;
		}
	}
}

function isNumeric(n) {
  return !isNaN(parseFloat(n)) && isFinite(n)
}

multiplyNumeric(menu);

alert("menu width=" + menu.width + " height=" + menu.height + " title=" + menu.title );