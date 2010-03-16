specr is a lightweight BDD framework for C#, built on the .NET 4.0 framework.
It is inspired by rspec, and I wrote parts of it to experiment with duck typing, using
some of the .NET 4.0 framework features.

It is designed to be dropped in to your existing unit testing framework. 
It provides a behaviour assertion syntax for C# objects:

var foo = "foo";

foo.Should().BeA<string>();
foo.Should().NotBeAn<int>()
foo.Should().Equal("foo"); 
foo.Should().NotEqual("bar"); 


Using some conventions, existing unit tests can then be written in a BDD style:

[TestClass]
class DescribePerson
{
	private Creature person;


	[TestInitialize]
	public void Before()
	{
		person = new Person();		
		person.IsBig = true;	
		person.Father = new Person();	
	}	

	[TestMethod]
	public static void It_Should_Be_Awesome()
	{
		person.Should().Be().Big();
	}

  [TestMethod]
	public static void It_Should_Have_A_Father()
	{
		person.Should().HaveA().Father();
	}

} 

This is using the dynamic boolean asserts. 
If you are follow the convention of naming your bool properties in the form "IsSomeValue", specr will 
be able to assert boolean property values using the Be().SomeValue() and NotBe.SomeValue() dynamic methods.
Similary, the HaveA() and and NotHaveA() methods will assert for a not null and null member respectively.

You'll be able to run the unit test above just like any normal unit test. No post build, code generation tools
are needed.

One of specr goals is to target multiple unit test frameworks. It was built using the VisualStudio test framework and 
should also support NUnit (Although I could not get a version of NUnit that could run on my .NET 4 framework version.) 

Since specr is a very lighweight framework, it has just a few specs, all of them written in a BDD style 
using specr itself. 

I'll probably be adding some specs and functionality with time as I use specr.

It's name is also inspired by rspec. As in rspec are first, specr are last. (Lame, I know)


LICENSE
 
    Copyright (c) 2010 Michael Erasmus
    
    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to
    deal in the Software without restriction, including without limitation the
    rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
    sell copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:
      
    The above copyright notice and this permission notice shall be included in
    all copies or substantial portions of the Software.
       
    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
    THE AUTHORS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
    IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
    CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE

