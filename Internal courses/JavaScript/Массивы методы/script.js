"use strict";

//Task1

var obj = {
  className: 'open menu'
}

function addClass(obj, cls){
	var arr = obj.className.split(' ');
	for (var i = 0; i < arr.length; i++) {
    if (arr[i] == cls) return;
  }
  arr.push(cls);

  obj.className = arr.join(' ');
}

addClass(obj, 'new');
addClass(obj, 'open');
addClass(obj, 'me');
alert(obj.className);

//Task2

function camelize(str){
	var arr = str.split('-');
	for (var i = 1; i < arr.length; i++) {
    arr[i] = arr[i].charAt(0).toUpperCase() + arr[i].slice(1);
  }
  return arr.join('');
}

//Task3 

var arr = ["HTML", "JavaScript", "CSS"];

var arrSorted = arr.slice().sort();
alert( arrSorted );
alert( arr );

//Task4 

function compareAge(personA, personB) {
  return personA.age - personB.age;
}

var vasya = { name: "Вася", age: 23 };
var masha = { name: "Маша", age: 18 };
var vovochka = { name: "Вовочка", age: 6 };

var people = [ vasya , masha , vovochka ];

people.sort(compareAge);

for(var i = 0; i < people.length; i++) {
  alert(people[i].name);
}