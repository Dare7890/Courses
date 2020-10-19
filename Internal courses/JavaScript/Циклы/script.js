"use strict";

//Task1

// for(var i = 1; i <= 10; i++){
	// if (i % 2 == 0)
		// alert(i);
// }

//Task2

// var value = 1;

// while (value <= 10){
	// if (value % 2 == 0){
	// alert(value);
	// }
	// value++;
// }

//Task3

// do{
// var result = prompt("Введите число", '');
// }while (result < 100 && result != null);

//Task4

var interval = 10; 

	loop:
for (var i = 2; i <= interval; i++){
	for (var j = 2; j < i; j++){
		if (i % j == 0){
			continue loop;
		} 
	}
	alert(i);
}