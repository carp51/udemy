using System;
namespace Exercise501;

public class Person
{
	public string name = "";
	public int age = 0;

	public void ShowAgeAndName()
	{
		Console.WriteLine("name:{0} age:{1}", name, age);
	}

	public void SetAgeAndName(string name, int age)
	{
		this.name = name;
		this.age = age;
	}
}
