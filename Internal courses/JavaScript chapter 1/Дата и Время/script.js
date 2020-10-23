"use strict";

//Task1

var date = new Date(2012, 1, 20, 3, 12);
alert(date);

//Task2

var date = new Date(2012,0,3);
alert( date.toLocaleString('ru', {weekday: 'short'}) );

//Task3

function getDateAgo(date, days) {
  var newDate = new Date(date);

  newDate.setDate(date.getDate() - days);
  return newDate.getDate();
}

var date = new Date(2015, 0, 2);

alert( getDateAgo(date, 1) );
alert( getDateAgo(date, 2) );
alert( getDateAgo(date, 365) );

//Task4

function getLastDayOfMonth(year, month) {
  var date = new Date(year, month + 1, 0);
  return date.getDate();
}

//Task5 

function getSecondsToday() {
  var now = new Date();
  var today = new Date(now.getFullYear(), now.getMonth(), now.getDate());
  var diff = now - today;
  return Math.floor(diff / 1000);
}
alert( getSecondsToday() );

//Task6

function getSecondsToTomorrow() {
  var now = new Date();
  var today = new Date(now.getFullYear(), now.getMonth(), now.getDate() + 1);
  var diff = now - today;
  return Math.floor(diff / 1000);
}
alert( getSecondsToTomorrow() );

