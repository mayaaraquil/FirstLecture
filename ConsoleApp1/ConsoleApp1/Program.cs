﻿using System.Net.Cache;

//create a variable called x and give it a value of 5
int age = 5;
string name = "Maya";
string name2 = "Kyle";
/*
 * validate the number variable
 * do something if validated
 */
if (age == 1)
{

}

//declaring variables
int money;
//initialize variable
money = 5;
//combined
bool hungry = true;

//Constant
const double taxRate = 0.06;
//taxRate = 6; // not allowed to change constants
//Console.WriteLine(taxRate)

Console.WriteLine("please enter a radius");
//string entry = Console.ReadLine();
//double value = double.Parse(entry));
double value = double.Parse(Console.ReadLine());
double area = Math.PI * Math.Pow(value, 2);
Console.WriteLine(area);

//increment/decrement




//odd or even
Console.WriteLine("Please enter a number");
int input = int.Parse(Console.ReadLine());
int oddCheck = input % 2;
if(oddCheck ==0)
{
    Console.WriteLine("even");
}
else if(oddCheck ==1)
{
    Console.WriteLine("odd");
}


//assignment
value = 0;
value = age * 100 - Math.PI;

int assign = 0;
Console.WriteLine(assign);
assign = 5;
Console.WriteLine(assign);
assign += 2;
Console.WriteLine(assign);
assign -= 5;
Console.WriteLine(assign);

//null
string catName = null;
Console.Write(catName);
catName = "Felony";
Console.WriteLine(catName);

string y = null;

if(y == null)
{
    y = "oogabooga";
}

//nonnullable
//int z = null;

