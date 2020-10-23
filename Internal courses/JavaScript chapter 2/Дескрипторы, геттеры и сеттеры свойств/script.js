"use strict";

//Task1

function User(fullName) {
  this.fullName = fullName;
	
	Object.defineProperties(this, {
	firstName: {
		
	  get: function(){
		  var value = fullName.split(' ');
		  return value[0];
	  },
	  
	  set: function (value){
		  this.fullName = value + ' ' + this.lastName;
	}},
	  
	 lastName: {
	  get: function(){
		  var value = fullName.split(' ');
		  return value[1];
	  },
	  
	  set: function(value){
		  this.fullName = this.firstName + ' ' + value;
	  }
	 }
	});
}


var vasya = new User("Василий Попкин");

// чтение firstName/lastName
alert( vasya.firstName ); // Василий
alert( vasya.lastName ); // Попкин

// запись в lastName
vasya.lastName = 'Сидоров';

alert( vasya.fullName ); // Василий Сидоров