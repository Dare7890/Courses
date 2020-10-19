"use strict";

//Task1

function ucFirst(str){
	return str.charAt(0).toUpperCase() + str.slice(1);
}

alert(ucFirst("Hello"));

//Task2

function checkSpam(str){
	var newStr = str.toLowerCase();
	if (str.indexOf("viagra") || str.indexOf("xxx")){
		return true;
	}
	else{
		return false;
	}
}

//Task3

function truncate(str, maxlength){
	if (str.length > maxlength)
		return str.substr(0, maxlength - 3) + "...";
	else
		return str;
}

alert(truncate("Вот, что мне хотелось бы сказать на эту тему:", 20));

//Task4

function extractCurrencyValue(str){
	return +str.slice(1);
}

alert(extractCurrencyValue("$120"));