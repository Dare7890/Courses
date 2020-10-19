"use strict";

//Task1

var goods = [1, 2, 3, 4];

alert(goods[goods.length - 1]);

//Task2
goods.push("Компьютер");
alert(goods);

//Task3

var styles  = ["Джаз", "Блюз"];
styles.pop("Рок-н-Ролл");
styles[styles.length - 2] = "Классика";
alert(styles.shift());
styles.unshift("Рэп", "Регги");
alert(styles);

//Task4

var arr = ["Яблоко", "Апельсин", "Груша", "Лимон"];

var rand = Math.floor(Math.random() * arr.length);

alert( arr[rand] );

